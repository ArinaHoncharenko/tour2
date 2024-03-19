using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Drawing;


namespace NutritionCalculator
{
    public partial class ProductsForm : Form
    {
        private List<FoodItem> foodItems;
        private List<FirstDish> firstDishes;
        private List<SweetFood> sweetFoods;
        private List<PocketFood> pocketFoods;
        private List<Drink> drinks;
        public ProductsForm(List<FoodItem> foodItems, List<FirstDish> firstDishes, List<SweetFood> sweetFoods, List<PocketFood> pocketFoods, List<Drink> drinks)
        {
            InitializeComponent();
            this.foodItems = foodItems;
            this.firstDishes = firstDishes;
            this.sweetFoods = sweetFoods;
            this.pocketFoods = pocketFoods;
            this.drinks = drinks;
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            productsDataGridView.Rows.Clear();
            productsDataGridView.Columns.Clear();

            productsDataGridView.Columns.Add("Category", "Категорія");
            productsDataGridView.Columns.Add("ProductName", "Назва продукту");
            productsDataGridView.Columns.Add("Calories", "Калорії");
            productsDataGridView.Columns.Add("Weight", "Вага (г)");
            productsDataGridView.Columns.Add("Water", "Об'єм води (мл)");
            productsDataGridView.Columns.Add("Taste", "Смак");

            productsDataGridView.Rows.Add("Основні страви", "", "", "", "", "");

            foreach (var foodItem in foodItems)
            {
                productsDataGridView.Rows.Add("", foodItem.Name, foodItem.Calories, foodItem.Weight, foodItem.Water, foodItem.Taste);
            }

            productsDataGridView.Rows.Add("Перші страви", "", "", "", "", "");

            foreach (var firstDish in firstDishes)
            {
                productsDataGridView.Rows.Add("", firstDish.Name, firstDish.Calories, firstDish.Weight, firstDish.Water, firstDish.Taste);
            }

            productsDataGridView.Rows.Add("Солодкі страви", "", "", "", "", "");

            foreach (var sweetFood in sweetFoods)
            {
                productsDataGridView.Rows.Add("", sweetFood.Name, sweetFood.Calories, sweetFood.Weight, sweetFood.Water, sweetFood.Taste);
            }

            productsDataGridView.Rows.Add("Снеки", "", "", "", "", "");

            foreach (var pocketFood in pocketFoods)
            {
                productsDataGridView.Rows.Add("", pocketFood.Name, pocketFood.Calories, pocketFood.Weight, pocketFood.Water, pocketFood.Taste);
            }

            productsDataGridView.Rows.Add("Напої", "", "", "", "", "");

            foreach (var drink in drinks)
            {
                productsDataGridView.Rows.Add("", drink.Name, drink.Calories, drink.Weight, drink.Water, drink.Taste);
            }

            productsDataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }


        private void navigationAddProduct_Click(object sender, EventArgs e)
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

