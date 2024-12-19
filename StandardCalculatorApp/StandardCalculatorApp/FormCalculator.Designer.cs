namespace StandardCalculatorApp
{
    partial class FormCalculator
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnBackSpace = new System.Windows.Forms.Button();
            this.btnKeyPad0 = new System.Windows.Forms.Button();
            this.btnKeyPad00 = new System.Windows.Forms.Button();
            this.btnDotNotation = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnKeyPad1 = new System.Windows.Forms.Button();
            this.btnKeyPad2 = new System.Windows.Forms.Button();
            this.btnKeyPad3 = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnKeyPad4 = new System.Windows.Forms.Button();
            this.btnKeyPad5 = new System.Windows.Forms.Button();
            this.btnKeyPad6 = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnKeyPad7 = new System.Windows.Forms.Button();
            this.btnKeyPad8 = new System.Windows.Forms.Button();
            this.btnKeyPad9 = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(20, 18);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 58);
            this.panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(269, 52);
            this.textBox1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnEquals);
            this.panel2.Controls.Add(this.btnMinus);
            this.panel2.Controls.Add(this.btnBackSpace);
            this.panel2.Controls.Add(this.btnKeyPad0);
            this.panel2.Controls.Add(this.btnKeyPad00);
            this.panel2.Controls.Add(this.btnDotNotation);
            this.panel2.Controls.Add(this.btnPlus);
            this.panel2.Controls.Add(this.btnKeyPad1);
            this.panel2.Controls.Add(this.btnKeyPad2);
            this.panel2.Controls.Add(this.btnKeyPad3);
            this.panel2.Controls.Add(this.btnMultiply);
            this.panel2.Controls.Add(this.btnKeyPad4);
            this.panel2.Controls.Add(this.btnKeyPad5);
            this.panel2.Controls.Add(this.btnKeyPad6);
            this.panel2.Controls.Add(this.btnDivision);
            this.panel2.Controls.Add(this.btnKeyPad7);
            this.panel2.Controls.Add(this.btnKeyPad8);
            this.panel2.Controls.Add(this.btnKeyPad9);
            this.panel2.Controls.Add(this.btnC);
            this.panel2.Location = new System.Drawing.Point(20, 84);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(279, 263);
            this.panel2.TabIndex = 1;
            // 
            // btnEquals
            // 
            this.btnEquals.Location = new System.Drawing.Point(143, 205);
            this.btnEquals.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(50, 35);
            this.btnEquals.TabIndex = 17;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = true;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(203, 205);
            this.btnMinus.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(50, 35);
            this.btnMinus.TabIndex = 16;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnBackSpace
            // 
            this.btnBackSpace.Font = new System.Drawing.Font("Monospac821 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackSpace.Location = new System.Drawing.Point(23, 205);
            this.btnBackSpace.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnBackSpace.Name = "btnBackSpace";
            this.btnBackSpace.Size = new System.Drawing.Size(110, 35);
            this.btnBackSpace.TabIndex = 18;
            this.btnBackSpace.Text = "Back Space";
            this.btnBackSpace.UseVisualStyleBackColor = true;
            this.btnBackSpace.Click += new System.EventHandler(this.btnBackSpace_Click);
            // 
            // btnKeyPad0
            // 
            this.btnKeyPad0.Location = new System.Drawing.Point(23, 162);
            this.btnKeyPad0.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnKeyPad0.Name = "btnKeyPad0";
            this.btnKeyPad0.Size = new System.Drawing.Size(50, 35);
            this.btnKeyPad0.TabIndex = 15;
            this.btnKeyPad0.Text = "0";
            this.btnKeyPad0.UseVisualStyleBackColor = true;
            this.btnKeyPad0.Click += new System.EventHandler(this.btnKeyPad0_Click);
            // 
            // btnKeyPad00
            // 
            this.btnKeyPad00.Location = new System.Drawing.Point(83, 162);
            this.btnKeyPad00.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnKeyPad00.Name = "btnKeyPad00";
            this.btnKeyPad00.Size = new System.Drawing.Size(50, 35);
            this.btnKeyPad00.TabIndex = 14;
            this.btnKeyPad00.Text = "00";
            this.btnKeyPad00.UseVisualStyleBackColor = true;
            this.btnKeyPad00.Click += new System.EventHandler(this.btnKeyPad00_Click);
            // 
            // btnDotNotation
            // 
            this.btnDotNotation.Location = new System.Drawing.Point(143, 162);
            this.btnDotNotation.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnDotNotation.Name = "btnDotNotation";
            this.btnDotNotation.Size = new System.Drawing.Size(50, 35);
            this.btnDotNotation.TabIndex = 13;
            this.btnDotNotation.Text = ".";
            this.btnDotNotation.UseVisualStyleBackColor = true;
            this.btnDotNotation.Click += new System.EventHandler(this.btnDotNotation_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(203, 162);
            this.btnPlus.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(50, 35);
            this.btnPlus.TabIndex = 12;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnKeyPad1
            // 
            this.btnKeyPad1.Location = new System.Drawing.Point(23, 119);
            this.btnKeyPad1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnKeyPad1.Name = "btnKeyPad1";
            this.btnKeyPad1.Size = new System.Drawing.Size(50, 35);
            this.btnKeyPad1.TabIndex = 11;
            this.btnKeyPad1.Text = "1";
            this.btnKeyPad1.UseVisualStyleBackColor = true;
            this.btnKeyPad1.Click += new System.EventHandler(this.btnKeyPad1_Click);
            // 
            // btnKeyPad2
            // 
            this.btnKeyPad2.Location = new System.Drawing.Point(83, 119);
            this.btnKeyPad2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnKeyPad2.Name = "btnKeyPad2";
            this.btnKeyPad2.Size = new System.Drawing.Size(50, 35);
            this.btnKeyPad2.TabIndex = 10;
            this.btnKeyPad2.Text = "2";
            this.btnKeyPad2.UseVisualStyleBackColor = true;
            this.btnKeyPad2.Click += new System.EventHandler(this.btnKeyPad2_Click);
            // 
            // btnKeyPad3
            // 
            this.btnKeyPad3.Location = new System.Drawing.Point(143, 119);
            this.btnKeyPad3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnKeyPad3.Name = "btnKeyPad3";
            this.btnKeyPad3.Size = new System.Drawing.Size(50, 35);
            this.btnKeyPad3.TabIndex = 9;
            this.btnKeyPad3.Text = "3";
            this.btnKeyPad3.UseVisualStyleBackColor = true;
            this.btnKeyPad3.Click += new System.EventHandler(this.btnKeyPad3_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(203, 119);
            this.btnMultiply.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(50, 35);
            this.btnMultiply.TabIndex = 8;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnKeyPad4
            // 
            this.btnKeyPad4.Location = new System.Drawing.Point(23, 76);
            this.btnKeyPad4.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnKeyPad4.Name = "btnKeyPad4";
            this.btnKeyPad4.Size = new System.Drawing.Size(50, 35);
            this.btnKeyPad4.TabIndex = 7;
            this.btnKeyPad4.Text = "4";
            this.btnKeyPad4.UseVisualStyleBackColor = true;
            this.btnKeyPad4.Click += new System.EventHandler(this.btnKeyPad4_Click);
            // 
            // btnKeyPad5
            // 
            this.btnKeyPad5.Location = new System.Drawing.Point(83, 76);
            this.btnKeyPad5.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnKeyPad5.Name = "btnKeyPad5";
            this.btnKeyPad5.Size = new System.Drawing.Size(50, 35);
            this.btnKeyPad5.TabIndex = 6;
            this.btnKeyPad5.Text = "5";
            this.btnKeyPad5.UseVisualStyleBackColor = true;
            this.btnKeyPad5.Click += new System.EventHandler(this.btnKeyPad5_Click);
            // 
            // btnKeyPad6
            // 
            this.btnKeyPad6.Location = new System.Drawing.Point(143, 76);
            this.btnKeyPad6.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnKeyPad6.Name = "btnKeyPad6";
            this.btnKeyPad6.Size = new System.Drawing.Size(50, 35);
            this.btnKeyPad6.TabIndex = 5;
            this.btnKeyPad6.Text = "6";
            this.btnKeyPad6.UseVisualStyleBackColor = true;
            this.btnKeyPad6.Click += new System.EventHandler(this.btnKeyPad6_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.Location = new System.Drawing.Point(203, 76);
            this.btnDivision.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(50, 35);
            this.btnDivision.TabIndex = 4;
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // btnKeyPad7
            // 
            this.btnKeyPad7.Location = new System.Drawing.Point(23, 33);
            this.btnKeyPad7.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnKeyPad7.Name = "btnKeyPad7";
            this.btnKeyPad7.Size = new System.Drawing.Size(50, 35);
            this.btnKeyPad7.TabIndex = 3;
            this.btnKeyPad7.Text = "7";
            this.btnKeyPad7.UseVisualStyleBackColor = true;
            this.btnKeyPad7.Click += new System.EventHandler(this.btnKeyPad7_Click);
            // 
            // btnKeyPad8
            // 
            this.btnKeyPad8.Location = new System.Drawing.Point(83, 33);
            this.btnKeyPad8.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnKeyPad8.Name = "btnKeyPad8";
            this.btnKeyPad8.Size = new System.Drawing.Size(50, 35);
            this.btnKeyPad8.TabIndex = 2;
            this.btnKeyPad8.Text = "8";
            this.btnKeyPad8.UseVisualStyleBackColor = true;
            this.btnKeyPad8.Click += new System.EventHandler(this.btnKeyPad8_Click);
            // 
            // btnKeyPad9
            // 
            this.btnKeyPad9.Location = new System.Drawing.Point(143, 33);
            this.btnKeyPad9.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnKeyPad9.Name = "btnKeyPad9";
            this.btnKeyPad9.Size = new System.Drawing.Size(50, 35);
            this.btnKeyPad9.TabIndex = 1;
            this.btnKeyPad9.Text = "9";
            this.btnKeyPad9.UseVisualStyleBackColor = true;
            this.btnKeyPad9.Click += new System.EventHandler(this.btnKeyPad9_Click);
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(203, 33);
            this.btnC.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(50, 35);
            this.btnC.TabIndex = 0;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // FormCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 363);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Monospac821 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FormCalculator";
            this.Text = "BasicCalculator";
            this.Load += new System.EventHandler(this.FormCalculator_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnKeyPad0;
        private System.Windows.Forms.Button btnKeyPad00;
        private System.Windows.Forms.Button btnDotNotation;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnKeyPad1;
        private System.Windows.Forms.Button btnKeyPad2;
        private System.Windows.Forms.Button btnKeyPad3;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnKeyPad4;
        private System.Windows.Forms.Button btnKeyPad5;
        private System.Windows.Forms.Button btnKeyPad6;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnKeyPad7;
        private System.Windows.Forms.Button btnKeyPad8;
        private System.Windows.Forms.Button btnKeyPad9;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnBackSpace;
    }
}