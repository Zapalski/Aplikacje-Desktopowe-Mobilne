
namespace SimpleCalculator
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelFirstNumber = new System.Windows.Forms.Label();
            this.labelSecondNumber = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFirstNumber = new System.Windows.Forms.TextBox();
            this.TextBoxSecondNumber = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.SubstractButton = new System.Windows.Forms.Button();
            this.MulButton = new System.Windows.Forms.Button();
            this.DivButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelFirstNumber
            // 
            this.labelFirstNumber.AutoSize = true;
            this.labelFirstNumber.Location = new System.Drawing.Point(123, 45);
            this.labelFirstNumber.Name = "labelFirstNumber";
            this.labelFirstNumber.Size = new System.Drawing.Size(91, 15);
            this.labelFirstNumber.TabIndex = 0;
            this.labelFirstNumber.Text = "Pierwsza Liczba:";
            this.labelFirstNumber.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelSecondNumber
            // 
            this.labelSecondNumber.AutoSize = true;
            this.labelSecondNumber.Location = new System.Drawing.Point(257, 45);
            this.labelSecondNumber.Name = "labelSecondNumber";
            this.labelSecondNumber.Size = new System.Drawing.Size(78, 15);
            this.labelSecondNumber.TabIndex = 1;
            this.labelSecondNumber.Text = "Druga Liczba:";
            this.labelSecondNumber.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 2;
            // 
            // textBoxFirstNumber
            // 
            this.textBoxFirstNumber.Location = new System.Drawing.Point(123, 63);
            this.textBoxFirstNumber.Name = "textBoxFirstNumber";
            this.textBoxFirstNumber.Size = new System.Drawing.Size(100, 23);
            this.textBoxFirstNumber.TabIndex = 3;
            // 
            // TextBoxSecondNumber
            // 
            this.TextBoxSecondNumber.Location = new System.Drawing.Point(257, 63);
            this.TextBoxSecondNumber.Name = "TextBoxSecondNumber";
            this.TextBoxSecondNumber.Size = new System.Drawing.Size(100, 23);
            this.TextBoxSecondNumber.TabIndex = 4;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(79, 108);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "+";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SubstractButton
            // 
            this.SubstractButton.Location = new System.Drawing.Point(161, 108);
            this.SubstractButton.Name = "SubstractButton";
            this.SubstractButton.Size = new System.Drawing.Size(75, 23);
            this.SubstractButton.TabIndex = 6;
            this.SubstractButton.Text = "-";
            this.SubstractButton.UseVisualStyleBackColor = true;
            // 
            // MulButton
            // 
            this.MulButton.Location = new System.Drawing.Point(242, 108);
            this.MulButton.Name = "MulButton";
            this.MulButton.Size = new System.Drawing.Size(75, 23);
            this.MulButton.TabIndex = 7;
            this.MulButton.Text = "*";
            this.MulButton.UseVisualStyleBackColor = true;
            // 
            // DivButton
            // 
            this.DivButton.Location = new System.Drawing.Point(323, 108);
            this.DivButton.Name = "DivButton";
            this.DivButton.Size = new System.Drawing.Size(75, 23);
            this.DivButton.TabIndex = 8;
            this.DivButton.Text = "/";
            this.DivButton.UseVisualStyleBackColor = true;
            this.DivButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 475);
            this.Controls.Add(this.DivButton);
            this.Controls.Add(this.MulButton);
            this.Controls.Add(this.SubstractButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.TextBoxSecondNumber);
            this.Controls.Add(this.textBoxFirstNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelSecondNumber);
            this.Controls.Add(this.labelFirstNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Prosty Kalkulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFirstNumber;
        private System.Windows.Forms.Label labelSecondNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxFirstNumber;
        private System.Windows.Forms.TextBox TextBoxSecondNumber;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button SubstractButton;
        private System.Windows.Forms.Button MulButton;
        private System.Windows.Forms.Button DivButton;
    }
}

