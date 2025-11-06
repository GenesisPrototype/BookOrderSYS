using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace BookOrderSYS
{
    public partial class frmRemoveBook : Form
    {
        frmMainMenu parent;

        public frmRemoveBook()
        {
            InitializeComponent();
        }

        public frmRemoveBook(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;

        }

        private void mnuRemoveBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void btnRemoveBook_Click(object sender, EventArgs e)
        {
            if (txtRemoveBookID.Text == "")
            {
                MessageBox.Show("Enter the Book ID.", "Missing Info",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtRemoveBookID.Text, out int id) || id <= 0)
            {
                MessageBox.Show("Book ID must be a positive number.", "Invalid Info",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to remove this book?",
                                      "Confirm Removal",
                                      MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Book with ID " + txtRemoveBookID.Text + " has been removed.", "Confirmation",
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);

                //reset ui
                txtRemoveBookID.Clear();
            }
        }
    }
}
