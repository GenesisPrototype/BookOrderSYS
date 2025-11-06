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
    public partial class frmCancelOrder : Form
    {
        frmMainMenu parent;

        public frmCancelOrder()
        {
            InitializeComponent();
        }

        public frmCancelOrder(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;

        }

        private void mnuCancelOrderBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            if (txtCancelOrderID.Text == "")
            {
                MessageBox.Show("Enter the Order ID.", "Missing Info",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtCancelOrderID.Text, out int id) || id <= 0)
            {
                MessageBox.Show("Order ID must be a positive number.", "Invalid Info",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to cancel this order?",
                                                  "Confirm Cancellation",
                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Order with ID " + txtCancelOrderID.Text + " has been cancelled.", "Confirmation",
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);

                //reset ui
                txtCancelOrderID.Clear();

            }
        }
    }
}
