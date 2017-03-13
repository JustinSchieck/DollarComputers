namespace DollarComputers
{
    partial class StartForm
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
            this.CoinPictureBox = new System.Windows.Forms.PictureBox();
            this.NewOrderButton = new System.Windows.Forms.Button();
            this.SavedOrderButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CoinPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CoinPictureBox
            // 
            this.CoinPictureBox.Location = new System.Drawing.Point(55, 38);
            this.CoinPictureBox.Name = "CoinPictureBox";
            this.CoinPictureBox.Size = new System.Drawing.Size(294, 261);
            this.CoinPictureBox.TabIndex = 0;
            this.CoinPictureBox.TabStop = false;
            // 
            // NewOrderButton
            // 
            this.NewOrderButton.Location = new System.Drawing.Point(55, 327);
            this.NewOrderButton.Name = "NewOrderButton";
            this.NewOrderButton.Size = new System.Drawing.Size(294, 37);
            this.NewOrderButton.TabIndex = 1;
            this.NewOrderButton.Text = "Start New Order";
            this.NewOrderButton.UseVisualStyleBackColor = true;
            // 
            // SavedOrderButton
            // 
            this.SavedOrderButton.Location = new System.Drawing.Point(55, 374);
            this.SavedOrderButton.Name = "SavedOrderButton";
            this.SavedOrderButton.Size = new System.Drawing.Size(294, 37);
            this.SavedOrderButton.TabIndex = 2;
            this.SavedOrderButton.Text = "Open Saved Order";
            this.SavedOrderButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(55, 419);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(294, 37);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 472);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SavedOrderButton);
            this.Controls.Add(this.NewOrderButton);
            this.Controls.Add(this.CoinPictureBox);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            ((System.ComponentModel.ISupportInitialize)(this.CoinPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox CoinPictureBox;
        private System.Windows.Forms.Button NewOrderButton;
        private System.Windows.Forms.Button SavedOrderButton;
        private System.Windows.Forms.Button CancelButton;
    }
}