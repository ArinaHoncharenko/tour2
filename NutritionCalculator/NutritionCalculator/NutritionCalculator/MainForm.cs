using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using DocumentFormat.OpenXml.Bibliography;

namespace NutritionCalculator
{
    public partial class MainForm : Form
    {
        private Dictionary<string, FoodItem> foodItems;
        private Dictionary<string, PocketFood> pocketFoods;
        private Dictionary<string, SweetFood> sweetFoods;
        private Dictionary<string, FirstDish> firstDishes;
        private Dictionary<string, Drink> drinks;
        private string rationText;

        public MainForm()
        {
            InitializeComponent();
            InitializeData();
        }
        private void InitializeData()
        {
            string executablePath = AppDomain.CurrentDomain.BaseDirectory;
            string parentDirectory = Directory.GetParent(Directory.GetParent(Directory.GetParent(executablePath)?.FullName)?.FullName)?.FullName;

            string sweetFoodJsonFilePath = Path.Combine(parentDirectory, "foodCategories", "sweetFood.json");
            string foodjsonFilePath = Path.Combine(parentDirectory, "foodCategories", "food.json");
            string pocketFoodJsonFilePath = Path.Combine(parentDirectory, "foodCategories", "pocketFood.json");
            string firstDishJsonFilePath = Path.Combine(parentDirectory, "foodCategories", "firstDish.json");
            string drinkhJsonFilePath = Path.Combine(parentDirectory, "foodCategories", "drink.json");

            try
            {
                string json = File.ReadAllText(sweetFoodJsonFilePath);
                sweetFoods = JsonConvert.DeserializeObject<Dictionary<string, SweetFood>>(json);
                json = File.ReadAllText(foodjsonFilePath);
                foodItems = JsonConvert.DeserializeObject<Dictionary<string, FoodItem>>(json);
                json = File.ReadAllText(pocketFoodJsonFilePath);
                pocketFoods = JsonConvert.DeserializeObject<Dictionary<string, PocketFood>>(json);
                json = File.ReadAllText(firstDishJsonFilePath);
                firstDishes = JsonConvert.DeserializeObject<Dictionary<string, FirstDish>>(json);
                json = File.ReadAllText(drinkhJsonFilePath);
                drinks = JsonConvert.DeserializeObject<Dictionary<string, Drink>>(json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при завантаженні: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void CalculateNutrition()
        {
            try
            {
                int complexity = (int)complexityNumericUpDown.Value;
                int duration = (int)durationNumericUpDown.Value;
                int mealsPerDay = 3;


                resultDataGridView.Rows.Clear();
                resultDataGridView.Columns.Clear();

                resultDataGridView.Columns.Add("Day", "День");
                resultDataGridView.Columns.Add("Meal", "Прийом їжі");
                resultDataGridView.Columns.Add("ProductName", "Назва продукту");
                resultDataGridView.Columns.Add("DailyCalories", " Калорійність");
                resultDataGridView.Columns.Add("DailyWeight", "Вага (г)");
                resultDataGridView.Columns.Add("DailyWater", "Об'єм води для приготування(мл)");
                resultDataGridView.Columns.Add("Taste", "Смак");

                foreach (DataGridViewColumn column in resultDataGridView.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                    column.MinimumWidth = 70;
                }

                Random random = new Random();


                for (int day = 1; day <= duration; day++)
                {
                    bool isRationValid = false;
                    double minDailyCalories = GetMinDailyCalories(complexity);

                    while (!isRationValid)
                    {
                        int startIndex = resultDataGridView.Rows.Count;
                        int endIndex = startIndex;
                        resultDataGridView.Rows.Add($"День {day}", "", "", "", "", "", "", "");
                        List<KeyValuePair<string, PocketFood>> selectedSnacks = new List<KeyValuePair<string, PocketFood>>();

                        double totalSnackCalories = 0;
                        double totalCalories = 0;
                        double totalWeight = 0;
                        double totalWater = 0;

                        CallSnacks(random, totalSnackCalories, selectedSnacks, complexity, duration);

                        for (int meal = 1; meal <= mealsPerDay; meal++)
                        {
                            KeyValuePair<string, FoodItem> randomFoodItem = foodItems.ElementAt(random.Next(foodItems.Count));
                            string foodName = randomFoodItem.Key;
                            FoodItem foodItem = randomFoodItem.Value;

                            KeyValuePair<string, PocketFood> randomPocketFood = pocketFoods.ElementAt(random.Next(pocketFoods.Count));
                            string pocketFoodName = randomPocketFood.Key;
                            PocketFood pocketFood = randomPocketFood.Value;

                            KeyValuePair<string, Drink> randomDrink = drinks.ElementAt(random.Next(drinks.Count));
                            string drinkName = randomDrink.Key;
                            FoodItem drink = randomDrink.Value;

                            KeyValuePair<string, SweetFood> randomSweetFood = sweetFoods.ElementAt(random.Next(sweetFoods.Count));
                            string sweetFoodName = randomSweetFood.Key;
                            SweetFood sweetFood = randomSweetFood.Value;

                            KeyValuePair<string, FirstDish> randomFirstDish = firstDishes.ElementAt(random.Next(firstDishes.Count));
                            string firstDishName = randomFirstDish.Key;
                            FirstDish firstDish = randomFirstDish.Value;

                            if ((meal == 1) && foodItem.Calories > 50 * complexity + 200 && foodItem.Taste != "солодке")
                            {
                                resultDataGridView.Rows.Add($"", $"Сніданок", foodName, foodItem.Calories, foodItem.Weight, foodItem.Water, foodItem.Taste, "");
                                CallSnacks(random, totalSnackCalories, selectedSnacks, complexity, duration);
                                resultDataGridView.Rows.Add($"", "", drinkName, drink.Calories, drink.Weight, drink.Water, drink.Taste, "");
                            }
                            else if (meal == 2 && foodItem.Calories > 50 * complexity + 150 && foodItem.Taste != "солодке")
                            {
                                bool useFirstDish = random.Next(2) == 0; // Випадковий вибір між FoodItem та FirstDish

                                if (useFirstDish)
                                {
                                    resultDataGridView.Rows.Add($"", $"Обід", firstDishName, firstDish.Calories, firstDish.Weight, firstDish.Water, firstDish.Taste, "");
                                    CallSnacks(random, totalSnackCalories, selectedSnacks, complexity, duration);
                                    resultDataGridView.Rows.Add($"", "", drinkName, drink.Calories, drink.Weight, drink.Water, drink.Taste, "");
                                }
                                else
                                {
                                    resultDataGridView.Rows.Add($"", $"Обід", foodName, foodItem.Calories, foodItem.Weight, foodItem.Water, foodItem.Taste, "");
                                    CallSnacks(random, totalSnackCalories, selectedSnacks, complexity, duration);
                                    resultDataGridView.Rows.Add($"", "", drinkName, drink.Calories, drink.Weight, drink.Water, drink.Taste, "");
                                }
                            }
                            else if (meal == 3)
                            {
                                if (complexity > 1)
                                {
                                    resultDataGridView.Rows.Add($"", $"Вечеря", foodName, foodItem.Calories, foodItem.Weight, foodItem.Water, foodItem.Taste, "");
                                    CallSnacks(random, totalSnackCalories, selectedSnacks, complexity, duration);
                                    resultDataGridView.Rows.Add($"", "", drinkName, drink.Calories, drink.Weight, drink.Water, drink.Taste, "");
                                    endIndex = resultDataGridView.Rows.Count-1;
                                }
                                else 
                                {
                                    resultDataGridView.Rows.Add($"", $"Вечеря", sweetFoodName, sweetFood.Calories, sweetFood.Weight, sweetFood.Water, sweetFood.Taste);
                                    CallSnacks(random, totalSnackCalories, selectedSnacks, complexity, duration);
                                    resultDataGridView.Rows.Add($"", "", drinkName, drink.Calories, drink.Weight, drink.Water, drink.Taste, "");
                                    endIndex = resultDataGridView.Rows.Count-1;
                                }
                            }
                            else
                            {
                                meal--;
                            }
                        }

                            for (int rowIndex = startIndex; rowIndex <= endIndex; rowIndex++)
                            {
                                if (resultDataGridView.Rows[rowIndex].Cells["DailyCalories"].Value != null)
                                    totalCalories += Convert.ToDouble(resultDataGridView.Rows[rowIndex].Cells["DailyCalories"].Value);
                                if (resultDataGridView.Rows[rowIndex].Cells["DailyWeight"].Value != null)
                                    totalWeight += Convert.ToDouble(resultDataGridView.Rows[rowIndex].Cells["DailyWeight"].Value);
                                if (resultDataGridView.Rows[rowIndex].Cells["DailyWater"].Value != null)
                                    totalWater += Convert.ToDouble(resultDataGridView.Rows[rowIndex].Cells["DailyWater"].Value);
                            }

                        int totalRowIndex = resultDataGridView.Rows.Add("", "Усього", "", totalCalories, totalWeight, totalWater, "", "");
                        resultDataGridView.Rows[totalRowIndex].DefaultCellStyle.Font = new Font("Century Gothic", 12, FontStyle.Bold);
                        if (totalCalories >= minDailyCalories)
                        {
                            isRationValid = true;
                        }
                        else
                        {
                            for (int i = endIndex; i >= startIndex-1; i--)
                            {
                                resultDataGridView.Rows.RemoveAt(i);
                            }
                        }
                        

                        
                    }
                }

                rationText = GetRationText();

                resultDataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при розрахунку: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CallSnacks(Random random, double totalSnackCalories, List<KeyValuePair<string, PocketFood>> selectedSnacks, int complexity, int duration)
        {
            for (int pocketMeal = 1; pocketMeal <= 1; pocketMeal++)
            {
                KeyValuePair<string, PocketFood> randomPocketFood = pocketFoods.ElementAt(random.Next(pocketFoods.Count));
                string pocketFoodName = randomPocketFood.Key;
                PocketFood pocketFood = randomPocketFood.Value;

                if (totalSnackCalories + pocketFood.Calories <= (500 + 100 * complexity))
                {
                    if (selectedSnacks.Count == 0)
                    {
                        resultDataGridView.Rows.Add("", "Снеки", pocketFoodName, pocketFood.Calories, pocketFood.Weight, pocketFood.Water, pocketFood.Taste, "");
                    }
                    else
                    {
                        resultDataGridView.Rows.Add("", "", pocketFoodName, pocketFood.Calories, pocketFood.Weight, pocketFood.Water, pocketFood.Taste, "");
                    }
                    selectedSnacks.Add(randomPocketFood);
                    totalSnackCalories += pocketFood.Calories;
                    PickSnacks(totalSnackCalories, selectedSnacks, random, complexity, duration);
                }
            }
        }

        private void PickSnacks(double totalSnackCalories, List<KeyValuePair<string, PocketFood>> selectedSnacks, Random random,int complexity, int duration)
        {
            if (totalSnackCalories < (200+100*complexity) && selectedSnacks.Count < duration * 8)
            {
                KeyValuePair<string, PocketFood>? randomPocketFood = null;
                string pocketFoodName = null;
                PocketFood pocketFood = null;

                do
                {
                    randomPocketFood = pocketFoods.ElementAtOrDefault(random.Next(pocketFoods.Count));
                    if (randomPocketFood != null)
                    {
                        pocketFoodName = randomPocketFood.Value.Key;
                        pocketFood = randomPocketFood.Value.Value;
                    }
                } while (randomPocketFood != null && selectedSnacks.Any(s => s.Key == pocketFoodName)); 

                if (randomPocketFood != null && totalSnackCalories + pocketFood.Calories <= (500 + 100 * complexity))
                {
                    resultDataGridView.Rows.Add("", "", pocketFoodName, pocketFood.Calories, pocketFood.Weight, pocketFood.Water, pocketFood.Taste, "");
                    selectedSnacks.Add(randomPocketFood.Value);
                    totalSnackCalories += pocketFood.Calories;
                }
                else
                {
                    bool found = false;
                    foreach (var snack in pocketFoods)
                    {
                        if (totalSnackCalories + snack.Value.Calories <= (500 + 100 * complexity))
                        {
                            resultDataGridView.Rows.Add("", "", snack.Key, snack.Value.Calories, snack.Value.Weight, snack.Value.Water, snack.Value.Taste, "");
                            selectedSnacks.Add(snack);
                            totalSnackCalories += snack.Value.Calories;
                            found = true;
                            break;
                        }
                    }

                    if (!found)
                    {
                        MessageBox.Show("Не вдалося знайти снек з необхідною калорійністю.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private double GetMinDailyCalories(int complexity)
        {
            double minDailyCalories = 0;

            switch (complexity)
            {
                case 1:
                    minDailyCalories = 3100;
                    break;
                case 2:
                    minDailyCalories = 3400;
                    break;
                case 3:
                    minDailyCalories = 3700;
                    break;
            }

            return minDailyCalories;
        }

        private void calculateRationButton_Click(object sender, EventArgs e)
        {
            resultDataGridView.Rows.Clear();
            CalculateNutrition();
        }

        private string GetRationText()
        {
            StringBuilder sb = new StringBuilder();
            foreach (DataGridViewRow row in resultDataGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    sb.Append(cell.Value);
                    sb.Append("\t");
                }
                sb.AppendLine();
            }

            return sb.ToString();
        }

        private void navigationSaveRation_Click(object sender, EventArgs e)
        {
            if (resultDataGridView.Rows.Count == 0)
            {
                MessageBox.Show("Немає даних для збереження.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (Form overlayForm = new Form())
            {
                overlayForm.FormBorderStyle = FormBorderStyle.None;
                overlayForm.BackColor = Color.Black;
                overlayForm.Opacity = 0.5;
                overlayForm.Size = new Size(this.Size.Width - 15, this.Size.Height - 7);

                Point productsFormLocation = this.Location;
                overlayForm.Location = new Point(productsFormLocation.X + 8, productsFormLocation.Y);
                overlayForm.StartPosition = FormStartPosition.Manual;
                overlayForm.Show(this);

                SaveRationForm saveRationForm = new SaveRationForm(rationText);
                saveRationForm.StartPosition = FormStartPosition.CenterParent;
                saveRationForm.ShowDialog(overlayForm);

                overlayForm.Close();
            }
        }

        private void navigationbtnProductsMenu_Click(object sender, EventArgs e)
        {
            ProductsForm productsForm = new ProductsForm(foodItems.Values.ToList(), firstDishes.Values.ToList(), sweetFoods.Values.ToList(), pocketFoods.Values.ToList(), drinks.Values.ToList());
            productsForm.StartPosition = FormStartPosition.CenterParent;
            productsForm.ShowDialog();
            InitializeData();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {

            using (Form overlayForm = new Form())
            {
                overlayForm.FormBorderStyle = FormBorderStyle.None;
                overlayForm.BackColor = Color.Black;
                overlayForm.Opacity = 0.5;
                overlayForm.Size = new Size(this.Size.Width - 15, this.Size.Height - 7);

                Point productsFormLocation = this.Location;
                overlayForm.Location = new Point(productsFormLocation.X + 8, productsFormLocation.Y); 
                overlayForm.StartPosition = FormStartPosition.Manual;
                overlayForm.Show(this);

                using (ComplexityLevelForm complexityLevelForm = new ComplexityLevelForm())
                {

                    complexityLevelForm.StartPosition = FormStartPosition.CenterParent;
                    complexityLevelForm.ShowDialog(overlayForm);

                    if (complexityLevelForm.DialogResult == DialogResult.OK)
                    {
                        overlayForm.Close();
                        complexityNumericUpDown.Value = complexityLevelForm.SelectedComplexityCategory;
                        durationNumericUpDown.Value = complexityLevelForm.DurationDays;
                        calculateRationButton_Click( sender, e);
                    }
                }
            }
        }
    }

    public class FoodItem
    {
        public string Name { get; set; }
        public double Calories { get; set; }
        public double Weight { get; set; }
        public double Water { get; set; }
        public string Taste { get; set; }
    }

    public class PocketFood : FoodItem
    {
        public PocketFood() => Water = 0;
    }

    public class SweetFood : FoodItem
    {
        public SweetFood() => Taste = "солодкий";
    }
    public class FirstDish : FoodItem
    {
    }
    public class Drink : FoodItem
    {
    }
}