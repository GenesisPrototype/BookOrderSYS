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
    }
}
