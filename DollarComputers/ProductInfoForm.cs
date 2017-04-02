using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DollarComputers
{
    public partial class ProductInfoForm : Form
    {
        public SelectForm PreviousForm { get; set; }
        public object SaveProductFileDialog { get; private set; }


        private StreamWriter _writer;
        private StreamReader _reader;
        private const char _DELIMETER = ',';
        private product _product;

        public ProductInfoForm()
        {
            InitializeComponent();
            this._product = new product();
        }

        private void ProductInfoForm_Load(object sender, EventArgs e)
        {
            ProductIDTextbox.Text = Program.ChosenProduct.productID.ToString();
            ConditionTextbox.Text = Program.ChosenProduct.condition;
            CostTextbox.Text = Program.ChosenProduct.cost.ToString();
            PlatformTextBox.Text = Program.ChosenProduct.platform;
            ManufactuerTextbox.Text = Program.ChosenProduct.manufacturer;
            OSTextbox.Text = Program.ChosenProduct.OS;
            ModelTextBox.Text = Program.ChosenProduct.model;
            MemoryTextBox.Text = Program.ChosenProduct.RAM_size;
            LCDTextbox.Text = Program.ChosenProduct.screensize;
            HDDTextbox.Text = Program.ChosenProduct.HDD_size;
            CPUBrandTextbox.Text = Program.ChosenProduct.CPU_brand;
            CPUNumberTextbox.Text = Program.ChosenProduct.CPU_number;
            GPUTextbox.Text = Program.ChosenProduct.GPU_Type;
            CPUTypeTextbox.Text = Program.ChosenProduct.CPU_type;
            CPUSpeedTextbox.Text = Program.ChosenProduct.CPU_speed;
            WebcamTextbox.Text = Program.ChosenProduct.webcam;
        }


        private void AnoutherProductButton_Click(object sender, EventArgs e)
        {
            this.PreviousForm.Show();
            this.Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveInfo();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReadInfo();
        }

        //Event Methods
        private void ReadInfo()
        {
            string fullProductString = "";
            try
            {
                _reader = new StreamReader("Product.txt");
                if(_reader.Peek() != -1)
                {
                    fullProductString = this._reader.ReadLine();

                  //_product.productID = fullProductString.Split(_DELIMETER)[0];
                    ConditionTextbox.Text = fullProductString.Split(_DELIMETER)[1];
                  //_product.cost = fullProductString.Split(_DELIMETER)[2];
                    _product.platform = fullProductString.Split(_DELIMETER)[3];
                    _product.manufacturer = fullProductString.Split(_DELIMETER)[4];
                    _product.OS = fullProductString.Split(_DELIMETER)[5];
                    _product.model = fullProductString.Split(_DELIMETER)[6];
                    _product.RAM_size = fullProductString.Split(_DELIMETER)[7];
                    _product.screensize = fullProductString.Split(_DELIMETER)[8];
                    _product.HDD_size = fullProductString.Split(_DELIMETER)[9];
                    _product.CPU_brand = fullProductString.Split(_DELIMETER)[10];
                    _product.CPU_number = fullProductString.Split(_DELIMETER)[11];
                    _product.GPU_Type = fullProductString.Split(_DELIMETER)[12];
                    _product.CPU_type = fullProductString.Split(_DELIMETER)[13];
                    _product.CPU_speed = fullProductString.Split(_DELIMETER)[14];
                    _product.webcam = fullProductString.Split(_DELIMETER)[15];

                }else
                {
                    MessageBox.Show("An Error Has Occured", "Error",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this._reader.Close();
            }
            catch(Exception exception)
            {
                Debug.WriteLine(exception.Message);
                MessageBox.Show("Error Opening", "File Load Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this._reader.Close();
        }

        private void SaveInfo()
        {
            //makes sure user is ready to save
            DialogResult UserResult = MessageBox.Show("Are You Sure?", "Confirm", MessageBoxButtons.YesNo);
            if (UserResult == DialogResult.Yes)
            {
                // Open a writer and Write to the file
                _writer = new StreamWriter("Product.txt", true);               
                _writer.WriteLine(ProductIDTextbox.Text + _DELIMETER + 
                    ConditionTextbox.Text + _DELIMETER + 
                    CostTextbox.Text + _DELIMETER +
                    PlatformTextBox.Text + _DELIMETER + 
                    ManufactuerTextbox.Text + _DELIMETER + 
                    OSTextbox.Text + _DELIMETER + 
                    ModelTextBox + _DELIMETER + 
                    MemoryTextBox.Text + _DELIMETER + 
                    LCDTextbox.Text + _DELIMETER + 
                    HDDTextbox.Text + _DELIMETER + 
                    CPUBrandTextbox.Text + _DELIMETER + 
                    CPUNumberTextbox.Text + _DELIMETER + 
                    CPUSpeedTextbox.Text + _DELIMETER + 
                    GPUTextbox.Text + _DELIMETER + 
                    WebcamTextbox.Text);

              //Close the file
                _writer.Close();

                // Resets all boxes
                ProductIDTextbox.Clear();
                ConditionTextbox.Clear();
                CostTextbox.Clear();
                PlatformTextBox.Clear();
                ManufactuerTextbox.Clear();
                OSTextbox.Clear();
                ModelTextBox.Clear();
                MemoryTextBox.Clear();
                LCDTextbox.Clear();
                HDDTextbox.Clear();
                CPUBrandTextbox.Clear();
                CPUNumberTextbox.Clear();
                CPUTypeTextbox.Clear();
                GPUTextbox.Clear();
                CPUSpeedTextbox.Clear();
                WebcamTextbox.Clear();
            }

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            OrderForm orderform = new OrderForm();
            orderform.PreviousForm = this;
            orderform.Show();
            this.Hide();
        }


    }
}
