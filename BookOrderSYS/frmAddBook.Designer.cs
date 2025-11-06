namespace BookOrderSYS
{
    partial class frmAddBook
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
            this.grpAddBook = new System.Windows.Forms.GroupBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.mnuAddBook = new System.Windows.Forms.MenuStrip();
            this.mnuAddBookBack = new System.Windows.Forms.ToolStripMenuItem();
            this.lblAddBook = new System.Windows.Forms.Label();
            this.grpAddBook.SuspendLayout();
            this.mnuAddBook.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAddBook
            // 
            this.grpAddBook.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grpAddBook.Controls.Add(this.txtStock);
            this.grpAddBook.Controls.Add(this.txtPrice);
            this.grpAddBook.Controls.Add(this.txtAuthor);
            this.grpAddBook.Controls.Add(this.txtTitle);
            this.grpAddBook.Controls.Add(this.btnAddBook);
            this.grpAddBook.Controls.Add(this.lblStock);
            this.grpAddBook.Controls.Add(this.lblPrice);
            this.grpAddBook.Controls.Add(this.lblAuthor);
            this.grpAddBook.Controls.Add(this.lblTitle);
            this.grpAddBook.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAddBook.Location = new System.Drawing.Point(52, 89);
            this.grpAddBook.Name = "grpAddBook";
            this.grpAddBook.Size = new System.Drawing.Size(473, 367);
            this.grpAddBook.TabIndex = 0;
            this.grpAddBook.TabStop = false;
            this.grpAddBook.Text = "Enter Details";
            // 
            // txtStock
            // 
            this.txtStock.ForeColor = System.Drawing.Color.Black;
            this.txtStock.Location = new System.Drawing.Point(149, 239);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(75, 20);
            this.txtStock.TabIndex = 8;
            // 
            // txtPrice
            // 
            this.txtPrice.ForeColor = System.Drawing.Color.Black;
            this.txtPrice.Location = new System.Drawing.Point(149, 183);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(75, 20);
            this.txtPrice.TabIndex = 7;
            // 
            // txtAuthor
            // 
            this.txtAuthor.ForeColor = System.Drawing.Color.Black;
            this.txtAuthor.Location = new System.Drawing.Point(149, 131);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(199, 20);
            this.txtAuthor.TabIndex = 6;
            // 
            // txtTitle
            // 
            this.txtTitle.ForeColor = System.Drawing.Color.Black;
            this.txtTitle.Location = new System.Drawing.Point(149, 73);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(199, 20);
            this.txtTitle.TabIndex = 5;
            // 
            // btnAddBook
            // 
            this.btnAddBook.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBook.ForeColor = System.Drawing.Color.LightGray;
            this.btnAddBook.Location = new System.Drawing.Point(180, 292);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(85, 27);
            this.btnAddBook.TabIndex = 4;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = false;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(146, 223);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(70, 13);
            this.lblStock.TabIndex = 3;
            this.lblStock.Text = "Stock Qty";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(146, 167);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(42, 13);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Price";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(146, 115);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(49, 13);
            this.lblAuthor.TabIndex = 1;
            this.lblAuthor.Text = "Author";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(146, 57);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(42, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            // 
            // mnuAddBook
            // 
            this.mnuAddBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.mnuAddBook.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddBookBack});
            this.mnuAddBook.Location = new System.Drawing.Point(0, 0);
            this.mnuAddBook.Name = "mnuAddBook";
            this.mnuAddBook.Size = new System.Drawing.Size(575, 24);
            this.mnuAddBook.TabIndex = 1;
            // 
            // mnuAddBookBack
            // 
            this.mnuAddBookBack.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuAddBookBack.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuAddBookBack.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.mnuAddBookBack.Name = "mnuAddBookBack";
            this.mnuAddBookBack.Size = new System.Drawing.Size(41, 20);
            this.mnuAddBookBack.Text = "Back";
            this.mnuAddBookBack.Click += new System.EventHandler(this.mnuAddBookBack_Click);
            // 
            // lblAddBook
            // 
            this.lblAddBook.AutoSize = true;
            this.lblAddBook.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddBook.Location = new System.Drawing.Point(228, 51);
            this.lblAddBook.Name = "lblAddBook";
            this.lblAddBook.Size = new System.Drawing.Size(97, 19);
            this.lblAddBook.TabIndex = 0;
            this.lblAddBook.Text = "Add Book";
            // 
            // frmAddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(575, 484);
            this.Controls.Add(this.lblAddBook);
            this.Controls.Add(this.grpAddBook);
            this.Controls.Add(this.mnuAddBook);
            this.MainMenuStrip = this.mnuAddBook;
            this.Name = "frmAddBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Booktopia - [Add Book]";
            this.Load += new System.EventHandler(this.frmAddBook_Load);
            this.grpAddBook.ResumeLayout(false);
            this.grpAddBook.PerformLayout();
            this.mnuAddBook.ResumeLayout(false);
            this.mnuAddBook.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAddBook;
        private System.Windows.Forms.MenuStrip mnuAddBook;
        private System.Windows.Forms.ToolStripMenuItem mnuAddBookBack;
        private System.Windows.Forms.Label lblAddBook;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtTitle;
    }
}