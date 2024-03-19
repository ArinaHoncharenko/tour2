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
    public partial class ComplexityLevelForm : Form
    {
        public int SelectedComplexityCategory { get; private set; }
        public int DurationDays { get; private set; }
        public ComplexityLevelForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculateComplaxity_Click(object sender, EventArgs e)
        {
            int durationDays = (int)durationDays_NumericUpDown.Value;
            int lengthKm = (int)lengthKm_NumericUpDown.Value;

            SelectedComplexityCategory = CalculateComplexityCategory(durationDays, lengthKm);
            DurationDays = durationDays;
            DialogResult = DialogResult.OK;
            this.Close();
        }

        public int CalculateComplexityCategory(int durationDays, int lengthKm)
        {
            string complexityCategory = string.Empty;
            int selectedComplexityCategory;

            if (durationDays >= 13 && lengthKm >= 220)
            {
                MessageBox.Show("Додаток здійснює розрахунок тільки для 1, 2, 3 категорії та некатегорійних походів.", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                selectedComplexityCategory = 3;
            }
            else if (durationDays >= 10 && lengthKm >= 190)
            {
                complexityCategory = "3";
                selectedComplexityCategory = 3;
            }
            else if (durationDays >= 8 && lengthKm >= 160)
            {
                complexityCategory = "2";
                selectedComplexityCategory = 2;
            }
            else if (durationDays >= 6 && lengthKm >= 130)
            {
                complexityCategory = "1";
                selectedComplexityCategory = 1;
            }
            else
            {
                complexityCategory = "Некатегорійний";
                selectedComplexityCategory = 1;
            }

            if (!string.IsNullOrEmpty(complexityCategory))
            {
                MessageBox.Show($"Категорія складності походу: {complexityCategory}", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return selectedComplexityCategory;
        }

    }
}
