namespace BookOrderSYS
{
    partial class frmUpdateBook
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
            this.lblUpdateBook = new System.Windows.Forms.Label();
            this.btnUpdateBook = new System.Windows.Forms.Button();
            this.grpUpdateBook = new System.Windows.Forms.GroupBox();
            this.mnuUpdateBook = new System.Windows.Forms.MenuStrip();
            this.mnuUpdateBookBack = new System.Windows.Forms.ToolStripMenuItem();
            this.grpUpdateBook.SuspendLayout();
            this.mnuUpdateBook.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUpdateBook
            // 
            this.lblUpdateBook.AutoSize = true;
            this.lblUpdateBook.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateBook.Location = new System.Drawing.Point(209, 51);
            this.lblUpdateBook.Name = "lblUpdateBook";
            this.lblUpdateBook.Size = new System.Drawing.Size(130, 19);
            this.lblUpdateBook.TabIndex = 1;
            this.lblUpdateBook.Text = "Update Book";
            // 
            // btnUpdateBook
            // 
            this.btnUpdateBook.BackColor = System.Drawing.Color.Teal;
            this.btnUpdateBook.ForeColor = System.Drawing.Color.LightGray;
            this.btnUpdateBook.Location = new System.Drawing.Point(180, 265);
            this.btnUpdateBook.Name = "btnUpdateBook";
            this.btnUpdateBook.Size = new System.Drawing.Size(85, 27);
            this.btnUpdateBook.TabIndex = 5;
            this.btnUpdateBook.Text = "Update Book";
            this.btnUpdateBook.UseVisualStyleBackColor = false;
            // 
            // grpUpdateBook
            // 
            this.grpUpdateBook.Controls.Add(this.btnUpdateBook);
            this.grpUpdateBook.Location = new System.Drawing.Point(50, 89);
            this.grpUpdateBook.Name = "grpUpdateBook";
            this.grpUpdateBook.Size = new System.Drawing.Size(473, 332);
            this.grpUpdateBook.TabIndex = 6;
            this.grpUpdateBook.TabStop = false;
            this.grpUpdateBook.Text = "Enter Details";
            // 
            // mnuUpdateBook
            // 
            this.mnuUpdateBook.BackColor = System.Drawing.Color.Teal;
            this.mnuUpdateBook.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuUpdateBook.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUpdateBookBack});
            this.mnuUpdateBook.Location = new System.Drawing.Point(0, 0);
            this.mnuUpdateBook.Name = "mnuUpdateBook";
            this.mnuUpdateBook.Size = new System.Drawing.Size(575, 24);
            this.mnuUpdateBook.TabIndex = 7;
            // 
            // mnuUpdateBookBack
            // 
            this.mnuUpdateBookBack.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuUpdateBookBack.ForeColor = System.Drawing.Color.LightGray;
            this.mnuUpdateBookBack.Name = "mnuUpdateBookBack";
            this.mnuUpdateBookBack.Size = new System.Drawing.Size(41, 20);
            this.mnuUpdateBookBack.Text = "Back";
            this.mnuUpdateBookBack.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // frmUpdateBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(575, 448);
            this.Controls.Add(this.grpUpdateBook);
            this.Controls.Add(this.lblUpdateBook);
            this.Controls.Add(this.mnuUpdateBook);
            this.MainMenuStrip = this.mnuUpdateBook;
            this.Name = "frmUpdateBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Booktopia - [Update Book]";
            this.grpUpdateBook.ResumeLayout(false);
            this.mnuUpdateBook.ResumeLayout(false);
            this.mnuUpdateBook.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUpdateBook;
        private System.Windows.Forms.Button btnUpdateBook;
        private System.Windows.Forms.GroupBox grpUpdateBook;
        private System.Windows.Forms.MenuStrip mnuUpdateBook;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateBookBack;
    }
}