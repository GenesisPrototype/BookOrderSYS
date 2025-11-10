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
    public partial class frmViewOrder : Form
    {
        frmMainMenu parent;

        public frmViewOrder()
        {
            InitializeComponent();
        }

        public frmViewOrder(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;

        }

        private void mnuViewOrderBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void btnViewOrder_Click(object sender, EventArgs e)
        {
            if (txtViewOrderID.Text == "")
            {
                MessageBox.Show("Enter the Order ID.", "Missing Info",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtViewOrderID.Text, out int id) || id <= 0)
            {
                MessageBox.Show("Order ID must be a valid number.", "Invalid Info",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Simulate order details
            string details = "Order ID: " + id +
                             "\n\nCustomer name: Alfred Jones" +
                             "\n\nDate: 04/07/2025" +
                             "\n\nItems:" +
                             "\n-Book ID: 19  |  Title: \"We'll Meet Again\"  |  Qty: 1  |  Price: €17.99" +
                             "\n-Book ID: 248  |  Title: \"World War Z\"  |  Qty: 1  |  Price: €9.99" +
                             "\n\nTotal: €27.98" +
                             "\n\nStatus: Shipped";

            lblViewOrderDetails.Text = details;
            lblViewOrderDetails.Visible = true;
        }
    }
}
