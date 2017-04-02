﻿using System;
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
    public partial class SelectForm : Form
    {
        //public variables
        public StartForm PreviousForm;

        //private variables
        private product product;
        private ProductContext DBO = new ProductContext();

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

            CostConversion();

        }

        private void CostConversion()
        {
            //Auto Generated by the database setup
            this.productsTableAdapter.Fill(this.dollarComputersDataSet.products);
            //makes a list with the products in dbo.products
            List<product> ProductList = (from product in DBO.products select product).ToList();
            CompDataGridView.DataSource = ProductList;

            //function for rounding
            foreach (product products in ProductList)
            {
                Decimal cost = (Decimal)products.cost;
                //rounds to 2 decimal places for cost column
                products.cost = Decimal.Round(cost, 2);
            }
        }

        private void FillInfo()
        {

            if (Program.ChosenProduct != null)
            {
                product = Program.ChosenProduct;
                foreach (DataGridViewRow DataGridView in CompDataGridView.Rows)

                {
                    product chosen = (product)DataGridView.DataBoundItem;
                    if (chosen.productID == product.productID)
                        DataGridView.Selected = true;
                }

            }

            ChoiceTextBox.Text = CompDataGridView.SelectedRows[0].Cells[2].Value.ToString() + ", " + CompDataGridView.SelectedRows[0].Cells[3].Value.ToString()
              + ", Priced at: " + CompDataGridView.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void CompDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //funs the fillinfo method made above
            FillInfo();
            //fills a temp varable with the selected information
            var itemSelected = (sender as DataGridView).SelectedRows[0];
            product Chosen = (product)itemSelected.DataBoundItem;
            //Sends chosen info to the product class
            Program.ChosenProduct = Chosen;
            //enables next button for moving to next page
             NextButton.Enabled = true;
            }
                
        }
    }

