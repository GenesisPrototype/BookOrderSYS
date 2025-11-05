namespace BookOrderSYS
{
    partial class frmRegisterCustomer
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
            this.grpRegisterCustomer = new System.Windows.Forms.GroupBox();
            this.lblForename = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.grpRegisterCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpRegisterCustomer
            // 
            this.grpRegisterCustomer.Controls.Add(this.lblSurname);
            this.grpRegisterCustomer.Controls.Add(this.lblEmail);
            this.grpRegisterCustomer.Controls.Add(this.lblForename);
            this.grpRegisterCustomer.Location = new System.Drawing.Point(27, 48);
            this.grpRegisterCustomer.Name = "grpRegisterCustomer";
            this.grpRegisterCustomer.Size = new System.Drawing.Size(525, 323);
            this.grpRegisterCustomer.TabIndex = 0;
            this.grpRegisterCustomer.TabStop = false;
            this.grpRegisterCustomer.Text = "Register Customer Details";
            // 
            // lblForename
            // 
            this.lblForename.AutoSize = true;
            this.lblForename.Location = new System.Drawing.Point(46, 39);
            this.lblForename.Name = "lblForename";
            this.lblForename.Size = new System.Drawing.Size(57, 13);
            this.lblForename.TabIndex = 0;
            this.lblForename.Text = "Forename ";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(46, 117);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email";
            this.lblEmail.Click += new System.EventHandler(this.lblEmail_Click);
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(259, 39);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(49, 13);
            this.lblSurname.TabIndex = 2;
            this.lblSurname.Text = "Surname";
            // 
            // frmRegisterCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(576, 404);
            this.Controls.Add(this.grpRegisterCustomer);
            this.Name = "frmRegisterCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Booktopia - [Register Customer]";
            this.grpRegisterCustomer.ResumeLayout(false);
            this.grpRegisterCustomer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpRegisterCustomer;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblForename;
        private System.Windows.Forms.Label lblSurname;
    }
}