using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookOrderSYS
{
    public partial class frmViewCustomer : Form
    {
        frmMainMenu parent;
        public frmViewCustomer()
        {
            InitializeComponent();
        }

        public frmViewCustomer(frmMainMenu parent) { 
            InitializeComponent();
            this.parent = parent;
        
        }

        private void mnuViewCustomerBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }


        private void frmViewCustomer_Load(object sender, EventArgs e)
        {

        }

        private void btnViewCustomer_Click(object sender, EventArgs e)
        {
            if (txtViewCustomer.Text == "")
            {
                MessageBox.Show("Enter the Customer ID.", "Missing Info",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtViewCustomer.Text, out int id) || id <= 0)
            {
                MessageBox.Show("Customer ID must be a valid number.", "Invalid Info",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //hardcoded customer details
            string details = "Customer ID: " + id +
                             "\n\nName: Alfred Jones" +
                             "\n\nEmail: alfredosauce@gmail.com" +
                             "\n\nPhone: 0867483957";

            lblViewCustomerDetails.Text = details;
            lblViewCustomerDetails.Visible = true;
        }
    }
}
