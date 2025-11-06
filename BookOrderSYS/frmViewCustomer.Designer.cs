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
            this.dgvViewCustomer = new System.Windows.Forms.DataGridView();
            this.grpViewCustomer = new System.Windows.Forms.GroupBox();
            this.mnuViewCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewCustomer)).BeginInit();
            this.grpViewCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuViewCustomerBack
            // 
            this.mnuViewCustomerBack.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuViewCustomerBack.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuViewCustomerBack.ForeColor = System.Drawing.Color.LightGray;
            this.mnuViewCustomerBack.Name = "mnuViewCustomerBack";
            this.mnuViewCustomerBack.Size = new System.Drawing.Size(41, 20);
            this.mnuViewCustomerBack.Text = "Back";
            this.mnuViewCustomerBack.Click += new System.EventHandler(this.mnuViewCustomerBack_Click);
            // 
            // mnuViewCustomer
            // 
            this.mnuViewCustomer.BackColor = System.Drawing.Color.Teal;
            this.mnuViewCustomer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuViewCustomerBack});
            this.mnuViewCustomer.Location = new System.Drawing.Point(0, 0);
            this.mnuViewCustomer.Name = "mnuViewCustomer";
            this.mnuViewCustomer.Size = new System.Drawing.Size(626, 24);
            this.mnuViewCustomer.TabIndex = 1;
            // 
            // dgvViewCustomer
            // 
            this.dgvViewCustomer.AllowUserToAddRows = false;
            this.dgvViewCustomer.AllowUserToDeleteRows = false;
            this.dgvViewCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvViewCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewCustomer.Location = new System.Drawing.Point(19, 21);
            this.dgvViewCustomer.Name = "dgvViewCustomer";
            this.dgvViewCustomer.ReadOnly = true;
            this.dgvViewCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvViewCustomer.Size = new System.Drawing.Size(535, 323);
            this.dgvViewCustomer.TabIndex = 0;
            this.dgvViewCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvViewCustomer_CellContentClick);
            // 
            // grpViewCustomer
            // 
            this.grpViewCustomer.Controls.Add(this.dgvViewCustomer);
            this.grpViewCustomer.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpViewCustomer.Location = new System.Drawing.Point(27, 48);
            this.grpViewCustomer.Name = "grpViewCustomer";
            this.grpViewCustomer.Size = new System.Drawing.Size(572, 361);
            this.grpViewCustomer.TabIndex = 0;
            this.grpViewCustomer.TabStop = false;
            this.grpViewCustomer.Text = "Customer Details";
            // 
            // frmViewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(626, 434);
            this.Controls.Add(this.grpViewCustomer);
            this.Controls.Add(this.mnuViewCustomer);
            this.MainMenuStrip = this.mnuViewCustomer;
            this.Name = "frmViewCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Booktopia - [View Customer]";
            this.Load += new System.EventHandler(this.frmViewCustomer_Load);
            this.mnuViewCustomer.ResumeLayout(false);
            this.mnuViewCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewCustomer)).EndInit();
            this.grpViewCustomer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem mnuViewCustomerBack;
        private System.Windows.Forms.MenuStrip mnuViewCustomer;
        private System.Windows.Forms.DataGridView dgvViewCustomer;
        private System.Windows.Forms.GroupBox grpViewCustomer;
    }
}