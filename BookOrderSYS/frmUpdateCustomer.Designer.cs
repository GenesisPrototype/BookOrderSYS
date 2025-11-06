namespace BookOrderSYS
{
    partial class frmUpdateCustomer
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
            this.mnuUpdateCustomer = new System.Windows.Forms.MenuStrip();
            this.mnuUpdateCustomerBack = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUpdateCustomer = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblOrdersPlaced = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtOrders = new System.Windows.Forms.TextBox();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.mnuUpdateCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuUpdateCustomer
            // 
            this.mnuUpdateCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.mnuUpdateCustomer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUpdateCustomerBack});
            this.mnuUpdateCustomer.Location = new System.Drawing.Point(0, 0);
            this.mnuUpdateCustomer.Name = "mnuUpdateCustomer";
            this.mnuUpdateCustomer.Size = new System.Drawing.Size(646, 24);
            this.mnuUpdateCustomer.TabIndex = 0;
            // 
            // mnuUpdateCustomerBack
            // 
            this.mnuUpdateCustomerBack.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuUpdateCustomerBack.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.mnuUpdateCustomerBack.Name = "mnuUpdateCustomerBack";
            this.mnuUpdateCustomerBack.Size = new System.Drawing.Size(44, 20);
            this.mnuUpdateCustomerBack.Text = "Back";
            this.mnuUpdateCustomerBack.Click += new System.EventHandler(this.mnuUpdateCustomerBack_Click);
            // 
            // lblUpdateCustomer
            // 
            this.lblUpdateCustomer.AutoSize = true;
            this.lblUpdateCustomer.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateCustomer.Location = new System.Drawing.Point(185, 43);
            this.lblUpdateCustomer.Name = "lblUpdateCustomer";
            this.lblUpdateCustomer.Size = new System.Drawing.Size(262, 19);
            this.lblUpdateCustomer.TabIndex = 1;
            this.lblUpdateCustomer.Text = "Update Customer Details";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(230, 149);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 13);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "ID";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(230, 197);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(230, 253);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 13);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(230, 307);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(42, 13);
            this.lblPhone.TabIndex = 5;
            this.lblPhone.Text = "Phone";
            // 
            // lblOrdersPlaced
            // 
            this.lblOrdersPlaced.AutoSize = true;
            this.lblOrdersPlaced.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdersPlaced.Location = new System.Drawing.Point(229, 362);
            this.lblOrdersPlaced.Name = "lblOrdersPlaced";
            this.lblOrdersPlaced.Size = new System.Drawing.Size(98, 13);
            this.lblOrdersPlaced.TabIndex = 6;
            this.lblOrdersPlaced.Text = "Orders Placed";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(232, 165);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(46, 20);
            this.txtID.TabIndex = 7;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(232, 213);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(158, 20);
            this.txtName.TabIndex = 8;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(232, 269);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(158, 20);
            this.txtEmail.TabIndex = 9;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(232, 323);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(158, 20);
            this.txtPhone.TabIndex = 10;
            // 
            // txtOrders
            // 
            this.txtOrders.Location = new System.Drawing.Point(232, 378);
            this.txtOrders.Name = "txtOrders";
            this.txtOrders.Size = new System.Drawing.Size(45, 20);
            this.txtOrders.TabIndex = 11;
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction.Location = new System.Drawing.Point(100, 73);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(467, 12);
            this.lblInstruction.TabIndex = 12;
            this.lblInstruction.Text = "Enter the ID of the customer to be updated, in order to change their details.\r\n";
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnUpdateCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCustomer.ForeColor = System.Drawing.Color.LightGray;
            this.btnUpdateCustomer.Location = new System.Drawing.Point(270, 439);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(80, 27);
            this.btnUpdateCustomer.TabIndex = 13;
            this.btnUpdateCustomer.Text = "Update";
            this.btnUpdateCustomer.UseVisualStyleBackColor = false;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
            // 
            // frmUpdateCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(646, 517);
            this.Controls.Add(this.btnUpdateCustomer);
            this.Controls.Add(this.lblInstruction);
            this.Controls.Add(this.txtOrders);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblOrdersPlaced);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblUpdateCustomer);
            this.Controls.Add(this.mnuUpdateCustomer);
            this.MainMenuStrip = this.mnuUpdateCustomer;
            this.Name = "frmUpdateCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Booktopia - [Update Customer]";
            this.Load += new System.EventHandler(this.frmUpdateCustomer_Load);
            this.mnuUpdateCustomer.ResumeLayout(false);
            this.mnuUpdateCustomer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuUpdateCustomer;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateCustomerBack;
        private System.Windows.Forms.Label lblUpdateCustomer;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblOrdersPlaced;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtOrders;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.Button btnUpdateCustomer;
    }
}