                using (AddProductForm addProductForm = new AddProductForm())
                {
                    addProductForm.StartPosition = FormStartPosition.CenterParent;
                    addProductForm.ShowDialog(overlayForm);

                    if (addProductForm.DialogResult == DialogResult.OK)
                    {
                        string name = addProductForm.ProductName;
                        double calories = addProductForm.Calories;
                        double weight = addProductForm.Weight;
                        double water = addProductForm.Water;
                        string taste = addProductForm.Taste;
                        string category = addProductForm.Category;

                        string executablePath = AppDomain.CurrentDomain.BaseDirectory;
                        string parentDirectory = Directory.GetParent(Directory.GetParent(Directory.GetParent(executablePath)?.FullName)?.FullName)?.FullName;
                        string filePath = "";

                        switch (category)
                        {
                            case "Основні страви":
                                filePath = Path.Combine(parentDirectory, "foodCategories", "food.json"); 
                                break;
                            case "Перші страви":
                                filePath = Path.Combine(parentDirectory, "foodCategories", "firstDish.json");
                                break;
                            case "Солодкі страви":
                                filePath = Path.Combine(parentDirectory, "foodCategories", "sweetFood.json");
                                break;
                            case "Снеки":
                                filePath = Path.Combine(parentDirectory, "foodCategories", "pocketFood.json");
                                break;
                            case "Напої":
                                filePath = Path.Combine(parentDirectory, "foodCategories", "drink.json");
                                break;
                        }

                        if (!string.IsNullOrEmpty(filePath))
                        {
                            if (category == "Основні страви")
                            {
                                FoodItem newFoodItem = new FoodItem { Name = name, Calories = calories, Weight = weight, Water = water, Taste = taste };
                                foodItems.Add(newFoodItem);
                                SaveProductsToFile(foodItems, filePath);
                            }
                            else if (category == "Перші страви")
                            {
                                FirstDish newFirstDish = new FirstDish { Name = name, Calories = calories, Weight = weight, Water = water, Taste = taste };
                                firstDishes.Add(newFirstDish);
                                SaveProductsToFile(firstDishes, filePath);
                            }
                            else if (category == "Солодкі страви")
                            {
                                SweetFood newSweetFood = new SweetFood { Name = name, Calories = calories, Weight = weight, Water = water, Taste = taste };
                                sweetFoods.Add(newSweetFood);
                                SaveProductsToFile(sweetFoods, filePath);
                            }
                            else if (category == "Снеки")
                            {
                                PocketFood newPocketFood = new PocketFood { Name = name, Calories = calories, Weight = weight, Water = water, Taste = taste };
                                pocketFoods.Add(newPocketFood);
                                SaveProductsToFile(pocketFoods, filePath);
                            }
                            else if (category == "Напої")
                            {
                                Drink newDrink = new Drink { Name = name, Calories = calories, Weight = weight, Water = water, Taste = taste };
                                drinks.Add(newDrink);
                                SaveProductsToFile(drinks, filePath);
                            }

                            InitializeDataGridView();
                        }
                        else
                        {
                            MessageBox.Show("Невідома категорія продукту.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                overlayForm.Close();
            }
        }

        private void SaveProductsToFile<T>(List<T> products, string filePath)
        {
            try
            {
                var formattedProducts = new Dictionary<string, T>();

                foreach (var product in products)
                {
                    var nameProperty = typeof(T).GetProperty("Name");
                    var name = nameProperty.GetValue(product).ToString();
                    formattedProducts.Add(name, product);
                }

                string json = Newtonsoft.Json.JsonConvert.SerializeObject(formattedProducts, Newtonsoft.Json.Formatting.Indented);
                System.IO.File.WriteAllText(filePath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при збереженні у файл {filePath}: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void navigationMainForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void navigationDeleteProduct_Click(object sender, EventArgs e)
        {
            using (Form overlayForm = new Form())
            {
                overlayForm.FormBorderStyle = FormBorderStyle.None;
                overlayForm.BackColor = Color.Black;
                overlayForm.Opacity = 0.5;
                overlayForm.Size = new Size(this.Size.Width - 15, this.Size.Height-7);

                Point productsFormLocation = this.Location;
                overlayForm.Location = new Point(productsFormLocation.X+8, productsFormLocation.Y);
                overlayForm.StartPosition = FormStartPosition.Manual;

                overlayForm.Show(this);

                using (DeleteProductForm deleteProductForm = new DeleteProductForm(GetProductNames(), GetCategories()))
                {
                    deleteProductForm.StartPosition = FormStartPosition.CenterParent;
                    deleteProductForm.ShowDialog(overlayForm);

                    if (deleteProductForm.DialogResult == DialogResult.OK)
                    {
                        string productName = deleteProductForm.ProductName;
                        string category = deleteProductForm.Category;

                        string executablePath = AppDomain.CurrentDomain.BaseDirectory;
                        string parentDirectory = Directory.GetParent(Directory.GetParent(Directory.GetParent(executablePath)?.FullName)?.FullName)?.FullName;

                        if (category == "Основні страви")
                        {
                            RemoveProduct(foodItems, productName);
                            SaveProductsToFile(foodItems, Path.Combine(parentDirectory, "foodCategories", "food.json"));
                        }
                        else if (category == "Перші страви")
                        {
                            RemoveProduct(firstDishes, productName);
                            SaveProductsToFile(firstDishes, Path.Combine(parentDirectory, "foodCategories", "firstDish.json"));
                        }
                        else if (category == "Солодкі страви")
                        {
                            RemoveProduct(sweetFoods, productName);
                            SaveProductsToFile(sweetFoods, Path.Combine(parentDirectory, "foodCategories", "sweetFood.json"));
                        }
                        else if (category == "Снеки")
                        {
                            RemoveProduct(pocketFoods, productName);
                            SaveProductsToFile(pocketFoods, Path.Combine(parentDirectory, "foodCategories", "pocketFood.json"));
                        }
                        else if (category == "Напої")
                        {
                            RemoveProduct(drinks, productName);
                            SaveProductsToFile(drinks, Path.Combine(parentDirectory, "foodCategories", "drink.json"));
                        }

                        InitializeDataGridView();
                    }
                }
                overlayForm.Close();
            }
        }

        private List<string> GetProductNames()
        {
            List<string> productNames = new List<string>();
            foreach (var foodItem in foodItems)
            {
                productNames.Add(foodItem.Name);
            }

            foreach (var firstDish in firstDishes)
            {
                productNames.Add(firstDish.Name);
            }

            foreach (var sweetFood in sweetFoods)
            {
                productNames.Add(sweetFood.Name);
            }

            foreach (var pocketFood in pocketFoods)
            {
                productNames.Add(pocketFood.Name);
            }
            foreach (var drink in drinks)
            {
                productNames.Add(drink.Name);
            }

            return productNames;
        }

        private List<string> GetCategories()
        {
            return new List<string> { "Основні страви", "Перші страви", "Солодкі страви", "Снеки", "Напої"};
        }

        private void RemoveProduct<T>(List<T> products, string productName) where T : class
        {
            var productToRemove = products.FirstOrDefault(p => p.GetType().GetProperty("Name").GetValue(p).ToString() == productName);
            if (productToRemove != null)
            {
                products.Remove(productToRemove);
            }
        }
    }
}