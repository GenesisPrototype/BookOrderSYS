using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BookOrderSYS
{
    public partial class frmAddCustomer : Form
    {
        frmMainMenu parent;
        public frmAddCustomer()
        {
            InitializeComponent();
        }

        public frmAddCustomer(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;

        }



        private void frmAddCustomer_Load(object sender, EventArgs e)
        {

        }

        private void mnuAddCustomerBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string email = txtEmail.Text;
            string phone = txtPhone.Text;
            string existingEmail = "anonymous@gmail.com";

            //check if the fields were left empty
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(phone))
            {
                MessageBox.Show("Please fill in all fields.", "Missing Info",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //validate name
            if (name.Any(char.IsDigit))
            {
                MessageBox.Show("Name cannot contain numbers.", "Invalid Info",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }

            //validate email
            if (string.IsNullOrEmpty(email) || !email.Contains("@") || !email.Contains("."))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error", 
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }

            if (email == existingEmail)
            {
                MessageBox.Show("This email is already registered.", "Existing Email",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                txtEmail.SelectAll();
                return;
            }

            //would save data - but not doing this now

            //confirmation message
            string message = "Customer added successfully!\n\n" +
                 "\nName: " + name +
                 "\nEmail: " + email +
                 "\nPhone: " + phone;

            MessageBox.Show(message, "Confirmation",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

            //reset UI
            txtName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
        }
    }
}
