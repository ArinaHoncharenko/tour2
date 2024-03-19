namespace NutritionCalculator
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.calculateRationButton = new System.Windows.Forms.Button();
            this.resultDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.durationNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.complexityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.navigationSaveRation = new System.Windows.Forms.Label();
            this.navigationbtnProductsMenu = new System.Windows.Forms.Label();
            this.navigationMainForm = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDetails = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.durationNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.complexityNumericUpDown)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // calculateRationButton
            // 
            this.calculateRationButton.AutoSize = true;
            this.calculateRationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(234)))), ((int)(((byte)(176)))));
            this.calculateRationButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calculateRationButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.calculateRationButton.Location = new System.Drawing.Point(485, 169);
            this.calculateRationButton.Margin = new System.Windows.Forms.Padding(4);
            this.calculateRationButton.Name = "calculateRationButton";
            this.calculateRationButton.Padding = new System.Windows.Forms.Padding(4);
            this.calculateRationButton.Size = new System.Drawing.Size(143, 48);
            this.calculateRationButton.TabIndex = 2;
            this.calculateRationButton.Text = "Генерувати";
            this.calculateRationButton.UseVisualStyleBackColor = false;
            this.calculateRationButton.Click += new System.EventHandler(this.calculateRationButton_Click);
            // 
            // resultDataGridView
            // 
            this.resultDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.resultDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(251)))), ((int)(((byte)(244)))));
            this.resultDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.resultDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.resultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.resultDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.resultDataGridView.Location = new System.Drawing.Point(17, 280);
            this.resultDataGridView.Margin = new System.Windows.Forms.Padding(8);
            this.resultDataGridView.Name = "resultDataGridView";
            this.resultDataGridView.RowHeadersWidth = 4;
            this.resultDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultDataGridView.ShowCellErrors = false;
            this.resultDataGridView.ShowRowErrors = false;
            this.resultDataGridView.Size = new System.Drawing.Size(1388, 420);
            this.resultDataGridView.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(32, 158);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Категорійність:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(32, 212);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Тривалість, дні:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(32, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(596, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Для розрахунку раціону харчування введіть дані про похід:";
            // 
            // durationNumericUpDown
            // 
            this.durationNumericUpDown.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.durationNumericUpDown.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.durationNumericUpDown.Location = new System.Drawing.Point(242, 209);
            this.durationNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.durationNumericUpDown.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.durationNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.durationNumericUpDown.Name = "durationNumericUpDown";
            this.durationNumericUpDown.Size = new System.Drawing.Size(107, 32);
            this.durationNumericUpDown.TabIndex = 7;
            this.durationNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // complexityNumericUpDown
            // 
            this.complexityNumericUpDown.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.complexityNumericUpDown.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.complexityNumericUpDown.Location = new System.Drawing.Point(242, 152);
            this.complexityNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.complexityNumericUpDown.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.complexityNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.complexityNumericUpDown.Name = "complexityNumericUpDown";
            this.complexityNumericUpDown.Size = new System.Drawing.Size(107, 32);
            this.complexityNumericUpDown.TabIndex = 8;
            this.complexityNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // navigationSaveRation
            // 
            this.navigationSaveRation.AutoSize = true;
            this.navigationSaveRation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.navigationSaveRation.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.navigationSaveRation.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.navigationSaveRation.Location = new System.Drawing.Point(384, 20);
            this.navigationSaveRation.Margin = new System.Windows.Forms.Padding(4, 0, 36, 0);
            this.navigationSaveRation.Name = "navigationSaveRation";
            this.navigationSaveRation.Size = new System.Drawing.Size(177, 23);
            this.navigationSaveRation.TabIndex = 11;
            this.navigationSaveRation.Text = "Зберегти раціон";
            this.navigationSaveRation.Click += new System.EventHandler(this.navigationSaveRation_Click);
            // 
            // navigationbtnProductsMenu
            // 
            this.navigationbtnProductsMenu.AutoSize = true;
            this.navigationbtnProductsMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.navigationbtnProductsMenu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.navigationbtnProductsMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.navigationbtnProductsMenu.Location = new System.Drawing.Point(789, 20);
            this.navigationbtnProductsMenu.Margin = new System.Windows.Forms.Padding(36, 0, 4, 0);
            this.navigationbtnProductsMenu.Name = "navigationbtnProductsMenu";
            this.navigationbtnProductsMenu.Size = new System.Drawing.Size(249, 23);
            this.navigationbtnProductsMenu.TabIndex = 12;
            this.navigationbtnProductsMenu.Text = "Передивитися продукти";
            this.navigationbtnProductsMenu.Click += new System.EventHandler(this.navigationbtnProductsMenu_Click);
            // 
            // navigationMainForm
            // 
            this.navigationMainForm.AutoSize = true;
            this.navigationMainForm.Cursor = System.Windows.Forms.Cursors.Default;
            this.navigationMainForm.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.navigationMainForm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.navigationMainForm.Location = new System.Drawing.Point(629, 20);
            this.navigationMainForm.Margin = new System.Windows.Forms.Padding(32, 0, 32, 0);
            this.navigationMainForm.Name = "navigationMainForm";
            this.navigationMainForm.Size = new System.Drawing.Size(92, 23);
            this.navigationMainForm.TabIndex = 13;
            this.navigationMainForm.Text = "Головна";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(32)))), ((int)(((byte)(19)))));
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.navigationSaveRation);
            this.flowLayoutPanel1.Controls.Add(this.navigationMainForm);
            this.flowLayoutPanel1.Controls.Add(this.navigationbtnProductsMenu);
            this.flowLayoutPanel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(380, 20, 380, 16);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1424, 61);
            this.flowLayoutPanel1.TabIndex = 14;
            // 
            // btnDetails
            // 
            this.btnDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetails.Image = global::NutritionCalculator.Properties.Resources.question;
            this.btnDetails.Location = new System.Drawing.Point(369, 154);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(30, 30);
            this.btnDetails.TabIndex = 52;
            this.btnDetails.TabStop = false;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(251)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(1422, 720);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.complexityNumericUpDown);
            this.Controls.Add(this.durationNumericUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultDataGridView);
            this.Controls.Add(this.calculateRationButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Tourgy - Головна";
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.durationNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.complexityNumericUpDown)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label navigationSaveRation;
        private System.Windows.Forms.Label navigationbtnProductsMenu;
        private System.Windows.Forms.Label navigationMainForm;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button calculateRationButton;
        private System.Windows.Forms.DataGridView resultDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown durationNumericUpDown;
        private System.Windows.Forms.NumericUpDown complexityNumericUpDown;
        private System.Windows.Forms.PictureBox btnDetails;
    }
}

