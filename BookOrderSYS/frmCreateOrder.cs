using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BookOrderSYS
{
    public partial class frmCreateOrder : Form
    {
        frmMainMenu parent;

        public frmCreateOrder()
        {
            InitializeComponent();
        }

        public frmCreateOrder(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;

        }

        private void mnuCreateOrderBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            string customer = cboSelectCustomer.SelectedItem?.ToString();
            string book = cboSelectBook.SelectedItem?.ToString();
            string qtyText = txtCreateOrderQty.Text;

            string orderID = "3";
            string date = DateTime.Now.ToShortDateString(); 
            string status = "Pending";


            //validation
            if (string.IsNullOrEmpty(customer) || string.IsNullOrEmpty(book) || string.IsNullOrEmpty(qtyText))
            {
                MessageBox.Show("Please fill in all fields.", "Missing Info",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int qty;
            if (!int.TryParse(qtyText, out qty) || qty <= 0)
            {
                MessageBox.Show("Enter a valid quantity.", "Invalid Info",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //confirmation message
            string message = "Order Created!" +
                             "\n\nOrder ID: " + orderID +
                             "\nCustomer name: " + customer +
                             "\nDate: "  + date + 
                             "\nItem: \"" + book + "\"" +
                             "\nQuantity: " + qty +
                             "\nStatus: " + status;

            MessageBox.Show(message, "Order Confirmation",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

            cboSelectCustomer.SelectedIndex = -1;
            cboSelectBook.SelectedIndex = -1;
            txtCreateOrderQty.Clear();
        }
    }
}
