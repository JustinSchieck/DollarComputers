namespace DollarComputers
{
    partial class OrderForm
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
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SystemGroupBox = new System.Windows.Forms.GroupBox();
            this.SystemGroupBox2 = new System.Windows.Forms.GroupBox();
            this.PriceGroupBox = new System.Windows.Forms.GroupBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.FinishButton = new System.Windows.Forms.Button();
            this.ConditionTextbox = new System.Windows.Forms.TextBox();
            this.ManufacturerTextbox = new System.Windows.Forms.TextBox();
            this.PlatformTextbox = new System.Windows.Forms.TextBox();
            this.ModelTextbox = new System.Windows.Forms.TextBox();
            this.ConditionLabel = new System.Windows.Forms.Label();
            this.ManufacturerLabel = new System.Windows.Forms.Label();
            this.PlatformLabel = new System.Windows.Forms.Label();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.DisplayListBox = new System.Windows.Forms.ListBox();
            this.LCDSizeLabel = new System.Windows.Forms.Label();
            this.MemoryLabel = new System.Windows.Forms.Label();
            this.CPUBrandLabel = new System.Windows.Forms.Label();
            this.CPUTypeLabel = new System.Windows.Forms.Label();
            this.CPUNumberLabel = new System.Windows.Forms.Label();
            this.CPUSpeedLabel = new System.Windows.Forms.Label();
            this.HDDLabel = new System.Windows.Forms.Label();
            this.GPUTypeLabel = new System.Windows.Forms.Label();
            this.WebcamLabel = new System.Windows.Forms.Label();
            this.OSLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.SalesLabel = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.PriceTextbox = new System.Windows.Forms.TextBox();
            this.SalesTaxTextbox = new System.Windows.Forms.TextBox();
            this.TotalTextbox = new System.Windows.Forms.TextBox();
            this.MenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SystemGroupBox.SuspendLayout();
            this.SystemGroupBox2.SuspendLayout();
            this.PriceGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(1149, 28);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(653, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 196);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.backToolStripMenuItem.Text = "&Back";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.printToolStripMenuItem.Text = "&Print";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // SystemGroupBox
            // 
            this.SystemGroupBox.Controls.Add(this.ModelLabel);
            this.SystemGroupBox.Controls.Add(this.PlatformLabel);
            this.SystemGroupBox.Controls.Add(this.ManufacturerLabel);
            this.SystemGroupBox.Controls.Add(this.ConditionLabel);
            this.SystemGroupBox.Controls.Add(this.ModelTextbox);
            this.SystemGroupBox.Controls.Add(this.PlatformTextbox);
            this.SystemGroupBox.Controls.Add(this.ManufacturerTextbox);
            this.SystemGroupBox.Controls.Add(this.ConditionTextbox);
            this.SystemGroupBox.Location = new System.Drawing.Point(13, 48);
            this.SystemGroupBox.Name = "SystemGroupBox";
            this.SystemGroupBox.Size = new System.Drawing.Size(622, 137);
            this.SystemGroupBox.TabIndex = 2;
            this.SystemGroupBox.TabStop = false;
            this.SystemGroupBox.Text = "System Components";
            // 
            // SystemGroupBox2
            // 
            this.SystemGroupBox2.Controls.Add(this.OSLabel);
            this.SystemGroupBox2.Controls.Add(this.WebcamLabel);
            this.SystemGroupBox2.Controls.Add(this.GPUTypeLabel);
            this.SystemGroupBox2.Controls.Add(this.HDDLabel);
            this.SystemGroupBox2.Controls.Add(this.CPUSpeedLabel);
            this.SystemGroupBox2.Controls.Add(this.CPUNumberLabel);
            this.SystemGroupBox2.Controls.Add(this.CPUTypeLabel);
            this.SystemGroupBox2.Controls.Add(this.CPUBrandLabel);
            this.SystemGroupBox2.Controls.Add(this.MemoryLabel);
            this.SystemGroupBox2.Controls.Add(this.LCDSizeLabel);
            this.SystemGroupBox2.Controls.Add(this.DisplayListBox);
            this.SystemGroupBox2.Location = new System.Drawing.Point(13, 181);
            this.SystemGroupBox2.Name = "SystemGroupBox2";
            this.SystemGroupBox2.Size = new System.Drawing.Size(622, 377);
            this.SystemGroupBox2.TabIndex = 3;
            this.SystemGroupBox2.TabStop = false;
            // 
            // PriceGroupBox
            // 
            this.PriceGroupBox.Controls.Add(this.TotalTextbox);
            this.PriceGroupBox.Controls.Add(this.SalesTaxTextbox);
            this.PriceGroupBox.Controls.Add(this.PriceTextbox);
            this.PriceGroupBox.Controls.Add(this.TotalLabel);
            this.PriceGroupBox.Controls.Add(this.SalesLabel);
            this.PriceGroupBox.Controls.Add(this.PriceLabel);
            this.PriceGroupBox.Location = new System.Drawing.Point(653, 275);
            this.PriceGroupBox.Name = "PriceGroupBox";
            this.PriceGroupBox.Size = new System.Drawing.Size(484, 191);
            this.PriceGroupBox.TabIndex = 4;
            this.PriceGroupBox.TabStop = false;
            this.PriceGroupBox.Text = "Your Price";
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(682, 517);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(90, 41);
            this.BackButton.TabIndex = 5;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(844, 517);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(90, 41);
            this.CancelButton.TabIndex = 6;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // FinishButton
            // 
            this.FinishButton.Location = new System.Drawing.Point(1013, 517);
            this.FinishButton.Name = "FinishButton";
            this.FinishButton.Size = new System.Drawing.Size(90, 41);
            this.FinishButton.TabIndex = 7;
            this.FinishButton.Text = "Finish";
            this.FinishButton.UseVisualStyleBackColor = true;
            // 
            // ConditionTextbox
            // 
            this.ConditionTextbox.Location = new System.Drawing.Point(114, 34);
            this.ConditionTextbox.Name = "ConditionTextbox";
            this.ConditionTextbox.Size = new System.Drawing.Size(146, 22);
            this.ConditionTextbox.TabIndex = 0;
            // 
            // ManufacturerTextbox
            // 
            this.ManufacturerTextbox.Location = new System.Drawing.Point(114, 85);
            this.ManufacturerTextbox.Name = "ManufacturerTextbox";
            this.ManufacturerTextbox.Size = new System.Drawing.Size(146, 22);
            this.ManufacturerTextbox.TabIndex = 1;
            // 
            // PlatformTextbox
            // 
            this.PlatformTextbox.Location = new System.Drawing.Point(416, 34);
            this.PlatformTextbox.Name = "PlatformTextbox";
            this.PlatformTextbox.Size = new System.Drawing.Size(146, 22);
            this.PlatformTextbox.TabIndex = 2;
            // 
            // ModelTextbox
            // 
            this.ModelTextbox.Location = new System.Drawing.Point(416, 85);
            this.ModelTextbox.Name = "ModelTextbox";
            this.ModelTextbox.Size = new System.Drawing.Size(146, 22);
            this.ModelTextbox.TabIndex = 3;
            // 
            // ConditionLabel
            // 
            this.ConditionLabel.AutoSize = true;
            this.ConditionLabel.Location = new System.Drawing.Point(41, 39);
            this.ConditionLabel.Name = "ConditionLabel";
            this.ConditionLabel.Size = new System.Drawing.Size(67, 17);
            this.ConditionLabel.TabIndex = 4;
            this.ConditionLabel.Text = "Condition";
            // 
            // ManufacturerLabel
            // 
            this.ManufacturerLabel.AutoSize = true;
            this.ManufacturerLabel.Location = new System.Drawing.Point(16, 88);
            this.ManufacturerLabel.Name = "ManufacturerLabel";
            this.ManufacturerLabel.Size = new System.Drawing.Size(92, 17);
            this.ManufacturerLabel.TabIndex = 5;
            this.ManufacturerLabel.Text = "Manufacturer";
            // 
            // PlatformLabel
            // 
            this.PlatformLabel.AutoSize = true;
            this.PlatformLabel.Location = new System.Drawing.Point(350, 37);
            this.PlatformLabel.Name = "PlatformLabel";
            this.PlatformLabel.Size = new System.Drawing.Size(60, 17);
            this.PlatformLabel.TabIndex = 6;
            this.PlatformLabel.Text = "Platform";
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Location = new System.Drawing.Point(364, 88);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(46, 17);
            this.ModelLabel.TabIndex = 7;
            this.ModelLabel.Text = "Model";
            // 
            // DisplayListBox
            // 
            this.DisplayListBox.FormattingEnabled = true;
            this.DisplayListBox.ItemHeight = 16;
            this.DisplayListBox.Location = new System.Drawing.Point(114, 22);
            this.DisplayListBox.Name = "DisplayListBox";
            this.DisplayListBox.Size = new System.Drawing.Size(448, 340);
            this.DisplayListBox.TabIndex = 0;
            // 
            // LCDSizeLabel
            // 
            this.LCDSizeLabel.AutoSize = true;
            this.LCDSizeLabel.Location = new System.Drawing.Point(7, 24);
            this.LCDSizeLabel.Name = "LCDSizeLabel";
            this.LCDSizeLabel.Size = new System.Drawing.Size(66, 17);
            this.LCDSizeLabel.TabIndex = 1;
            this.LCDSizeLabel.Text = "LCD SIze";
            // 
            // MemoryLabel
            // 
            this.MemoryLabel.AutoSize = true;
            this.MemoryLabel.Location = new System.Drawing.Point(7, 57);
            this.MemoryLabel.Name = "MemoryLabel";
            this.MemoryLabel.Size = new System.Drawing.Size(58, 17);
            this.MemoryLabel.TabIndex = 2;
            this.MemoryLabel.Text = "Memory";
            // 
            // CPUBrandLabel
            // 
            this.CPUBrandLabel.AutoSize = true;
            this.CPUBrandLabel.Location = new System.Drawing.Point(7, 92);
            this.CPUBrandLabel.Name = "CPUBrandLabel";
            this.CPUBrandLabel.Size = new System.Drawing.Size(78, 17);
            this.CPUBrandLabel.TabIndex = 3;
            this.CPUBrandLabel.Text = "CPU Brand";
            // 
            // CPUTypeLabel
            // 
            this.CPUTypeLabel.AutoSize = true;
            this.CPUTypeLabel.Location = new System.Drawing.Point(6, 129);
            this.CPUTypeLabel.Name = "CPUTypeLabel";
            this.CPUTypeLabel.Size = new System.Drawing.Size(72, 17);
            this.CPUTypeLabel.TabIndex = 4;
            this.CPUTypeLabel.Text = "CPU Type";
            // 
            // CPUNumberLabel
            // 
            this.CPUNumberLabel.AutoSize = true;
            this.CPUNumberLabel.Location = new System.Drawing.Point(6, 168);
            this.CPUNumberLabel.Name = "CPUNumberLabel";
            this.CPUNumberLabel.Size = new System.Drawing.Size(90, 17);
            this.CPUNumberLabel.TabIndex = 5;
            this.CPUNumberLabel.Text = "CPU Number";
            // 
            // CPUSpeedLabel
            // 
            this.CPUSpeedLabel.AutoSize = true;
            this.CPUSpeedLabel.Location = new System.Drawing.Point(7, 209);
            this.CPUSpeedLabel.Name = "CPUSpeedLabel";
            this.CPUSpeedLabel.Size = new System.Drawing.Size(81, 17);
            this.CPUSpeedLabel.TabIndex = 6;
            this.CPUSpeedLabel.Text = "CPU Speed";
            // 
            // HDDLabel
            // 
            this.HDDLabel.AutoSize = true;
            this.HDDLabel.Location = new System.Drawing.Point(7, 246);
            this.HDDLabel.Name = "HDDLabel";
            this.HDDLabel.Size = new System.Drawing.Size(38, 17);
            this.HDDLabel.TabIndex = 7;
            this.HDDLabel.Text = "HDD";
            // 
            // GPUTypeLabel
            // 
            this.GPUTypeLabel.AutoSize = true;
            this.GPUTypeLabel.Location = new System.Drawing.Point(7, 278);
            this.GPUTypeLabel.Name = "GPUTypeLabel";
            this.GPUTypeLabel.Size = new System.Drawing.Size(74, 17);
            this.GPUTypeLabel.TabIndex = 8;
            this.GPUTypeLabel.Text = "GPU Type";
            // 
            // WebcamLabel
            // 
            this.WebcamLabel.AutoSize = true;
            this.WebcamLabel.Location = new System.Drawing.Point(7, 309);
            this.WebcamLabel.Name = "WebcamLabel";
            this.WebcamLabel.Size = new System.Drawing.Size(63, 17);
            this.WebcamLabel.TabIndex = 9;
            this.WebcamLabel.Text = "Webcam";
            // 
            // OSLabel
            // 
            this.OSLabel.AutoSize = true;
            this.OSLabel.Location = new System.Drawing.Point(7, 339);
            this.OSLabel.Name = "OSLabel";
            this.OSLabel.Size = new System.Drawing.Size(28, 17);
            this.OSLabel.TabIndex = 10;
            this.OSLabel.Text = "OS";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(45, 34);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(40, 17);
            this.PriceLabel.TabIndex = 0;
            this.PriceLabel.Text = "Price";
            // 
            // SalesLabel
            // 
            this.SalesLabel.AutoSize = true;
            this.SalesLabel.Location = new System.Drawing.Point(45, 106);
            this.SalesLabel.Name = "SalesLabel";
            this.SalesLabel.Size = new System.Drawing.Size(112, 17);
            this.SalesLabel.TabIndex = 1;
            this.SalesLabel.Text = "Sales Tax (13%)";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(45, 152);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(40, 17);
            this.TotalLabel.TabIndex = 2;
            this.TotalLabel.Text = "Total";
            // 
            // PriceTextbox
            // 
            this.PriceTextbox.Location = new System.Drawing.Point(355, 29);
            this.PriceTextbox.Name = "PriceTextbox";
            this.PriceTextbox.ReadOnly = true;
            this.PriceTextbox.Size = new System.Drawing.Size(123, 22);
            this.PriceTextbox.TabIndex = 3;
            this.PriceTextbox.Text = "1,499.99";
            // 
            // SalesTaxTextbox
            // 
            this.SalesTaxTextbox.Location = new System.Drawing.Point(355, 103);
            this.SalesTaxTextbox.Name = "SalesTaxTextbox";
            this.SalesTaxTextbox.ReadOnly = true;
            this.SalesTaxTextbox.Size = new System.Drawing.Size(123, 22);
            this.SalesTaxTextbox.TabIndex = 4;
            this.SalesTaxTextbox.Text = "196.00";
            // 
            // TotalTextbox
            // 
            this.TotalTextbox.Location = new System.Drawing.Point(355, 149);
            this.TotalTextbox.Name = "TotalTextbox";
            this.TotalTextbox.ReadOnly = true;
            this.TotalTextbox.Size = new System.Drawing.Size(123, 22);
            this.TotalTextbox.TabIndex = 5;
            this.TotalTextbox.Text = "1,694.99";
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 601);
            this.Controls.Add(this.FinishButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.PriceGroupBox);
            this.Controls.Add(this.SystemGroupBox2);
            this.Controls.Add(this.SystemGroupBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MenuStrip);
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "OrderForm";
            this.Text = "Form1";
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.SystemGroupBox.ResumeLayout(false);
            this.SystemGroupBox.PerformLayout();
            this.SystemGroupBox2.ResumeLayout(false);
            this.SystemGroupBox2.PerformLayout();
            this.PriceGroupBox.ResumeLayout(false);
            this.PriceGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox SystemGroupBox;
        private System.Windows.Forms.GroupBox SystemGroupBox2;
        private System.Windows.Forms.GroupBox PriceGroupBox;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button FinishButton;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.Label PlatformLabel;
        private System.Windows.Forms.Label ManufacturerLabel;
        private System.Windows.Forms.Label ConditionLabel;
        private System.Windows.Forms.TextBox ModelTextbox;
        private System.Windows.Forms.TextBox PlatformTextbox;
        private System.Windows.Forms.TextBox ManufacturerTextbox;
        private System.Windows.Forms.TextBox ConditionTextbox;
        private System.Windows.Forms.Label OSLabel;
        private System.Windows.Forms.Label WebcamLabel;
        private System.Windows.Forms.Label GPUTypeLabel;
        private System.Windows.Forms.Label HDDLabel;
        private System.Windows.Forms.Label CPUSpeedLabel;
        private System.Windows.Forms.Label CPUNumberLabel;
        private System.Windows.Forms.Label CPUTypeLabel;
        private System.Windows.Forms.Label CPUBrandLabel;
        private System.Windows.Forms.Label MemoryLabel;
        private System.Windows.Forms.Label LCDSizeLabel;
        private System.Windows.Forms.ListBox DisplayListBox;
        private System.Windows.Forms.TextBox TotalTextbox;
        private System.Windows.Forms.TextBox SalesTaxTextbox;
        private System.Windows.Forms.TextBox PriceTextbox;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label SalesLabel;
        private System.Windows.Forms.Label PriceLabel;
    }
}

