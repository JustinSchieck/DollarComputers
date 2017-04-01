using DollarComputers.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DollarComputers
{
    public partial class SelectForm : Form
    {
        public StartForm PreviousForm;
        ProductsContext productDB = new ProductsContext();

        public SelectForm()
        {
            InitializeComponent();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            ProductInfoForm productForm = new ProductInfoForm();

            
            productForm.Show();
            this.Hide();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dollarComputersDataSet2.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter1.Fill(this.dollarComputersDataSet2.products);
        }

        private void ChoiceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CompDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ChoiceTextBox.Text = CompDataGridView.SelectedRows[0].Cells[1].Value.ToString()
            + " " + 
            CompDataGridView.SelectedRows[0].Cells[2].Value.ToString()
            + " " + 
            CompDataGridView.SelectedRows[0].Cells[3].Value.ToString();
        }
    }
}
