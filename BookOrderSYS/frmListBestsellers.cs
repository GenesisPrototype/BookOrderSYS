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
    public partial class frmListBestsellers : Form
    {
        frmMainMenu parent;
        public frmListBestsellers()
        {
            InitializeComponent();
        }

        public frmListBestsellers(frmMainMenu parent) 
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void frmListBestsellers_Load(object sender, EventArgs e)
        {
            listBoxListBestsellers.Items.Add("1.   The Catcher in the Rye - J.D Salinger");
            listBoxListBestsellers.Items.Add("2.   The Bell Jar - Sylvia Plath ");
            listBoxListBestsellers.Items.Add("3.   Auf Wiedersehen Sweetheart - George DeValier");
            listBoxListBestsellers.Items.Add("4.   The Lightning Thief - Rick Riordan");
            listBoxListBestsellers.Items.Add("5.   The Outsider - S.E Hinton");
            listBoxListBestsellers.Items.Add("6.   Solaris - Stanisław Lem");
            listBoxListBestsellers.Items.Add("7.   Out - Natsuo Kirino ");
            listBoxListBestsellers.Items.Add("8.   1984 - George Orwell");
            listBoxListBestsellers.Items.Add("9.   I Have No Mouth and I Must Scream - Harlan Ellison");
            listBoxListBestsellers.Items.Add("10.  The Haunting of Hill House - Shirley Jackson");
        }

        private void mnuListBestsellersBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void listBoxListBestsellers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
