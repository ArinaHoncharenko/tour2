using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NutritionCalculator
{
    public partial class AddProductForm : Form
    {
        public string ProductName { get; private set; }
        public double Calories { get; private set; }
        public double Weight { get; private set; }
        public double Water { get; private set; }
        public string Taste { get; private set; }
        public string Category { get; private set; }

        public AddProductForm()
        {
            InitializeComponent();

            categoryComboBox.Items.Add("Основні страви");
            categoryComboBox.Items.Add("Перші страви");
            categoryComboBox.Items.Add("Солодкі страви");
            categoryComboBox.Items.Add("Снеки");
            categoryComboBox.Items.Add("Напої");

            categoryComboBox.SelectedIndex = 0;
        }

        private void addButton_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTextBox.Text) ||
                string.IsNullOrWhiteSpace(caloriesTextBox.Text) ||
                string.IsNullOrWhiteSpace(weightTextBox.Text) ||
                string.IsNullOrWhiteSpace(waterTextBox.Text) ||
                string.IsNullOrWhiteSpace(tasteTextBox.Text) ||
                categoryComboBox.SelectedItem == null)
            {
                MessageBox.Show("Будь ласка, заповніть всі поля.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ProductName = nameTextBox.Text;

            double calories, weight, water;

            if (!double.TryParse(caloriesTextBox.Text, out calories) ||
                !double.TryParse(weightTextBox.Text, out weight) ||
                !double.TryParse(waterTextBox.Text, out water))
            {
                MessageBox.Show("Будь ласка, введіть коректні числові значення.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Calories = calories;
            Weight = weight;
            Water = water;

            Taste = tasteTextBox.Text;
            Category = categoryComboBox.SelectedItem.ToString();

            DialogResult = DialogResult.OK;
            Close();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}