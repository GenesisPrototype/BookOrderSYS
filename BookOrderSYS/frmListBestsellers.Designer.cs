namespace BookOrderSYS
{
    partial class frmListBestsellers
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
            this.lblListBestsellers = new System.Windows.Forms.Label();
            this.listBoxListBestsellers = new System.Windows.Forms.ListBox();
            this.mnuListBestsellers = new System.Windows.Forms.MenuStrip();
            this.mnuListBestsellersBack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuListBestsellers.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblListBestsellers
            // 
            this.lblListBestsellers.AutoSize = true;
            this.lblListBestsellers.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListBestsellers.Location = new System.Drawing.Point(151, 59);
            this.lblListBestsellers.Name = "lblListBestsellers";
            this.lblListBestsellers.Size = new System.Drawing.Size(334, 21);
            this.lblListBestsellers.TabIndex = 0;
            this.lblListBestsellers.Text = "List of Top 10 Bestsellers:";
            // 
            // listBoxListBestsellers
            // 
            this.listBoxListBestsellers.Font = new System.Drawing.Font("MS Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxListBestsellers.FormattingEnabled = true;
            this.listBoxListBestsellers.ItemHeight = 15;
            this.listBoxListBestsellers.Location = new System.Drawing.Point(49, 95);
            this.listBoxListBestsellers.Name = "listBoxListBestsellers";
            this.listBoxListBestsellers.Size = new System.Drawing.Size(528, 304);
            this.listBoxListBestsellers.TabIndex = 1;
            // 
            // mnuListBestsellers
            // 
            this.mnuListBestsellers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.mnuListBestsellers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuListBestsellersBack});
            this.mnuListBestsellers.Location = new System.Drawing.Point(0, 0);
            this.mnuListBestsellers.Name = "mnuListBestsellers";
            this.mnuListBestsellers.Size = new System.Drawing.Size(627, 24);
            this.mnuListBestsellers.TabIndex = 2;
            this.mnuListBestsellers.Text = "menuStrip1";
            // 
            // mnuListBestsellersBack
            // 
            this.mnuListBestsellersBack.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuListBestsellersBack.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.mnuListBestsellersBack.Name = "mnuListBestsellersBack";
            this.mnuListBestsellersBack.Size = new System.Drawing.Size(44, 20);
            this.mnuListBestsellersBack.Text = "Back";
            this.mnuListBestsellersBack.Click += new System.EventHandler(this.mnuListBestsellersBack_Click);
            // 
            // frmListBestsellers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(627, 448);
            this.Controls.Add(this.listBoxListBestsellers);
            this.Controls.Add(this.lblListBestsellers);
            this.Controls.Add(this.mnuListBestsellers);
            this.MainMenuStrip = this.mnuListBestsellers;
            this.Name = "frmListBestsellers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Booktopia - [List of Bestsellers]";
            this.Load += new System.EventHandler(this.frmListBestsellers_Load);
            this.mnuListBestsellers.ResumeLayout(false);
            this.mnuListBestsellers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblListBestsellers;
        private System.Windows.Forms.ListBox listBoxListBestsellers;
        private System.Windows.Forms.MenuStrip mnuListBestsellers;
        private System.Windows.Forms.ToolStripMenuItem mnuListBestsellersBack;
    }
}