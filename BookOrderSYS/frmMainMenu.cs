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
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            lblBooktopia.Parent = pictureBox1;
            lblBooktopia.BackColor = Color.Transparent;
        }

        private void addCusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmViewCustomer nextForm = new frmViewCustomer(this);
            nextForm.Show();
        }



        private void updateCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUpdateCustomer nextForm = new frmUpdateCustomer(this);
            nextForm.Show();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            //Ask user to confirm 
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?",
                                                         "Confirmation",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Question);

            //Now, check response
            if (dialogResult == DialogResult.Yes) { 
                Application.Exit();
            }

        }

        private void listBestsellersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            frmListBestsellers nextForm = new frmListBestsellers(this);
            nextForm.Show();
            this.Hide();
        }

        private void mnuAdmin_Click(object sender, EventArgs e)
        {

        }

        private void listBestsellersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmYearlyRevenueAnalysis nextForm = new frmYearlyRevenueAnalysis(this);
            nextForm.Show();
            this.Hide();
        }

        private void mnuAddBook_Click(object sender, EventArgs e)
        {
            frmAddBook nextForm = new frmAddBook(this);
            nextForm.Show();
            this.Hide();
        }

        private void updateBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateBook nextForm = new frmUpdateBook(this);
            nextForm.Show();
            this.Hide();
        }

        private void removeBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRemoveBook nextForm = new frmRemoveBook(this);
            nextForm.Show();
            this.Hide();
        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCancelOrder nextForm = new frmCancelOrder(this);
            nextForm.Show();
            this.Hide();
        }

        private void cancelOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmViewOrder nextForm = new frmViewOrder(this);
            nextForm.Show();
            this.Hide();
        }

        private void createOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCreateOrder nextForm = new frmCreateOrder(this);
            nextForm.Show();
            this.Hide();
        }
    }
}
