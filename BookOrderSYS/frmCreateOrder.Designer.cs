namespace BookOrderSYS
{
    partial class frmCreateOrder
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
            this.components = new System.ComponentModel.Container();
            this.mnuCreateOrder = new System.Windows.Forms.MenuStrip();
            this.mnuCreateOrderBack = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblCreateOrder = new System.Windows.Forms.Label();
            this.lblSelectCustomer = new System.Windows.Forms.Label();
            this.cboSelectCustomer = new System.Windows.Forms.ComboBox();
            this.lblSelectBook = new System.Windows.Forms.Label();
            this.cboSelectBook = new System.Windows.Forms.ComboBox();
            this.lblCreateOrderQty = new System.Windows.Forms.Label();
            this.txtCreateOrderQty = new System.Windows.Forms.TextBox();
            this.grpCreateOrder = new System.Windows.Forms.GroupBox();
            this.btnCreateOrder = new System.Windows.Forms.Button();
            this.mnuCreateOrder.SuspendLayout();
            this.grpCreateOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuCreateOrder
            // 
            this.mnuCreateOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.mnuCreateOrder.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCreateOrderBack});
            this.mnuCreateOrder.Location = new System.Drawing.Point(0, 0);
            this.mnuCreateOrder.Name = "mnuCreateOrder";
            this.mnuCreateOrder.Size = new System.Drawing.Size(585, 24);
            this.mnuCreateOrder.TabIndex = 0;
            // 
            // mnuCreateOrderBack
            // 
            this.mnuCreateOrderBack.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuCreateOrderBack.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.mnuCreateOrderBack.Name = "mnuCreateOrderBack";
            this.mnuCreateOrderBack.Size = new System.Drawing.Size(44, 20);
            this.mnuCreateOrderBack.Text = "Back";
            this.mnuCreateOrderBack.Click += new System.EventHandler(this.mnuCreateOrderBack_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lblCreateOrder
            // 
            this.lblCreateOrder.AutoSize = true;
            this.lblCreateOrder.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateOrder.Location = new System.Drawing.Point(218, 55);
            this.lblCreateOrder.Name = "lblCreateOrder";
            this.lblCreateOrder.Size = new System.Drawing.Size(141, 19);
            this.lblCreateOrder.TabIndex = 2;
            this.lblCreateOrder.Text = "Create Order";
            // 
            // lblSelectCustomer
            // 
            this.lblSelectCustomer.AutoSize = true;
            this.lblSelectCustomer.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectCustomer.Location = new System.Drawing.Point(113, 50);
            this.lblSelectCustomer.Name = "lblSelectCustomer";
            this.lblSelectCustomer.Size = new System.Drawing.Size(112, 13);
            this.lblSelectCustomer.TabIndex = 3;
            this.lblSelectCustomer.Text = "Select Customer";
            // 
            // cboSelectCustomer
            // 
            this.cboSelectCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSelectCustomer.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSelectCustomer.FormattingEnabled = true;
            this.cboSelectCustomer.Items.AddRange(new object[] {
            "Alfred Jones",
            "Miles Prower",
            "Anne Onymous",
            "Justin Case"});
            this.cboSelectCustomer.Location = new System.Drawing.Point(250, 47);
            this.cboSelectCustomer.Name = "cboSelectCustomer";
            this.cboSelectCustomer.Size = new System.Drawing.Size(136, 21);
            this.cboSelectCustomer.TabIndex = 4;
            // 
            // lblSelectBook
            // 
            this.lblSelectBook.AutoSize = true;
            this.lblSelectBook.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectBook.Location = new System.Drawing.Point(113, 89);
            this.lblSelectBook.Name = "lblSelectBook";
            this.lblSelectBook.Size = new System.Drawing.Size(84, 13);
            this.lblSelectBook.TabIndex = 5;
            this.lblSelectBook.Text = "Select Book";
            // 
            // cboSelectBook
            // 
            this.cboSelectBook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSelectBook.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSelectBook.FormattingEnabled = true;
            this.cboSelectBook.Items.AddRange(new object[] {
            "We\'ll Meet Again",
            "Solaris",
            "1984",
            "The Outsiders",
            "The Bell Jar",
            "Dante\'s Inferno"});
            this.cboSelectBook.Location = new System.Drawing.Point(250, 86);
            this.cboSelectBook.Name = "cboSelectBook";
            this.cboSelectBook.Size = new System.Drawing.Size(136, 21);
            this.cboSelectBook.TabIndex = 6;
            // 
            // lblCreateOrderQty
            // 
            this.lblCreateOrderQty.AutoSize = true;
            this.lblCreateOrderQty.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateOrderQty.Location = new System.Drawing.Point(113, 127);
            this.lblCreateOrderQty.Name = "lblCreateOrderQty";
            this.lblCreateOrderQty.Size = new System.Drawing.Size(28, 13);
            this.lblCreateOrderQty.TabIndex = 7;
            this.lblCreateOrderQty.Text = "Qty";
            // 
            // txtCreateOrderQty
            // 
            this.txtCreateOrderQty.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreateOrderQty.Location = new System.Drawing.Point(250, 124);
            this.txtCreateOrderQty.Name = "txtCreateOrderQty";
            this.txtCreateOrderQty.Size = new System.Drawing.Size(46, 20);
            this.txtCreateOrderQty.TabIndex = 8;
            // 
            // grpCreateOrder
            // 
            this.grpCreateOrder.Controls.Add(this.btnCreateOrder);
            this.grpCreateOrder.Controls.Add(this.txtCreateOrderQty);
            this.grpCreateOrder.Controls.Add(this.cboSelectCustomer);
            this.grpCreateOrder.Controls.Add(this.cboSelectBook);
            this.grpCreateOrder.Controls.Add(this.lblCreateOrderQty);
            this.grpCreateOrder.Controls.Add(this.lblSelectBook);
            this.grpCreateOrder.Controls.Add(this.lblSelectCustomer);
            this.grpCreateOrder.Location = new System.Drawing.Point(40, 92);
            this.grpCreateOrder.Name = "grpCreateOrder";
            this.grpCreateOrder.Size = new System.Drawing.Size(508, 299);
            this.grpCreateOrder.TabIndex = 9;
            this.grpCreateOrder.TabStop = false;
            this.grpCreateOrder.Text = "Enter Details";
            // 
            // btnCreateOrder
            // 
            this.btnCreateOrder.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCreateOrder.ForeColor = System.Drawing.Color.LightGray;
            this.btnCreateOrder.Location = new System.Drawing.Point(207, 210);
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.Size = new System.Drawing.Size(75, 23);
            this.btnCreateOrder.TabIndex = 9;
            this.btnCreateOrder.Text = "Create Order";
            this.btnCreateOrder.UseVisualStyleBackColor = false;
            this.btnCreateOrder.Click += new System.EventHandler(this.btnCreateOrder_Click);
            // 
            // frmCreateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(585, 426);
            this.Controls.Add(this.grpCreateOrder);
            this.Controls.Add(this.lblCreateOrder);
            this.Controls.Add(this.mnuCreateOrder);
            this.MainMenuStrip = this.mnuCreateOrder;
            this.Name = "frmCreateOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Booktopia - [Create Order]";
            this.mnuCreateOrder.ResumeLayout(false);
            this.mnuCreateOrder.PerformLayout();
            this.grpCreateOrder.ResumeLayout(false);
            this.grpCreateOrder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuCreateOrder;
        private System.Windows.Forms.ToolStripMenuItem mnuCreateOrderBack;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblCreateOrder;
        private System.Windows.Forms.Label lblSelectCustomer;
        private System.Windows.Forms.ComboBox cboSelectCustomer;
        private System.Windows.Forms.Label lblSelectBook;
        private System.Windows.Forms.ComboBox cboSelectBook;
        private System.Windows.Forms.Label lblCreateOrderQty;
        private System.Windows.Forms.TextBox txtCreateOrderQty;
        private System.Windows.Forms.GroupBox grpCreateOrder;
        private System.Windows.Forms.Button btnCreateOrder;
    }
}