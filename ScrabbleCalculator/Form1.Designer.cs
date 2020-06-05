namespace ScrabbleCalculator
{
    partial class CalculatorForm
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
            this.CalculateButton = new System.Windows.Forms.Button();
            this.EnterTextLabel = new System.Windows.Forms.Label();
            this.WordValueLabel = new System.Windows.Forms.Label();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CalculateButton
            // 
            this.CalculateButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateButton.Location = new System.Drawing.Point(211, 153);
            this.CalculateButton.Margin = new System.Windows.Forms.Padding(2);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(113, 28);
            this.CalculateButton.TabIndex = 2;
            this.CalculateButton.Text = "Calculate Value";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // EnterTextLabel
            // 
            this.EnterTextLabel.Location = new System.Drawing.Point(0, 0);
            this.EnterTextLabel.Name = "EnterTextLabel";
            this.EnterTextLabel.Size = new System.Drawing.Size(100, 23);
            this.EnterTextLabel.TabIndex = 8;
            // 
            // WordValueLabel
            // 
            this.WordValueLabel.Location = new System.Drawing.Point(0, 0);
            this.WordValueLabel.Name = "WordValueLabel";
            this.WordValueLabel.Size = new System.Drawing.Size(100, 23);
            this.WordValueLabel.TabIndex = 7;
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(211, 228);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.Size = new System.Drawing.Size(113, 20);
            this.outputTextBox.TabIndex = 5;
            this.outputTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // InputTextBox
            // 
            this.InputTextBox.Location = new System.Drawing.Point(147, 114);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(235, 20);
            this.InputTextBox.TabIndex = 6;
            this.InputTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.InputTextBox.TextChanged += new System.EventHandler(this.InputTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(344, 30);
            this.label2.TabIndex = 9;
            this.label2.Text = "Welcome to the Scrabble Calculator";
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InputTextBox);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.WordValueLabel);
            this.Controls.Add(this.EnterTextLabel);
            this.Controls.Add(this.CalculateButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScrabbleCalculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label EnterTextLabel;
        private System.Windows.Forms.Label WordValueLabel;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

