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
            dgvViewCustomer.Columns.Clear();

            dgvViewCustomer.Columns.Add("CustID", "ID");
            dgvViewCustomer.Columns.Add("Name", "Customer Name");
            dgvViewCustomer.Columns.Add("Email", "Email Address");
            dgvViewCustomer.Columns.Add("Phone", "Phone Number");
            dgvViewCustomer.Columns.Add("TotalOrders", "Orders Placed");

            dgvViewCustomer.Rows.Add(001, "Alfred Jones", "alfredfjones@gmail.com", "0851234567", 3);
            dgvViewCustomer.Rows.Add(002, "Anne Onymous", "anne.on@gmail.com", "0898461904", 8);
            dgvViewCustomer.Rows.Add(003, "Heather Mason", "heather.m@gmail.com", "0867654321", 5);
            dgvViewCustomer.Rows.Add(004, "Arthur Kirkland", "a.kirkland@gmail.com", "0879988776", 13);
            dgvViewCustomer.Rows.Add(005, "Dana Scully", "d.scully@gmail.com", "0891122334", 11);
            dgvViewCustomer.Rows.Add(006, "Vincent Freeman", "vinfreeman@gmail.com", "0899372889", 4);
            dgvViewCustomer.Rows.Add(007, "Marty McFly", "m.mcfly@gmail.com", "0891792384", 2);
            dgvViewCustomer.Rows.Add(008, "Ellen Ripley", "e.ripley@gmail.com", "0863722383", 7);
            dgvViewCustomer.Rows.Add(009, "Jack Dawson", "jack.d@gmail.com", "0891742574", 5);
            dgvViewCustomer.Rows.Add(010, "Peter Parker", "peterparker@gmail.com", "0891785294", 3);
            dgvViewCustomer.Rows.Add(011, "Nona Mouse", "nonamouse@gmail.com", "0898468291", 1);
            dgvViewCustomer.Rows.Add(012, "Scott Howard", "scotty.h@gmail.com", "0897541684", 6);
            dgvViewCustomer.Rows.Add(013, "Ivan Braginski", "ivan.brgnsky@gmail.com", "0893291579", 4);
            dgvViewCustomer.Rows.Add(014, "Leon Kennedy", "leonskennedy@gmail.com", "0899294563", 2);
            dgvViewCustomer.Rows.Add(015, "Clarice Starling", "c.starling@gmail.com", "0894834986", 9);


        }

        private void dgvViewCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
