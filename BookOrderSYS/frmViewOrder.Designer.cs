namespace BookOrderSYS
{
    partial class frmViewOrder
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
            this.mnuViewOrder = new System.Windows.Forms.MenuStrip();
            this.mnuViewOrderBack = new System.Windows.Forms.ToolStripMenuItem();
            this.lblViewOrder = new System.Windows.Forms.Label();
            this.lblViewOrderInstruction = new System.Windows.Forms.Label();
            this.lblViewOrderID = new System.Windows.Forms.Label();
            this.txtViewOrderID = new System.Windows.Forms.TextBox();
            this.btnViewOrder = new System.Windows.Forms.Button();
            this.lblViewOrderDetails = new System.Windows.Forms.Label();
            this.mnuViewOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuViewOrder
            // 
            this.mnuViewOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.mnuViewOrder.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuViewOrderBack});
            this.mnuViewOrder.Location = new System.Drawing.Point(0, 0);
            this.mnuViewOrder.Name = "mnuViewOrder";
            this.mnuViewOrder.Size = new System.Drawing.Size(569, 24);
            this.mnuViewOrder.TabIndex = 0;
            // 
            // mnuViewOrderBack
            // 
            this.mnuViewOrderBack.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuViewOrderBack.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.mnuViewOrderBack.Name = "mnuViewOrderBack";
            this.mnuViewOrderBack.Size = new System.Drawing.Size(44, 20);
            this.mnuViewOrderBack.Text = "Back";
            this.mnuViewOrderBack.Click += new System.EventHandler(this.mnuViewOrderBack_Click);
            // 
            // lblViewOrder
            // 
            this.lblViewOrder.AutoSize = true;
            this.lblViewOrder.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewOrder.Location = new System.Drawing.Point(215, 47);
            this.lblViewOrder.Name = "lblViewOrder";
            this.lblViewOrder.Size = new System.Drawing.Size(119, 19);
            this.lblViewOrder.TabIndex = 1;
            this.lblViewOrder.Text = "View Order";
            // 
            // lblViewOrderInstruction
            // 
            this.lblViewOrderInstruction.AutoSize = true;
            this.lblViewOrderInstruction.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewOrderInstruction.Location = new System.Drawing.Point(133, 75);
            this.lblViewOrderInstruction.Name = "lblViewOrderInstruction";
            this.lblViewOrderInstruction.Size = new System.Drawing.Size(301, 13);
            this.lblViewOrderInstruction.TabIndex = 2;
            this.lblViewOrderInstruction.Text = "Enter the Order ID to view order details. ";
            // 
            // lblViewOrderID
            // 
            this.lblViewOrderID.AutoSize = true;
            this.lblViewOrderID.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewOrderID.Location = new System.Drawing.Point(207, 141);
            this.lblViewOrderID.Name = "lblViewOrderID";
            this.lblViewOrderID.Size = new System.Drawing.Size(63, 13);
            this.lblViewOrderID.TabIndex = 4;
            this.lblViewOrderID.Text = "Order ID";
            // 
            // txtViewOrderID
            // 
            this.txtViewOrderID.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtViewOrderID.Location = new System.Drawing.Point(276, 138);
            this.txtViewOrderID.Name = "txtViewOrderID";
            this.txtViewOrderID.Size = new System.Drawing.Size(64, 20);
            this.txtViewOrderID.TabIndex = 5;
            // 
            // btnViewOrder
            // 
            this.btnViewOrder.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnViewOrder.ForeColor = System.Drawing.Color.LightGray;
            this.btnViewOrder.Location = new System.Drawing.Point(239, 173);
            this.btnViewOrder.Name = "btnViewOrder";
            this.btnViewOrder.Size = new System.Drawing.Size(75, 23);
            this.btnViewOrder.TabIndex = 6;
            this.btnViewOrder.Text = "View";
            this.btnViewOrder.UseVisualStyleBackColor = false;
            this.btnViewOrder.Click += new System.EventHandler(this.btnViewOrder_Click);
            // 
            // lblViewOrderDetails
            // 
            this.lblViewOrderDetails.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewOrderDetails.Location = new System.Drawing.Point(63, 218);
            this.lblViewOrderDetails.Name = "lblViewOrderDetails";
            this.lblViewOrderDetails.Size = new System.Drawing.Size(453, 217);
            this.lblViewOrderDetails.TabIndex = 7;
            this.lblViewOrderDetails.Visible = false;
            // 
            // frmViewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(569, 470);
            this.Controls.Add(this.lblViewOrderDetails);
            this.Controls.Add(this.btnViewOrder);
            this.Controls.Add(this.txtViewOrderID);
            this.Controls.Add(this.lblViewOrderID);
            this.Controls.Add(this.lblViewOrderInstruction);
            this.Controls.Add(this.lblViewOrder);
            this.Controls.Add(this.mnuViewOrder);
            this.MainMenuStrip = this.mnuViewOrder;
            this.Name = "frmViewOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Booktopia - [View Order]";
            this.mnuViewOrder.ResumeLayout(false);
            this.mnuViewOrder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuViewOrder;
        private System.Windows.Forms.ToolStripMenuItem mnuViewOrderBack;
        private System.Windows.Forms.Label lblViewOrder;
        private System.Windows.Forms.Label lblViewOrderInstruction;
        private System.Windows.Forms.Label lblViewOrderID;
        private System.Windows.Forms.TextBox txtViewOrderID;
        private System.Windows.Forms.Button btnViewOrder;
        private System.Windows.Forms.Label lblViewOrderDetails;
    }
}