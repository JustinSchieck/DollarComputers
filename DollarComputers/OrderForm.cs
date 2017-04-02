using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DollarComputers
{
    public partial class OrderForm : Form
    {
        public ProductInfoForm PreviousForm { get; set; }

        public OrderForm()
        {
            InitializeComponent();
            ConditionTextbox.Text = Program.ChosenProduct.condition;
            PlatformTextbox.Text = Program.ChosenProduct.platform;
            ManufacturerTextbox.Text = Program.ChosenProduct.manufacturer;
            ModelTextbox.Text = Program.ChosenProduct.model;

            LCDTextbox.Text = Program.ChosenProduct.screensize;
            MemoryTextbox.Text = Program.ChosenProduct.RAM_size;
            CPUBrandTextbox.Text = Program.ChosenProduct.CPU_brand;
            CPUTypeTextbox.Text = Program.ChosenProduct.CPU_type;
            CPUNumberTextbox.Text = Program.ChosenProduct.CPU_number;
            CPUSpeedTextbox.Text = Program.ChosenProduct.CPU_speed;
            HDDTextbox.Text = Program.ChosenProduct.HDD_size;
            GPUTypeTextbox.Text = Program.ChosenProduct.GPU_Type;
            WebcamTextbox.Text = Program.ChosenProduct.webcam;
            OSTextbox.Text = Program.ChosenProduct.OS;

            PriceTextbox.Text = Program.ChosenProduct.cost.ToString();
            double Subtotal = Convert.ToDouble(Program.ChosenProduct.cost);
            double Tax = Subtotal * 0.13;
            SalesTaxTextbox.Text = Tax.ToString();
            TotalTextbox.Text = (Subtotal * 1.13).ToString();

        }


        private void FillForm()
        {


        }
        private void OrderForm_Load(object sender, EventArgs e)
        {
            FillForm();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you!" + "\n" + "\n" +"Your Items will be shipped in 7 to 10 days" );
            Application.Exit();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.PreviousForm.Show();
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutbox = new AboutBox();
            aboutbox.ShowDialog();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            MessageBox.Show("Your item " + Program.ChosenProduct.manufacturer + Program.ChosenProduct.model + "is now being printed" + "\n" + "Please wait");
        }


    }
}
