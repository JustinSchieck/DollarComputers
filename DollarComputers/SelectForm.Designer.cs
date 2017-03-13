namespace DollarComputers
{
    partial class SelectForm
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
            this.HardwareListBox = new System.Windows.Forms.ListBox();
            this.SelectFormLabel = new System.Windows.Forms.Label();
            this.ChoiceLabel = new System.Windows.Forms.Label();
            this.ChoiceTextBox = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HardwareListBox
            // 
            this.HardwareListBox.FormattingEnabled = true;
            this.HardwareListBox.ItemHeight = 16;
            this.HardwareListBox.Location = new System.Drawing.Point(16, 48);
            this.HardwareListBox.Name = "HardwareListBox";
            this.HardwareListBox.Size = new System.Drawing.Size(890, 388);
            this.HardwareListBox.TabIndex = 0;
            // 
            // SelectFormLabel
            // 
            this.SelectFormLabel.AutoSize = true;
            this.SelectFormLabel.Location = new System.Drawing.Point(13, 13);
            this.SelectFormLabel.Name = "SelectFormLabel";
            this.SelectFormLabel.Size = new System.Drawing.Size(201, 17);
            this.SelectFormLabel.TabIndex = 1;
            this.SelectFormLabel.Text = "Dollar Computer Hardware List";
            // 
            // ChoiceLabel
            // 
            this.ChoiceLabel.AutoSize = true;
            this.ChoiceLabel.Location = new System.Drawing.Point(16, 460);
            this.ChoiceLabel.Name = "ChoiceLabel";
            this.ChoiceLabel.Size = new System.Drawing.Size(93, 17);
            this.ChoiceLabel.TabIndex = 2;
            this.ChoiceLabel.Text = "Your Choice: ";
            // 
            // ChoiceTextBox
            // 
            this.ChoiceTextBox.Location = new System.Drawing.Point(116, 460);
            this.ChoiceTextBox.Name = "ChoiceTextBox";
            this.ChoiceTextBox.Size = new System.Drawing.Size(562, 22);
            this.ChoiceTextBox.TabIndex = 3;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(709, 451);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 40);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(819, 450);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 40);
            this.NextButton.TabIndex = 5;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            // 
            // SelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 509);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ChoiceTextBox);
            this.Controls.Add(this.ChoiceLabel);
            this.Controls.Add(this.SelectFormLabel);
            this.Controls.Add(this.HardwareListBox);
            this.Name = "SelectForm";
            this.Text = "SelectForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox HardwareListBox;
        private System.Windows.Forms.Label SelectFormLabel;
        private System.Windows.Forms.Label ChoiceLabel;
        private System.Windows.Forms.TextBox ChoiceTextBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button NextButton;
    }
}