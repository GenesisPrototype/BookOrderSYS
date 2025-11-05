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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.mnuMainMenu = new System.Windows.Forms.MenuStrip();
            this.mnuCustomers = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRegisterCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdateCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBooks = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddBook = new System.Windows.Forms.ToolStripMenuItem();
            this.updateBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOrders = new System.Windows.Forms.ToolStripMenuItem();
            this.createOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.listBestsellersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBestsellersToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblBooktopia = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.mnuMainMenu.Size = new System.Drawing.Size(624, 24);
            this.mnuMainMenu.TabIndex = 0;
            this.mnuMainMenu.Text = "menuStrip1";
            // 
            // mnuCustomers
            // 
            this.mnuCustomers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRegisterCustomer,
            this.mnuUpdateCustomer});
            this.mnuCustomers.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuCustomers.ForeColor = System.Drawing.Color.LightGray;
            this.mnuCustomers.Name = "mnuCustomers";
            this.mnuCustomers.Size = new System.Drawing.Size(71, 20);
            this.mnuCustomers.Text = "Customers";
            // 
            // mnuRegisterCustomer
            // 
            this.mnuRegisterCustomer.Name = "mnuRegisterCustomer";
            this.mnuRegisterCustomer.Size = new System.Drawing.Size(172, 22);
            this.mnuRegisterCustomer.Text = "Register Customer";
            this.mnuRegisterCustomer.Click += new System.EventHandler(this.addCusToolStripMenuItem_Click);
            // 
            // mnuUpdateCustomer
            // 
            this.mnuUpdateCustomer.Name = "mnuUpdateCustomer";
            this.mnuUpdateCustomer.Size = new System.Drawing.Size(172, 22);
            this.mnuUpdateCustomer.Text = "Update Customer";
            this.mnuUpdateCustomer.Click += new System.EventHandler(this.updateCustomerToolStripMenuItem_Click);
            // 
            // mnuBooks
            // 
            this.mnuBooks.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddBook,
            this.updateBookToolStripMenuItem,
            this.removeBookToolStripMenuItem});
            this.mnuBooks.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuBooks.ForeColor = System.Drawing.Color.LightGray;
            this.mnuBooks.Name = "mnuBooks";
            this.mnuBooks.Size = new System.Drawing.Size(47, 20);
            this.mnuBooks.Text = "Books";
            // 
            // mnuAddBook
            // 
            this.mnuAddBook.Name = "mnuAddBook";
            this.mnuAddBook.Size = new System.Drawing.Size(180, 22);
            this.mnuAddBook.Text = "Add Book";
            this.mnuAddBook.Click += new System.EventHandler(this.mnuAddBook_Click);
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
            // mnuOrders
            // 
            this.mnuOrders.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createOrderToolStripMenuItem,
            this.cancelToolStripMenuItem,
            this.cancelOrderToolStripMenuItem});
            this.mnuOrders.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuOrders.ForeColor = System.Drawing.Color.LightGray;
            this.mnuOrders.Name = "mnuOrders";
            this.mnuOrders.Size = new System.Drawing.Size(53, 20);
            this.mnuOrders.Text = "Orders";
            // 
            // createOrderToolStripMenuItem
            // 
            this.createOrderToolStripMenuItem.Name = "createOrderToolStripMenuItem";
            this.createOrderToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.createOrderToolStripMenuItem.Text = "Create Order";
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            this.cancelToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.cancelToolStripMenuItem.Text = "Cancel Order";
            // 
            // cancelOrderToolStripMenuItem
            // 
            this.cancelOrderToolStripMenuItem.Name = "cancelOrderToolStripMenuItem";
            this.cancelOrderToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.cancelOrderToolStripMenuItem.Text = "View Order";
            // 
            // mnuExit
            // 
            this.mnuExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuExit.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuExit.ForeColor = System.Drawing.Color.LightGray;
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(41, 20);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuAdmin
            // 
            this.mnuAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listBestsellersToolStripMenuItem,
            this.listBestsellersToolStripMenuItem1});
            this.mnuAdmin.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuAdmin.ForeColor = System.Drawing.Color.LightGray;
            this.mnuAdmin.Name = "mnuAdmin";
            this.mnuAdmin.Size = new System.Drawing.Size(47, 20);
            this.mnuAdmin.Text = "Admin";
            this.mnuAdmin.Click += new System.EventHandler(this.mnuAdmin_Click);
            // 
            // listBestsellersToolStripMenuItem
            // 
            this.listBestsellersToolStripMenuItem.Name = "listBestsellersToolStripMenuItem";
            this.listBestsellersToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.listBestsellersToolStripMenuItem.Text = "Show Yearly Revenue Analysis";
            this.listBestsellersToolStripMenuItem.Click += new System.EventHandler(this.listBestsellersToolStripMenuItem_Click);
            // 
            // listBestsellersToolStripMenuItem1
            // 
            this.listBestsellersToolStripMenuItem1.Name = "listBestsellersToolStripMenuItem1";
            this.listBestsellersToolStripMenuItem1.Size = new System.Drawing.Size(238, 22);
            this.listBestsellersToolStripMenuItem1.Text = "List Bestsellers";
            this.listBestsellersToolStripMenuItem1.Click += new System.EventHandler(this.listBestsellersToolStripMenuItem1_Click);
            // 
            // lblBooktopia
            // 
            this.lblBooktopia.AutoSize = true;
            this.lblBooktopia.BackColor = System.Drawing.Color.Transparent;
            this.lblBooktopia.Font = new System.Drawing.Font("MS Gothic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBooktopia.ForeColor = System.Drawing.Color.White;
            this.lblBooktopia.Location = new System.Drawing.Point(185, 35);
            this.lblBooktopia.Name = "lblBooktopia";
            this.lblBooktopia.Size = new System.Drawing.Size(245, 48);
            this.lblBooktopia.TabIndex = 3;
            this.lblBooktopia.Text = "Booktopia";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(624, 321);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 345);
            this.Controls.Add(this.lblBooktopia);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mnuMainMenu);
            this.Font = new System.Drawing.Font("MS Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.mnuMainMenu;
            this.Name = "frmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.ToolStripMenuItem mnuAddBook;
        private System.Windows.Forms.ToolStripMenuItem updateBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listBestsellersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listBestsellersToolStripMenuItem1;
        private System.Windows.Forms.Label lblBooktopia;
    }
}

