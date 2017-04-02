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


    /// <summary>
    /// Program: Dollar Computers Assignment 3
    /// Name: Justin Schieck
    /// StudentID: 200328630
    /// App Creation Date: April 4th, 2017
    /// App Desc: Computer OrderForm 
    /// </summary>

    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }
        //splash timer for how long it should be open
        private void _SplashTimer_Tick(object sender, EventArgs e)
        {
            StartForm startForm = new StartForm();

            this.SplashTimer.Enabled = false;
            startForm.Show();
            Hide();
        }
    }
}
