
namespace Nike_Shop_Management.GUI
{
    partial class EditProductSizeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ListSizeInventory = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.ListSizeCurrent = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.cancelButton1 = new Nike_Shop_Management.CustomControl.CancelButton();
            this.kryptonButton3 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.ListSizeInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListSizeCurrent)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Product Size Inventory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Product size current";
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(186, 101);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(90, 25);
            this.kryptonButton1.TabIndex = 6;
            this.kryptonButton1.Values.Text = ">>";
            // 
            // kryptonButton2
            // 
            this.kryptonButton2.Location = new System.Drawing.Point(186, 149);
            this.kryptonButton2.Name = "kryptonButton2";
            this.kryptonButton2.Size = new System.Drawing.Size(90, 25);
            this.kryptonButton2.TabIndex = 7;
            this.kryptonButton2.Values.Text = "<<";
            // 
            // ListSizeInventory
            // 
            this.ListSizeInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListSizeInventory.Location = new System.Drawing.Point(33, 56);
            this.ListSizeInventory.Name = "ListSizeInventory";
            this.ListSizeInventory.Size = new System.Drawing.Size(135, 118);
            this.ListSizeInventory.TabIndex = 8;
            // 
            // ListSizeCurrent
            // 
            this.ListSizeCurrent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListSizeCurrent.Location = new System.Drawing.Point(299, 48);
            this.ListSizeCurrent.Name = "ListSizeCurrent";
            this.ListSizeCurrent.Size = new System.Drawing.Size(140, 125);
            this.ListSizeCurrent.TabIndex = 9;
            // 
            // cancelButton1
            // 
            this.cancelButton1.Location = new System.Drawing.Point(354, 196);
            this.cancelButton1.Name = "cancelButton1";
            this.cancelButton1.Size = new System.Drawing.Size(85, 28);
            this.cancelButton1.TabIndex = 10;
            this.cancelButton1.Values.Text = "cancelButton1";
            // 
            // kryptonButton3
            // 
            this.kryptonButton3.Location = new System.Drawing.Point(236, 196);
            this.kryptonButton3.Name = "kryptonButton3";
            this.kryptonButton3.Size = new System.Drawing.Size(85, 27);
            this.kryptonButton3.TabIndex = 11;
            this.kryptonButton3.Values.Text = "kryptonButton3";
            // 
            // EditProductSizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 236);
            this.Controls.Add(this.kryptonButton3);
            this.Controls.Add(this.cancelButton1);
            this.Controls.Add(this.ListSizeCurrent);
            this.Controls.Add(this.ListSizeInventory);
            this.Controls.Add(this.kryptonButton2);
            this.Controls.Add(this.kryptonButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditProductSizeForm";
            this.Text = "EditProductSizeForm";
            this.Load += new System.EventHandler(this.EditProductSizeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListSizeInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListSizeCurrent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton2;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView ListSizeInventory;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView ListSizeCurrent;
        private CustomControl.CancelButton cancelButton1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton3;
    }
}