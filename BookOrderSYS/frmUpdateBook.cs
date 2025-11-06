using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BookOrderSYS
{
    public partial class frmUpdateBook : Form
    {
        frmMainMenu parent;
        public frmUpdateBook()
        {
            InitializeComponent();
        }

        public frmUpdateBook(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;

        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void frmUpdateBook_Load(object sender, EventArgs e)
        {
            txtUpdateBookTitle.Enabled = false;
            txtUpdateBookAuthor.Enabled = false;
            txtUpdateBookPrice.Enabled = false;
            txtUpdateBookStock.Enabled = false;
            btnUpdateBook.Enabled = false;
        }

        private void txtUpdateBookID_TextChanged(object sender, EventArgs e)
        {
            int id;

            if (int.TryParse(txtUpdateBookID.Text, out id) && id > 0)
            {
                // Enable fields if ID is a positive number
                txtUpdateBookTitle.Enabled = true;
                txtUpdateBookAuthor.Enabled = true;
                txtUpdateBookPrice.Enabled = true;
                txtUpdateBookStock.Enabled = true;
                btnUpdateBook.Enabled = true;
            }
            else
            {
                txtUpdateBookTitle.Enabled = false;
                txtUpdateBookAuthor.Enabled = false;
                txtUpdateBookPrice.Enabled = false;
                txtUpdateBookStock.Enabled = false;
                btnUpdateBook.Enabled = false;
            }
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {

            //validate
            string message = "Book updated! \n\n\nUpdated details:\n\nID: " + txtUpdateBookID.Text;

            if (txtUpdateBookTitle.Text != "")
            {
                message += "\nName: " + txtUpdateBookTitle.Text;
            }

            if (txtUpdateBookAuthor.Text != "")
            {
                message += "\nEmail: " + txtUpdateBookAuthor.Text;
            }

            if (txtUpdateBookPrice.Text != "")
            {
                message += "\nPhone: " + txtUpdateBookPrice.Text;
            }

            if (txtUpdateBookStock.Text != "")
            {
                message += "\nTotal Orders: " + txtUpdateBookStock.Text;
            }

            //confirmation message with the updated deets
            MessageBox.Show(message, "Confirmation",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

            //reset UI
            txtUpdateBookID.Clear();
            txtUpdateBookTitle.Clear();
            txtUpdateBookAuthor.Clear();
            txtUpdateBookPrice.Clear();
            txtUpdateBookStock.Clear();
        }

    }
}
