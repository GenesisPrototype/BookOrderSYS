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
    public partial class frmUpdateCustomer : Form
    {
        frmMainMenu parent;
        public frmUpdateCustomer()
        {
            InitializeComponent();
        }

        public frmUpdateCustomer(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;

        }

        private void mnuUpdateCustomerBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void frmUpdateCustomer_Load(object sender, EventArgs e)
        {
            txtName.Enabled = false;
            txtEmail.Enabled = false;
            txtPhone.Enabled = false;
            txtOrders.Enabled = false;
            btnUpdateCustomer.Enabled = false;
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            int id;

            if (int.TryParse(txtID.Text, out id) && id > 0)
            {
                // Enable fields if ID is a positive number
                txtName.Enabled = true;
                txtEmail.Enabled = true;
                txtPhone.Enabled = true;
                txtOrders.Enabled = true;
                btnUpdateCustomer.Enabled = true;
            }
            else
            {
                txtName.Enabled = false;
                txtEmail.Enabled = false;
                txtPhone.Enabled = false;
                txtOrders.Enabled = false;
                btnUpdateCustomer.Enabled = false;
            }
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            //validate
            string message = "Customer updated! \n\n\nUpdated details:\n\nID: " + txtID.Text;

            if (txtName.Text != "")
            {
                if (txtName.Text.Any(char.IsDigit))
                {
                    MessageBox.Show("Name cannot contain numbers.", "Invalid Info",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                message += "\nName: " + txtName.Text;
            }

            if (txtEmail.Text != "")
            {
                message += "\nEmail: " + txtEmail.Text;
            }

            if (txtPhone.Text != "")
            {
                message += "\nPhone: " + txtPhone.Text;
            }

            if (txtOrders.Text != "")
            {
                if (!int.TryParse(txtOrders.Text, out int totalOrders) || totalOrders < 0)
                {
                    MessageBox.Show("Please enter a valid number of orders placed.", "Invalid Info",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                message += "\nTotal Orders: " + txtOrders.Text;
            }

            //confirmation message with the updated deets
            MessageBox.Show(message, "Confirmation",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

            //reset UI
            txtID.Clear();
            txtName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtOrders.Clear();




        }
    }
}
