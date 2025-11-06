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
            this.mnuUpdateBook = new System.Windows.Forms.MenuStrip();
            this.mnuUpdateBookBack = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUpdatebookInstructions = new System.Windows.Forms.Label();
            this.btnUpdateBook = new System.Windows.Forms.Button();
            this.lblUpdateBookID = new System.Windows.Forms.Label();
            this.lblUpdateBookTitle = new System.Windows.Forms.Label();
            this.lblUpdateBookAuthor = new System.Windows.Forms.Label();
            this.lblUpdateBookPrice = new System.Windows.Forms.Label();
            this.lblUpdateBookStock = new System.Windows.Forms.Label();
            this.txtUpdateBookID = new System.Windows.Forms.TextBox();
            this.txtUpdateBookTitle = new System.Windows.Forms.TextBox();
            this.txtUpdateBookAuthor = new System.Windows.Forms.TextBox();
            this.txtUpdateBookPrice = new System.Windows.Forms.TextBox();
            this.txtUpdateBookStock = new System.Windows.Forms.TextBox();
            this.mnuUpdateBook.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUpdateBook
            // 
            this.lblUpdateBook.AutoSize = true;
            this.lblUpdateBook.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateBook.Location = new System.Drawing.Point(203, 48);
            this.lblUpdateBook.Name = "lblUpdateBook";
            this.lblUpdateBook.Size = new System.Drawing.Size(130, 19);
            this.lblUpdateBook.TabIndex = 1;
            this.lblUpdateBook.Text = "Update Book";
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
            // lblUpdatebookInstructions
            // 
            this.lblUpdatebookInstructions.AutoSize = true;
            this.lblUpdatebookInstructions.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdatebookInstructions.Location = new System.Drawing.Point(79, 76);
            this.lblUpdatebookInstructions.Name = "lblUpdatebookInstructions";
            this.lblUpdatebookInstructions.Size = new System.Drawing.Size(431, 12);
            this.lblUpdatebookInstructions.TabIndex = 8;
            this.lblUpdatebookInstructions.Text = "Enter the ID of the book to be updated, in order to change its details.";
            // 
            // btnUpdateBook
            // 
            this.btnUpdateBook.BackColor = System.Drawing.Color.Teal;
            this.btnUpdateBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateBook.ForeColor = System.Drawing.Color.LightGray;
            this.btnUpdateBook.Location = new System.Drawing.Point(244, 452);
            this.btnUpdateBook.Name = "btnUpdateBook";
            this.btnUpdateBook.Size = new System.Drawing.Size(80, 30);
            this.btnUpdateBook.TabIndex = 9;
            this.btnUpdateBook.Text = "Update";
            this.btnUpdateBook.UseVisualStyleBackColor = false;
            this.btnUpdateBook.Click += new System.EventHandler(this.btnUpdateBook_Click);
            // 
            // lblUpdateBookID
            // 
            this.lblUpdateBookID.AutoSize = true;
            this.lblUpdateBookID.BackColor = System.Drawing.Color.LightGray;
            this.lblUpdateBookID.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateBookID.Location = new System.Drawing.Point(204, 148);
            this.lblUpdateBookID.Name = "lblUpdateBookID";
            this.lblUpdateBookID.Size = new System.Drawing.Size(21, 13);
            this.lblUpdateBookID.TabIndex = 10;
            this.lblUpdateBookID.Text = "ID";
            // 
            // lblUpdateBookTitle
            // 
            this.lblUpdateBookTitle.AutoSize = true;
            this.lblUpdateBookTitle.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateBookTitle.Location = new System.Drawing.Point(204, 205);
            this.lblUpdateBookTitle.Name = "lblUpdateBookTitle";
            this.lblUpdateBookTitle.Size = new System.Drawing.Size(42, 13);
            this.lblUpdateBookTitle.TabIndex = 11;
            this.lblUpdateBookTitle.Text = "Title";
            // 
            // lblUpdateBookAuthor
            // 
            this.lblUpdateBookAuthor.AutoSize = true;
            this.lblUpdateBookAuthor.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateBookAuthor.Location = new System.Drawing.Point(204, 259);
            this.lblUpdateBookAuthor.Name = "lblUpdateBookAuthor";
            this.lblUpdateBookAuthor.Size = new System.Drawing.Size(49, 13);
            this.lblUpdateBookAuthor.TabIndex = 12;
            this.lblUpdateBookAuthor.Text = "Author";
            // 
            // lblUpdateBookPrice
            // 
            this.lblUpdateBookPrice.AutoSize = true;
            this.lblUpdateBookPrice.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateBookPrice.Location = new System.Drawing.Point(204, 310);
            this.lblUpdateBookPrice.Name = "lblUpdateBookPrice";
            this.lblUpdateBookPrice.Size = new System.Drawing.Size(42, 13);
            this.lblUpdateBookPrice.TabIndex = 13;
            this.lblUpdateBookPrice.Text = "Price";
            // 
            // lblUpdateBookStock
            // 
            this.lblUpdateBookStock.AutoSize = true;
            this.lblUpdateBookStock.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateBookStock.Location = new System.Drawing.Point(204, 369);
            this.lblUpdateBookStock.Name = "lblUpdateBookStock";
            this.lblUpdateBookStock.Size = new System.Drawing.Size(70, 13);
            this.lblUpdateBookStock.TabIndex = 14;
            this.lblUpdateBookStock.Text = "Stock Qty";
            // 
            // txtUpdateBookID
            // 
            this.txtUpdateBookID.Location = new System.Drawing.Point(207, 164);
            this.txtUpdateBookID.Name = "txtUpdateBookID";
            this.txtUpdateBookID.Size = new System.Drawing.Size(46, 20);
            this.txtUpdateBookID.TabIndex = 15;
            this.txtUpdateBookID.TextChanged += new System.EventHandler(this.txtUpdateBookID_TextChanged);
            // 
            // txtUpdateBookTitle
            // 
            this.txtUpdateBookTitle.Location = new System.Drawing.Point(207, 221);
            this.txtUpdateBookTitle.Name = "txtUpdateBookTitle";
            this.txtUpdateBookTitle.Size = new System.Drawing.Size(148, 20);
            this.txtUpdateBookTitle.TabIndex = 16;
            // 
            // txtUpdateBookAuthor
            // 
            this.txtUpdateBookAuthor.Location = new System.Drawing.Point(207, 275);
            this.txtUpdateBookAuthor.Name = "txtUpdateBookAuthor";
            this.txtUpdateBookAuthor.Size = new System.Drawing.Size(148, 20);
            this.txtUpdateBookAuthor.TabIndex = 17;
            // 
            // txtUpdateBookPrice
            // 
            this.txtUpdateBookPrice.Location = new System.Drawing.Point(207, 326);
            this.txtUpdateBookPrice.Name = "txtUpdateBookPrice";
            this.txtUpdateBookPrice.Size = new System.Drawing.Size(46, 20);
            this.txtUpdateBookPrice.TabIndex = 18;
            // 
            // txtUpdateBookStock
            // 
            this.txtUpdateBookStock.Location = new System.Drawing.Point(207, 385);
            this.txtUpdateBookStock.Name = "txtUpdateBookStock";
            this.txtUpdateBookStock.Size = new System.Drawing.Size(46, 20);
            this.txtUpdateBookStock.TabIndex = 19;
            // 
            // frmUpdateBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(575, 533);
            this.Controls.Add(this.txtUpdateBookStock);
            this.Controls.Add(this.txtUpdateBookPrice);
            this.Controls.Add(this.txtUpdateBookAuthor);
            this.Controls.Add(this.txtUpdateBookTitle);
            this.Controls.Add(this.txtUpdateBookID);
            this.Controls.Add(this.lblUpdateBookStock);
            this.Controls.Add(this.lblUpdateBookPrice);
            this.Controls.Add(this.lblUpdateBookAuthor);
            this.Controls.Add(this.lblUpdateBookTitle);
            this.Controls.Add(this.lblUpdateBookID);
            this.Controls.Add(this.btnUpdateBook);
            this.Controls.Add(this.lblUpdatebookInstructions);
            this.Controls.Add(this.lblUpdateBook);
            this.Controls.Add(this.mnuUpdateBook);
            this.MainMenuStrip = this.mnuUpdateBook;
            this.Name = "frmUpdateBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Booktopia - [Update Book]";
            this.Load += new System.EventHandler(this.frmUpdateBook_Load);
            this.mnuUpdateBook.ResumeLayout(false);
            this.mnuUpdateBook.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUpdateBook;
        private System.Windows.Forms.MenuStrip mnuUpdateBook;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateBookBack;
        private System.Windows.Forms.Label lblUpdatebookInstructions;
        private System.Windows.Forms.Button btnUpdateBook;
        private System.Windows.Forms.Label lblUpdateBookID;
        private System.Windows.Forms.Label lblUpdateBookTitle;
        private System.Windows.Forms.Label lblUpdateBookAuthor;
        private System.Windows.Forms.Label lblUpdateBookPrice;
        private System.Windows.Forms.Label lblUpdateBookStock;
        private System.Windows.Forms.TextBox txtUpdateBookID;
        private System.Windows.Forms.TextBox txtUpdateBookTitle;
        private System.Windows.Forms.TextBox txtUpdateBookAuthor;
        private System.Windows.Forms.TextBox txtUpdateBookPrice;
        private System.Windows.Forms.TextBox txtUpdateBookStock;
    }
}