namespace BookOrderSYS
{
    partial class frmMainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnuMainMenu = new System.Windows.Forms.MenuStrip();
            this.mnuCustomers = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBooks = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOrders = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mnuAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRegisterCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdateCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddBook = new System.Windows.Forms.ToolStripMenuItem();
            this.updateBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBestsellersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBestsellersToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuMainMenu
            // 
            this.mnuMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(118)))), ((int)(((byte)(129)))));
            this.mnuMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCustomers,
            this.mnuBooks,
            this.mnuOrders,
            this.mnuExit,
            this.mnuAdmin});
            this.mnuMainMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMainMenu.Name = "mnuMainMenu";
            this.mnuMainMenu.Size = new System.Drawing.Size(800, 24);
            this.mnuMainMenu.TabIndex = 0;
            this.mnuMainMenu.Text = "menuStrip1";
            // 
            // mnuCustomers
            // 
            this.mnuCustomers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRegisterCustomer,
            this.mnuUpdateCustomer,
            this.mnuViewCustomer});
            this.mnuCustomers.ForeColor = System.Drawing.Color.White;
            this.mnuCustomers.Name = "mnuCustomers";
            this.mnuCustomers.Size = new System.Drawing.Size(76, 20);
            this.mnuCustomers.Text = "Customers";
            // 
            // mnuBooks
            // 
            this.mnuBooks.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddBook,
            this.updateBookToolStripMenuItem,
            this.removeBookToolStripMenuItem});
            this.mnuBooks.ForeColor = System.Drawing.Color.White;
            this.mnuBooks.Name = "mnuBooks";
            this.mnuBooks.Size = new System.Drawing.Size(51, 20);
            this.mnuBooks.Text = "Books";
            // 
            // mnuOrders
            // 
            this.mnuOrders.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createOrderToolStripMenuItem,
            this.cancelToolStripMenuItem,
            this.cancelOrderToolStripMenuItem});
            this.mnuOrders.ForeColor = System.Drawing.Color.White;
            this.mnuOrders.Name = "mnuOrders";
            this.mnuOrders.Size = new System.Drawing.Size(54, 20);
            this.mnuOrders.Text = "Orders";
            // 
            // mnuExit
            // 
            this.mnuExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(37, 20);
            this.mnuExit.Text = "Exit";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::BookOrderSYS.Properties.Resources.library2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 426);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // mnuAdmin
            // 
            this.mnuAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listBestsellersToolStripMenuItem,
            this.listBestsellersToolStripMenuItem1});
            this.mnuAdmin.ForeColor = System.Drawing.Color.White;
            this.mnuAdmin.Name = "mnuAdmin";
            this.mnuAdmin.Size = new System.Drawing.Size(55, 20);
            this.mnuAdmin.Text = "Admin";
            // 
            // mnuRegisterCustomer
            // 
            this.mnuRegisterCustomer.Name = "mnuRegisterCustomer";
            this.mnuRegisterCustomer.Size = new System.Drawing.Size(180, 22);
            this.mnuRegisterCustomer.Text = "Register Customer";
            this.mnuRegisterCustomer.Click += new System.EventHandler(this.addCusToolStripMenuItem_Click);
            // 
            // mnuUpdateCustomer
            // 
            this.mnuUpdateCustomer.Name = "mnuUpdateCustomer";
            this.mnuUpdateCustomer.Size = new System.Drawing.Size(180, 22);
            this.mnuUpdateCustomer.Text = "Update Customer";
            this.mnuUpdateCustomer.Click += new System.EventHandler(this.updateCustomerToolStripMenuItem_Click);
            // 
            // mnuViewCustomer
            // 
            this.mnuViewCustomer.Name = "mnuViewCustomer";
            this.mnuViewCustomer.Size = new System.Drawing.Size(180, 22);
            this.mnuViewCustomer.Text = "View Customer";
            // 
            // mnuAddBook
            // 
            this.mnuAddBook.Name = "mnuAddBook";
            this.mnuAddBook.Size = new System.Drawing.Size(180, 22);
            this.mnuAddBook.Text = "Add Book";
            // 
            // updateBookToolStripMenuItem
            // 
            this.updateBookToolStripMenuItem.Name = "updateBookToolStripMenuItem";
            this.updateBookToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updateBookToolStripMenuItem.Text = "Update Book";
            // 
            // removeBookToolStripMenuItem
            // 
            this.removeBookToolStripMenuItem.Name = "removeBookToolStripMenuItem";
            this.removeBookToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.removeBookToolStripMenuItem.Text = "Remove Book";
            // 
            // createOrderToolStripMenuItem
            // 
            this.createOrderToolStripMenuItem.Name = "createOrderToolStripMenuItem";
            this.createOrderToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createOrderToolStripMenuItem.Text = "Create Order";
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            this.cancelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cancelToolStripMenuItem.Text = "Cancel Order";
            // 
            // cancelOrderToolStripMenuItem
            // 
            this.cancelOrderToolStripMenuItem.Name = "cancelOrderToolStripMenuItem";
            this.cancelOrderToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cancelOrderToolStripMenuItem.Text = "View Order";
            // 
            // listBestsellersToolStripMenuItem
            // 
            this.listBestsellersToolStripMenuItem.Name = "listBestsellersToolStripMenuItem";
            this.listBestsellersToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.listBestsellersToolStripMenuItem.Text = "Show Yearly Revenue Analysis";
            this.listBestsellersToolStripMenuItem.Click += new System.EventHandler(this.listBestsellersToolStripMenuItem_Click);
            // 
            // listBestsellersToolStripMenuItem1
            // 
            this.listBestsellersToolStripMenuItem1.Name = "listBestsellersToolStripMenuItem1";
            this.listBestsellersToolStripMenuItem1.Size = new System.Drawing.Size(231, 22);
            this.listBestsellersToolStripMenuItem1.Text = "List Bestsellers";
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mnuMainMenu);
            this.MainMenuStrip = this.mnuMainMenu;
            this.Name = "frmMainMenu";
            this.Text = "Booktopia - [Main Menu]";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.mnuMainMenu.ResumeLayout(false);
            this.mnuMainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuCustomers;
        private System.Windows.Forms.ToolStripMenuItem mnuBooks;
        private System.Windows.Forms.ToolStripMenuItem mnuOrders;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem mnuAdmin;
        private System.Windows.Forms.ToolStripMenuItem mnuRegisterCustomer;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateCustomer;
        private System.Windows.Forms.ToolStripMenuItem mnuViewCustomer;
        private System.Windows.Forms.ToolStripMenuItem mnuAddBook;
        private System.Windows.Forms.ToolStripMenuItem updateBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listBestsellersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listBestsellersToolStripMenuItem1;
    }
}

