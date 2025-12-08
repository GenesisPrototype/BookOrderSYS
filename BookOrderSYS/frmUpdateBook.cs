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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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
            string id = txtUpdateBookID.Text;
            string title = txtUpdateBookTitle.Text;
            string author = txtUpdateBookAuthor.Text;
            string priceAsText = txtUpdateBookPrice.Text;
            string stockAsText = txtUpdateBookStock.Text;

            
            //check if the fields were left empty
            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(author) || string.IsNullOrWhiteSpace(priceAsText)
                || string.IsNullOrWhiteSpace(stockAsText))
            {
                MessageBox.Show("Please fill in all fields.", "Missing Info",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //validate author's name
            if (author.Any(char.IsDigit))
            {
                MessageBox.Show("Author's name cannot contain numbers.", "Invalid Info",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUpdateBookAuthor.Focus();
                return;
            }

            //validate price
            if (!decimal.TryParse(priceAsText, out decimal price) || price <= 0)
            {
                MessageBox.Show("Please enter a valid price.", "Invalid Info",
                                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUpdateBookPrice.Focus();
                return;
            }
 
            //validate stock qty
            if (!int.TryParse(stockAsText, out int stock) || stock < 0)
            {

                MessageBox.Show("Please enter a valid stock number.", "Invalid Info",
                                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUpdateBookStock.Focus();
                return;
            }


            //confirmation message with the updated details
            string message = "Book updated! \n\n\nUpdated details:" +
                "\n\nID: " + id +
                "\nTitle: " + title +
                "\nAuthor: " + author + 
                "\nPrice: " + priceAsText + 
                "\nQty: " + stockAsText;

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
