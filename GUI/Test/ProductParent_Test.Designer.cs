
namespace Nike_Shop_Management.GUI.Test
{
    partial class ProductParent_Test
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
            this.txt_Search1 = new Nike_Shop_Management.u_Search();
            this.u_ProductColors = new Nike_Shop_Management.u_DataGridView();
            this.u_ProductParent = new Nike_Shop_Management.u_DataGridView();
            this.SuspendLayout();
            // 
            // txt_Search1
            // 
            this.txt_Search1.Location = new System.Drawing.Point(34, 343);
            this.txt_Search1.Name = "txt_Search1";
            this.txt_Search1.Size = new System.Drawing.Size(503, 89);
            this.txt_Search1.TabIndex = 5;
            this.txt_Search1.UserSearched = null;
            // 
            // u_ProductColors
            // 
            this.u_ProductColors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.u_ProductColors.DataSelected = null;
            this.u_ProductColors.GetIndexSelected = 0;
            this.u_ProductColors.Location = new System.Drawing.Point(34, 437);
            this.u_ProductColors.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.u_ProductColors.Name = "u_ProductColors";
            this.u_ProductColors.Size = new System.Drawing.Size(959, 193);
            this.u_ProductColors.TabIndex = 4;
            // 
            // u_ProductParent
            // 
            this.u_ProductParent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.u_ProductParent.DataSelected = null;
            this.u_ProductParent.GetIndexSelected = 0;
            this.u_ProductParent.Location = new System.Drawing.Point(34, 22);
            this.u_ProductParent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.u_ProductParent.Name = "u_ProductParent";
            this.u_ProductParent.Size = new System.Drawing.Size(959, 284);
            this.u_ProductParent.TabIndex = 0;
            // 
            // ProductParent_Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 754);
            this.Controls.Add(this.txt_Search1);
            this.Controls.Add(this.u_ProductColors);
            this.Controls.Add(this.u_ProductParent);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ProductParent_Test";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductParent";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ProductParent_Test_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private u_DataGridView u_ProductParent;
        private u_DataGridView u_ProductColors;
        private u_Search txt_Search1;
    }
}