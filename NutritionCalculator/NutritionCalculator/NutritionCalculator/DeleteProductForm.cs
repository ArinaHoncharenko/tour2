using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using Newtonsoft.Json.Linq;


namespace NutritionCalculator
{
    public partial class DeleteProductForm : Form
    {
        public string ProductName { get; private set; }
        public string Category { get; private set; }
        public DeleteProductForm(List<string> productNames, List<string> categories)
        {
            InitializeComponent();
            productNameComboBox.Items.Clear();
            categoryComboBox.Items.AddRange(categories.ToArray());
            categoryComboBox.SelectedIndexChanged += categoryComboBox_SelectedIndexChanged;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (productNameComboBox.SelectedItem == null || categoryComboBox.SelectedItem == null)
            {
                MessageBox.Show("Будь ласка, оберіть назву продукту та категорію.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ProductName = productNameComboBox.SelectedItem.ToString();
            Category = categoryComboBox.SelectedItem.ToString();

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = categoryComboBox.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(selectedCategory))
            {
                LoadProductsByCategory(selectedCategory);
            }
        }

        private void LoadProductsByCategory(string category)
        {
            string fileName = "";
            switch (category)
            {
                case "Основні страви":
                    fileName = "food.json";
                    break;
                case "Перші страви":
                    fileName = "firstDish.json";
                    break;
                case "Солодкі страви":
                    fileName = "sweetFood.json";
                    break;
                case "Снеки":
                    fileName = "pocketFood.json";
                    break;
                case "Напої":
                    fileName = "drink.json";
                    break;
            }
            string executablePath = AppDomain.CurrentDomain.BaseDirectory;
            string parentDirectory = Directory.GetParent(Directory.GetParent(Directory.GetParent(executablePath)?.FullName)?.FullName)?.FullName;

            string filePath = Path.Combine(parentDirectory, "foodCategories", fileName);


            if (File.Exists(filePath))
            {
                try
                {
                    string json = File.ReadAllText(filePath);
                    JObject productsObject = JObject.Parse(json);

                    productNameComboBox.Items.Clear();
                    foreach (var product in productsObject)
                    {
                        string productName = product.Key;
                        productNameComboBox.Items.Add(productName);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка при зчитуванні файлу: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show($"Файл з продуктами для категорії '{category}' не знайдено.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}