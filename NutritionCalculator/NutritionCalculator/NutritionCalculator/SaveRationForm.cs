using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

namespace NutritionCalculator
{
    public partial class SaveRationForm : Form
    {
        private string rationText;
        public SaveRationForm(string rationText)
        {
            InitializeComponent();
            cmbFileFormat.Items.Add("txt");
            cmbFileFormat.Items.Add("docx");
            this.rationText = rationText;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFileName.Text))
            {
                MessageBox.Show("Будь ласка, введіть назву файлу.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string fileName = txtFileName.Text;
            string fileFormat = cmbFileFormat.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(fileFormat))
            {
                MessageBox.Show("Будь ласка, оберіть формат файлу.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           

            string desktopPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"{fileName}.{fileFormat}");

            if (File.Exists(desktopPath))
            {
                MessageBox.Show("Файл з таким ім'ям вже існує. Будь ласка, оберіть інше ім'я.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SaveRationToFile(desktopPath, fileFormat);

            MessageBox.Show($"Раціон збережено на робочому столі", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void SaveRationToFile(string filePath, string fileFormat)
        {
            try
            {
                if (fileFormat.ToLower() == "txt")
                {
                    File.WriteAllText(filePath, rationText);
                }
                else if (fileFormat.ToLower() == "docx")
                {
                    using (WordprocessingDocument wordDocument = WordprocessingDocument.Create(filePath, WordprocessingDocumentType.Document))
                    {
                        MainDocumentPart mainPart = wordDocument.AddMainDocumentPart();
                        mainPart.Document = new Document();
                        Body body = mainPart.Document.AppendChild(new Body());

                        string[] lines = rationText.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);

                        foreach (string line in lines)
                        {
                            Paragraph para = body.AppendChild(new Paragraph());
                            Run run = para.AppendChild(new Run());
                            run.AppendChild(new Text(line));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при збереженні раціону: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}