namespace BookOrderSYS
{
    partial class frmViewCustomer
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
            this.mnuViewCustomerBack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewCustomer = new System.Windows.Forms.MenuStrip();
            this.lblViewCustomer = new System.Windows.Forms.Label();
            this.lblViewCustomerInstuction = new System.Windows.Forms.Label();
            this.lblViewCustomerID = new System.Windows.Forms.Label();
            this.txtViewCustomer = new System.Windows.Forms.TextBox();
            this.btnViewCustomer = new System.Windows.Forms.Button();
            this.mnuViewCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuViewCustomerBack
            // 
            this.mnuViewCustomerBack.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuViewCustomerBack.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuViewCustomerBack.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.mnuViewCustomerBack.Name = "mnuViewCustomerBack";
            this.mnuViewCustomerBack.Size = new System.Drawing.Size(41, 20);
            this.mnuViewCustomerBack.Text = "Back";
            this.mnuViewCustomerBack.Click += new System.EventHandler(this.mnuViewCustomerBack_Click);
            // 
            // mnuViewCustomer
            // 
            this.mnuViewCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.mnuViewCustomer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuViewCustomerBack});
            this.mnuViewCustomer.Location = new System.Drawing.Point(0, 0);
            this.mnuViewCustomer.Name = "mnuViewCustomer";
            this.mnuViewCustomer.Size = new System.Drawing.Size(569, 24);
            this.mnuViewCustomer.TabIndex = 1;
            // 
            // lblViewCustomer
            // 
            this.lblViewCustomer.AutoSize = true;
            this.lblViewCustomer.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewCustomer.Location = new System.Drawing.Point(199, 47);
            this.lblViewCustomer.Name = "lblViewCustomer";
            this.lblViewCustomer.Size = new System.Drawing.Size(152, 19);
            this.lblViewCustomer.TabIndex = 2;
            this.lblViewCustomer.Text = "View Customer";
            // 
            // lblViewCustomerInstuction
            // 
            this.lblViewCustomerInstuction.AutoSize = true;
            this.lblViewCustomerInstuction.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewCustomerInstuction.Location = new System.Drawing.Point(90, 78);
            this.lblViewCustomerInstuction.Name = "lblViewCustomerInstuction";
            this.lblViewCustomerInstuction.Size = new System.Drawing.Size(378, 13);
            this.lblViewCustomerInstuction.TabIndex = 4;
            this.lblViewCustomerInstuction.Text = "Enter the Customer ID to view the customer\'s details.";
            // 
            // lblViewCustomerID
            // 
            this.lblViewCustomerID.AutoSize = true;
            this.lblViewCustomerID.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewCustomerID.Location = new System.Drawing.Point(174, 148);
            this.lblViewCustomerID.Name = "lblViewCustomerID";
            this.lblViewCustomerID.Size = new System.Drawing.Size(84, 13);
            this.lblViewCustomerID.TabIndex = 5;
            this.lblViewCustomerID.Text = "Customer ID";
            // 
            // txtViewCustomer
            // 
            this.txtViewCustomer.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtViewCustomer.Location = new System.Drawing.Point(264, 145);
            this.txtViewCustomer.Name = "txtViewCustomer";
            this.txtViewCustomer.Size = new System.Drawing.Size(70, 20);
            this.txtViewCustomer.TabIndex = 6;
            // 
            // btnViewCustomer
            // 
            this.btnViewCustomer.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnViewCustomer.ForeColor = System.Drawing.Color.LightGray;
            this.btnViewCustomer.Location = new System.Drawing.Point(220, 181);
            this.btnViewCustomer.Name = "btnViewCustomer";
            this.btnViewCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnViewCustomer.TabIndex = 7;
            this.btnViewCustomer.Text = "View";
            this.btnViewCustomer.UseVisualStyleBackColor = false;
            // 
            // frmViewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(569, 445);
            this.Controls.Add(this.btnViewCustomer);
            this.Controls.Add(this.txtViewCustomer);
            this.Controls.Add(this.lblViewCustomerID);
            this.Controls.Add(this.lblViewCustomerInstuction);
            this.Controls.Add(this.lblViewCustomer);
            this.Controls.Add(this.mnuViewCustomer);
            this.MainMenuStrip = this.mnuViewCustomer;
            this.Name = "frmViewCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Booktopia - [View Customer]";
            this.Load += new System.EventHandler(this.frmViewCustomer_Load);
            this.mnuViewCustomer.ResumeLayout(false);
            this.mnuViewCustomer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem mnuViewCustomerBack;
        private System.Windows.Forms.MenuStrip mnuViewCustomer;
        private System.Windows.Forms.Label lblViewCustomer;
        private System.Windows.Forms.Label lblViewCustomerInstuction;
        private System.Windows.Forms.Label lblViewCustomerID;
        private System.Windows.Forms.TextBox txtViewCustomer;
        private System.Windows.Forms.Button btnViewCustomer;
    }
}