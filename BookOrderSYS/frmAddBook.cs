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
    public partial class frmAddBook : Form
    {
        frmMainMenu parent;
        public frmAddBook()
        {
            InitializeComponent();
        }

        public frmAddBook(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;

        }

        private void mnuAddBookBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            string author = txtAuthor.Text;
            string priceAsText = txtPrice.Text;
            string stockAsText = txtStock.Text;

            //check if the fields were left empty
            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(author) ||
                    string.IsNullOrWhiteSpace(priceAsText) || string.IsNullOrWhiteSpace(stockAsText))
            {
                MessageBox.Show("Please fill in all fields.",
                                "Missing Info", 
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //validate price n stock
            if (!decimal.TryParse(priceAsText, out decimal price) || price < 0)
            {
                MessageBox.Show("Please enter a valid positive number.",
                                "Invalid Info",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(stockAsText, out int stock) || stock <= 0)
            {
                MessageBox.Show("Please enter a valid whole number.",
                                "Invalid Info",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //would save data - but not doing this now

            //confirmation message
            MessageBox.Show("Book added successfully!",
                            "Confirmation",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

            //reset UI
            txtTitle.Clear();
            txtAuthor.Clear();
            txtPrice.Clear();
            txtStock.Clear();
        }

        private void frmAddBook_Load(object sender, EventArgs e)
        {

        }
    }
}
