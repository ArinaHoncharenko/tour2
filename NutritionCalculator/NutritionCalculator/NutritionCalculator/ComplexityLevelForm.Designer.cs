namespace NutritionCalculator
{
    partial class ComplexityLevelForm
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
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalculateComplaxity = new System.Windows.Forms.Button();
            this.durationDays_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.lengthKm_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.durationDays_NumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lengthKm_NumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = global::NutritionCalculator.Properties.Resources.close;
            this.btnClose.Location = new System.Drawing.Point(666, 24);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 58;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(26, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 23);
            this.label2.TabIndex = 57;
            this.label2.Text = "Тривалість, дні:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(26, 59);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(499, 23);
            this.label7.TabIndex = 54;
            this.label7.Text = "Щоб розрахувати складність походу введіть дані:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(26, 196);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 23);
            this.label1.TabIndex = 53;
            this.label1.Text = "Протяжність, км:";
            // 
            // btnCalculateComplaxity
            // 
            this.btnCalculateComplaxity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(234)))), ((int)(((byte)(176)))));
            this.btnCalculateComplaxity.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCalculateComplaxity.Location = new System.Drawing.Point(260, 279);
            this.btnCalculateComplaxity.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalculateComplaxity.Name = "btnCalculateComplaxity";
            this.btnCalculateComplaxity.Size = new System.Drawing.Size(200, 50);
            this.btnCalculateComplaxity.TabIndex = 52;
            this.btnCalculateComplaxity.Text = "Розрахувати";
            this.btnCalculateComplaxity.UseVisualStyleBackColor = false;
            this.btnCalculateComplaxity.Click += new System.EventHandler(this.btnCalculateComplaxity_Click);
            // 
            // durationDays_NumericUpDown
            // 
            this.durationDays_NumericUpDown.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.durationDays_NumericUpDown.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.durationDays_NumericUpDown.Location = new System.Drawing.Point(234, 124);
            this.durationDays_NumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.durationDays_NumericUpDown.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.durationDays_NumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.durationDays_NumericUpDown.Name = "durationDays_NumericUpDown";
            this.durationDays_NumericUpDown.Size = new System.Drawing.Size(107, 32);
            this.durationDays_NumericUpDown.TabIndex = 60;
            this.durationDays_NumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lengthKm_NumericUpDown
            // 
            this.lengthKm_NumericUpDown.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lengthKm_NumericUpDown.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lengthKm_NumericUpDown.Location = new System.Drawing.Point(234, 191);
            this.lengthKm_NumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.lengthKm_NumericUpDown.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.lengthKm_NumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.lengthKm_NumericUpDown.Name = "lengthKm_NumericUpDown";
            this.lengthKm_NumericUpDown.Size = new System.Drawing.Size(107, 32);
            this.lengthKm_NumericUpDown.TabIndex = 59;
            this.lengthKm_NumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ComplexityLevelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(251)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(720, 383);
            this.ControlBox = false;
            this.Controls.Add(this.durationDays_NumericUpDown);
            this.Controls.Add(this.lengthKm_NumericUpDown);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalculateComplaxity);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ComplexityLevelForm";
            this.Text = "ComplexityLevel";
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.durationDays_NumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lengthKm_NumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalculateComplaxity;
        private System.Windows.Forms.NumericUpDown durationDays_NumericUpDown;
        private System.Windows.Forms.NumericUpDown lengthKm_NumericUpDown;
    }
}