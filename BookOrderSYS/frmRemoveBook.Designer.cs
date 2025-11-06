namespace BookOrderSYS
{
    partial class frmRemoveBook
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
            this.mnuRemoveBook = new System.Windows.Forms.MenuStrip();
            this.mnuRemoveBack = new System.Windows.Forms.ToolStripMenuItem();
            this.lblRemoveBook = new System.Windows.Forms.Label();
            this.lblRemoveBookInstruction = new System.Windows.Forms.Label();
            this.lblRemoveBookID = new System.Windows.Forms.Label();
            this.txtRemoveBookID = new System.Windows.Forms.TextBox();
            this.btnRemoveBook = new System.Windows.Forms.Button();
            this.mnuRemoveBook.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuRemoveBook
            // 
            this.mnuRemoveBook.BackColor = System.Drawing.Color.Teal;
            this.mnuRemoveBook.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRemoveBack});
            this.mnuRemoveBook.Location = new System.Drawing.Point(0, 0);
            this.mnuRemoveBook.Name = "mnuRemoveBook";
            this.mnuRemoveBook.Size = new System.Drawing.Size(496, 24);
            this.mnuRemoveBook.TabIndex = 0;
            // 
            // mnuRemoveBack
            // 
            this.mnuRemoveBack.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuRemoveBack.ForeColor = System.Drawing.Color.LightGray;
            this.mnuRemoveBack.Name = "mnuRemoveBack";
            this.mnuRemoveBack.Size = new System.Drawing.Size(44, 20);
            this.mnuRemoveBack.Text = "Back";
            this.mnuRemoveBack.Click += new System.EventHandler(this.mnuRemoveBack_Click);
            // 
            // lblRemoveBook
            // 
            this.lblRemoveBook.AutoSize = true;
            this.lblRemoveBook.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemoveBook.Location = new System.Drawing.Point(178, 48);
            this.lblRemoveBook.Name = "lblRemoveBook";
            this.lblRemoveBook.Size = new System.Drawing.Size(130, 19);
            this.lblRemoveBook.TabIndex = 1;
            this.lblRemoveBook.Text = "Remove Book";
            // 
            // lblRemoveBookInstruction
            // 
            this.lblRemoveBookInstruction.AutoSize = true;
            this.lblRemoveBookInstruction.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemoveBookInstruction.Location = new System.Drawing.Point(134, 79);
            this.lblRemoveBookInstruction.Name = "lblRemoveBookInstruction";
            this.lblRemoveBookInstruction.Size = new System.Drawing.Size(239, 12);
            this.lblRemoveBookInstruction.TabIndex = 2;
            this.lblRemoveBookInstruction.Text = "Enter the ID of the book to be removed.\r\n";
            // 
            // lblRemoveBookID
            // 
            this.lblRemoveBookID.AutoSize = true;
            this.lblRemoveBookID.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemoveBookID.Location = new System.Drawing.Point(159, 167);
            this.lblRemoveBookID.Name = "lblRemoveBookID";
            this.lblRemoveBookID.Size = new System.Drawing.Size(56, 13);
            this.lblRemoveBookID.TabIndex = 3;
            this.lblRemoveBookID.Text = "Book ID";
            // 
            // txtRemoveBookID
            // 
            this.txtRemoveBookID.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemoveBookID.Location = new System.Drawing.Point(221, 164);
            this.txtRemoveBookID.Name = "txtRemoveBookID";
            this.txtRemoveBookID.Size = new System.Drawing.Size(100, 20);
            this.txtRemoveBookID.TabIndex = 4;
            // 
            // btnRemoveBook
            // 
            this.btnRemoveBook.BackColor = System.Drawing.Color.Teal;
            this.btnRemoveBook.ForeColor = System.Drawing.Color.LightGray;
            this.btnRemoveBook.Location = new System.Drawing.Point(207, 238);
            this.btnRemoveBook.Name = "btnRemoveBook";
            this.btnRemoveBook.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveBook.TabIndex = 5;
            this.btnRemoveBook.Text = "Remove";
            this.btnRemoveBook.UseVisualStyleBackColor = false;
            this.btnRemoveBook.Click += new System.EventHandler(this.btnRemoveBook_Click);
            // 
            // frmRemoveBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(496, 305);
            this.Controls.Add(this.btnRemoveBook);
            this.Controls.Add(this.txtRemoveBookID);
            this.Controls.Add(this.lblRemoveBookID);
            this.Controls.Add(this.lblRemoveBookInstruction);
            this.Controls.Add(this.lblRemoveBook);
            this.Controls.Add(this.mnuRemoveBook);
            this.MainMenuStrip = this.mnuRemoveBook;
            this.Name = "frmRemoveBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Booktopia - [Remove Book]";
            this.mnuRemoveBook.ResumeLayout(false);
            this.mnuRemoveBook.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuRemoveBook;
        private System.Windows.Forms.ToolStripMenuItem mnuRemoveBack;
        private System.Windows.Forms.Label lblRemoveBook;
        private System.Windows.Forms.Label lblRemoveBookInstruction;
        private System.Windows.Forms.Label lblRemoveBookID;
        private System.Windows.Forms.TextBox txtRemoveBookID;
        private System.Windows.Forms.Button btnRemoveBook;
    }
}