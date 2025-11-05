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
    public partial class frmRegisterCustomer : Form
    {
        frmMainMenu parent;
        public frmRegisterCustomer()
        {
            InitializeComponent();
        }

        public frmRegisterCustomer(frmMainMenu parent) { 
            InitializeComponent();
            this.parent = parent;
        
        }

        private void mnuRegisterCustomerBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void frmRegisterCustomer_Load(object sender, EventArgs e)
        {

        }


    }
}
