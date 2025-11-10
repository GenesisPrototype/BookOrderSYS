namespace BookOrderSYS
{
    partial class frmCancelOrder
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
            this.mnuCancelOrder = new System.Windows.Forms.MenuStrip();
            this.mnuCancelOrderBack = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblCancelOrder = new System.Windows.Forms.Label();
            this.lblCancelOrderInstruction = new System.Windows.Forms.Label();
            this.lblCancelOrderID = new System.Windows.Forms.Label();
            this.txtCancelOrderID = new System.Windows.Forms.TextBox();
            this.btnCancelOrder = new System.Windows.Forms.Button();
            this.lblWarning = new System.Windows.Forms.Label();
            this.mnuCancelOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuCancelOrder
            // 
            this.mnuCancelOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.mnuCancelOrder.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCancelOrderBack});
            this.mnuCancelOrder.Location = new System.Drawing.Point(0, 0);
            this.mnuCancelOrder.Name = "mnuCancelOrder";
            this.mnuCancelOrder.Size = new System.Drawing.Size(496, 24);
            this.mnuCancelOrder.TabIndex = 0;
            // 
            // mnuCancelOrderBack
            // 
            this.mnuCancelOrderBack.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuCancelOrderBack.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.mnuCancelOrderBack.Name = "mnuCancelOrderBack";
            this.mnuCancelOrderBack.Size = new System.Drawing.Size(44, 20);
            this.mnuCancelOrderBack.Text = "Back";
            this.mnuCancelOrderBack.Click += new System.EventHandler(this.mnuCancelOrderBack_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lblCancelOrder
            // 
            this.lblCancelOrder.AutoSize = true;
            this.lblCancelOrder.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancelOrder.Location = new System.Drawing.Point(170, 45);
            this.lblCancelOrder.Name = "lblCancelOrder";
            this.lblCancelOrder.Size = new System.Drawing.Size(141, 19);
            this.lblCancelOrder.TabIndex = 2;
            this.lblCancelOrder.Text = "Cancel Order";
            // 
            // lblCancelOrderInstruction
            // 
            this.lblCancelOrderInstruction.AutoSize = true;
            this.lblCancelOrderInstruction.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancelOrderInstruction.Location = new System.Drawing.Point(114, 73);
            this.lblCancelOrderInstruction.Name = "lblCancelOrderInstruction";
            this.lblCancelOrderInstruction.Size = new System.Drawing.Size(263, 12);
            this.lblCancelOrderInstruction.TabIndex = 3;
            this.lblCancelOrderInstruction.Text = "Enter the ID of the order to be cancelled. ";
            // 
            // lblCancelOrderID
            // 
            this.lblCancelOrderID.AutoSize = true;
            this.lblCancelOrderID.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancelOrderID.Location = new System.Drawing.Point(156, 161);
            this.lblCancelOrderID.Name = "lblCancelOrderID";
            this.lblCancelOrderID.Size = new System.Drawing.Size(63, 13);
            this.lblCancelOrderID.TabIndex = 4;
            this.lblCancelOrderID.Text = "Order ID";
            // 
            // txtCancelOrderID
            // 
            this.txtCancelOrderID.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCancelOrderID.Location = new System.Drawing.Point(225, 158);
            this.txtCancelOrderID.Name = "txtCancelOrderID";
            this.txtCancelOrderID.Size = new System.Drawing.Size(100, 20);
            this.txtCancelOrderID.TabIndex = 5;
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCancelOrder.ForeColor = System.Drawing.Color.LightGray;
            this.btnCancelOrder.Location = new System.Drawing.Point(195, 236);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(91, 23);
            this.btnCancelOrder.TabIndex = 6;
            this.btnCancelOrder.Text = "Cancel Order";
            this.btnCancelOrder.UseVisualStyleBackColor = false;
            this.btnCancelOrder.Click += new System.EventHandler(this.btnCancelOrder_Click);
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.ForeColor = System.Drawing.Color.IndianRed;
            this.lblWarning.Location = new System.Drawing.Point(113, 208);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(256, 13);
            this.lblWarning.TabIndex = 7;
            this.lblWarning.Text = "[WARNING: Cancelling an order cannot be undone.]";
            // 
            // frmCancelOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(496, 305);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.btnCancelOrder);
            this.Controls.Add(this.txtCancelOrderID);
            this.Controls.Add(this.lblCancelOrderID);
            this.Controls.Add(this.lblCancelOrderInstruction);
            this.Controls.Add(this.lblCancelOrder);
            this.Controls.Add(this.mnuCancelOrder);
            this.MainMenuStrip = this.mnuCancelOrder;
            this.Name = "frmCancelOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Booktopia [Cancel Order]";
            this.mnuCancelOrder.ResumeLayout(false);
            this.mnuCancelOrder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuCancelOrder;
        private System.Windows.Forms.ToolStripMenuItem mnuCancelOrderBack;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblCancelOrder;
        private System.Windows.Forms.Label lblCancelOrderInstruction;
        private System.Windows.Forms.Label lblCancelOrderID;
        private System.Windows.Forms.TextBox txtCancelOrderID;
        private System.Windows.Forms.Button btnCancelOrder;
        private System.Windows.Forms.Label lblWarning;
    }
}