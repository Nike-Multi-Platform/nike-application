
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
            this.datagrid = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.dg_object = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_object)).BeginInit();
            this.SuspendLayout();
            // 
            // datagrid
            // 
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid.Location = new System.Drawing.Point(21, 343);
            this.datagrid.Name = "datagrid";
            this.datagrid.RowHeadersWidth = 51;
            this.datagrid.RowTemplate.Height = 24;
            this.datagrid.Size = new System.Drawing.Size(1327, 343);
            this.datagrid.TabIndex = 0;
            // 
            // dg_object
            // 
            this.dg_object.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_object.Location = new System.Drawing.Point(191, 84);
            this.dg_object.Name = "dg_object";
            this.dg_object.RowHeadersWidth = 51;
            this.dg_object.RowTemplate.Height = 24;
            this.dg_object.Size = new System.Drawing.Size(789, 150);
            this.dg_object.TabIndex = 1;
            // 
            // ProductParent_Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 710);
            this.Controls.Add(this.dg_object);
            this.Controls.Add(this.datagrid);
            this.Name = "ProductParent_Test";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductParent";
            this.Load += new System.EventHandler(this.ProductParent_Test_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_object)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView datagrid;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dg_object;
    }
}