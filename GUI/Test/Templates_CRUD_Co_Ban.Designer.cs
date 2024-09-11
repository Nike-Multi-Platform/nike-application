﻿
namespace Nike_Shop_Management.GUI.Test
{
    partial class Templates_CRUD_Co_Ban<T>
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.tableLayoutPanel_Show = new System.Windows.Forms.TableLayoutPanel();
            this.Label_Name_of_Bussiness = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnAdd = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnEdit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnDelete = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.u_Search1 = new Nike_Shop_Management.u_Search();
            this.u_DataGridView1 = new Nike_Shop_Management.u_DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.Label_Name_of_Bussiness);
            this.kryptonPanel1.Controls.Add(this.u_Search1);
            this.kryptonPanel1.Controls.Add(this.btnDelete);
            this.kryptonPanel1.Controls.Add(this.btnEdit);
            this.kryptonPanel1.Controls.Add(this.btnAdd);
            this.kryptonPanel1.Controls.Add(this.u_DataGridView1);
            this.kryptonPanel1.Controls.Add(this.tableLayoutPanel_Show);
            this.kryptonPanel1.Location = new System.Drawing.Point(20, 3);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(975, 808);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel_Show
            // 
            this.tableLayoutPanel_Show.AutoScroll = true;
            this.tableLayoutPanel_Show.ColumnCount = 2;
            this.tableLayoutPanel_Show.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Show.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Show.Location = new System.Drawing.Point(56, 149);
            this.tableLayoutPanel_Show.Name = "tableLayoutPanel_Show";
            this.tableLayoutPanel_Show.RowCount = 2;
            this.tableLayoutPanel_Show.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.59942F));
            this.tableLayoutPanel_Show.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.40058F));
            this.tableLayoutPanel_Show.Size = new System.Drawing.Size(898, 347);
            this.tableLayoutPanel_Show.TabIndex = 2;
            // 
            // Label_Name_of_Bussiness
            // 
            this.Label_Name_of_Bussiness.Location = new System.Drawing.Point(429, 3);
            this.Label_Name_of_Bussiness.Name = "Label_Name_of_Bussiness";
            this.Label_Name_of_Bussiness.Size = new System.Drawing.Size(180, 31);
            this.Label_Name_of_Bussiness.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Name_of_Bussiness.TabIndex = 1;
            this.Label_Name_of_Bussiness.Values.Text = "name_business";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(228, 502);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(136, 37);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Values.Text = "Add";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(370, 502);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(122, 37);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Values.Text = "Edit";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(497, 502);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(156, 37);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Values.Text = "Delete";
            // 
            // u_Search1
            // 
            this.u_Search1.Location = new System.Drawing.Point(56, 40);
            this.u_Search1.Name = "u_Search1";
            this.u_Search1.Size = new System.Drawing.Size(520, 89);
            this.u_Search1.TabIndex = 7;
            this.u_Search1.UserSearched = null;
            // 
            // u_DataGridView1
            // 
            this.u_DataGridView1.BackColor = System.Drawing.SystemColors.Control;
            this.u_DataGridView1.DataSelected = null;
            this.u_DataGridView1.GetIndexSelected = 0;
            this.u_DataGridView1.Location = new System.Drawing.Point(20, 556);
            this.u_DataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.u_DataGridView1.Name = "u_DataGridView1";
            this.u_DataGridView1.Size = new System.Drawing.Size(934, 239);
            this.u_DataGridView1.TabIndex = 3;
            this.u_DataGridView1.Load += new System.EventHandler(this.u_DataGridView1_Load);
            // 
            // Templates_CRUD_Co_Ban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "Templates_CRUD_Co_Ban";
            this.Size = new System.Drawing.Size(1018, 826);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel Label_Name_of_Bussiness;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Show;
        private u_DataGridView u_DataGridView1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnDelete;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnEdit;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAdd;
        private u_Search u_Search1;
    }
}
