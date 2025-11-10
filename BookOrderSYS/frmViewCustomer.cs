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
    public partial class frmViewCustomer : Form
    {
        frmMainMenu parent;
        public frmViewCustomer()
        {
            InitializeComponent();
        }

        public frmViewCustomer(frmMainMenu parent) { 
            InitializeComponent();
            this.parent = parent;
        
        }

        private void mnuViewCustomerBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }


        private void frmViewCustomer_Load(object sender, EventArgs e)
        {

        }


    }
}
