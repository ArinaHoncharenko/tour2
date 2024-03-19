namespace NutritionCalculator
{
    partial class ProductsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsForm));
            this.productsDataGridView = new System.Windows.Forms.DataGridView();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.navigationDeleteProduct = new System.Windows.Forms.Label();
            this.navigationMainForm = new System.Windows.Forms.Label();
            this.navigationAddProduct = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // productsDataGridView
            // 
            this.productsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productsDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(251)))), ((int)(((byte)(244)))));
            this.productsDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.productsDataGridView.ColumnHeadersHeight = 29;
            this.productsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.productsDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.productsDataGridView.Location = new System.Drawing.Point(17, 91);
            this.productsDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.productsDataGridView.Name = "productsDataGridView";
            this.productsDataGridView.RowHeadersWidth = 4;
            this.productsDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.productsDataGridView.ShowCellErrors = false;
            this.productsDataGridView.ShowRowErrors = false;
            this.productsDataGridView.Size = new System.Drawing.Size(1388, 612);
            this.productsDataGridView.TabIndex = 4;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(0, 0);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(75, 23);
            this.btnAddProduct.TabIndex = 16;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(32)))), ((int)(((byte)(19)))));
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.navigationDeleteProduct);
            this.flowLayoutPanel1.Controls.Add(this.navigationMainForm);
            this.flowLayoutPanel1.Controls.Add(this.navigationAddProduct);
            this.flowLayoutPanel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(415, 20, 415, 16);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1426, 61);
            this.flowLayoutPanel1.TabIndex = 15;
            // 
            // navigationDeleteProduct
            // 
            this.navigationDeleteProduct.AutoSize = true;
            this.navigationDeleteProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.navigationDeleteProduct.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.navigationDeleteProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(136)))));
            this.navigationDeleteProduct.Location = new System.Drawing.Point(419, 20);
            this.navigationDeleteProduct.Margin = new System.Windows.Forms.Padding(4, 0, 36, 0);
            this.navigationDeleteProduct.Name = "navigationDeleteProduct";
            this.navigationDeleteProduct.Size = new System.Drawing.Size(188, 23);
            this.navigationDeleteProduct.TabIndex = 11;
            this.navigationDeleteProduct.Text = "Видалити продукт";
            this.navigationDeleteProduct.Click += new System.EventHandler(this.navigationDeleteProduct_Click);
            // 
            // navigationMainForm
            // 
            this.navigationMainForm.AutoSize = true;
            this.navigationMainForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.navigationMainForm.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.navigationMainForm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.navigationMainForm.Location = new System.Drawing.Point(675, 20);
            this.navigationMainForm.Margin = new System.Windows.Forms.Padding(32, 0, 32, 0);
            this.navigationMainForm.Name = "navigationMainForm";
            this.navigationMainForm.Size = new System.Drawing.Size(92, 23);
            this.navigationMainForm.TabIndex = 13;
            this.navigationMainForm.Text = "Головна";
            this.navigationMainForm.Click += new System.EventHandler(this.navigationMainForm_Click);
            // 
            // navigationAddProduct
            // 
            this.navigationAddProduct.AutoSize = true;
            this.navigationAddProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.navigationAddProduct.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.navigationAddProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(255)))), ((int)(((byte)(166)))));
            this.navigationAddProduct.Location = new System.Drawing.Point(835, 20);
            this.navigationAddProduct.Margin = new System.Windows.Forms.Padding(36, 0, 4, 0);
            this.navigationAddProduct.Name = "navigationAddProduct";
            this.navigationAddProduct.Size = new System.Drawing.Size(170, 23);
            this.navigationAddProduct.TabIndex = 12;
            this.navigationAddProduct.Text = "Додати продукт";
            this.navigationAddProduct.Click += new System.EventHandler(this.navigationAddProduct_Click);
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(251)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(1422, 720);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.productsDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ProductsForm";
            this.Text = "Tourgy - Список продуктів";
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView productsDataGridView;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label navigationDeleteProduct;
        private System.Windows.Forms.Label navigationMainForm;
        private System.Windows.Forms.Label navigationAddProduct;
    }
}