
namespace Nike_Shop_Management.GUI.Test
{
    partial class Form_View_Product_Color
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
            this.data_size = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.lbl_NameProductParent = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lol = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_product_more_info = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txt_product_size_and_fit = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txt_product_style_code = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txt_product_color_shown = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txt_product_description2 = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.txt_product_description = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.btnAddSize = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnEdit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnDeleteSize = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_product_id = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.u_PictureBox1 = new Nike_Shop_Management.u_PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.data_size)).BeginInit();
            this.SuspendLayout();
            // 
            // data_size
            // 
            this.data_size.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_size.Location = new System.Drawing.Point(12, 530);
            this.data_size.Name = "data_size";
            this.data_size.RowHeadersWidth = 51;
            this.data_size.RowTemplate.Height = 24;
            this.data_size.Size = new System.Drawing.Size(1058, 196);
            this.data_size.TabIndex = 1;
            // 
            // lbl_NameProductParent
            // 
            this.lbl_NameProductParent.Location = new System.Drawing.Point(336, 12);
            this.lbl_NameProductParent.Name = "lbl_NameProductParent";
            this.lbl_NameProductParent.Size = new System.Drawing.Size(244, 31);
            this.lbl_NameProductParent.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NameProductParent.TabIndex = 2;
            this.lbl_NameProductParent.Values.Text = "Name product parent";
            // 
            // lol
            // 
            this.lol.Location = new System.Drawing.Point(461, 150);
            this.lol.Name = "lol";
            this.lol.Size = new System.Drawing.Size(149, 24);
            this.lol.TabIndex = 3;
            this.lol.Values.Text = "product_size_and_fit";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(461, 201);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(142, 24);
            this.kryptonLabel3.TabIndex = 4;
            this.kryptonLabel3.Values.Text = "product_style_code";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(459, 248);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(157, 24);
            this.kryptonLabel4.TabIndex = 5;
            this.kryptonLabel4.Values.Text = "product_color_shown";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(459, 105);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(140, 24);
            this.kryptonLabel5.TabIndex = 6;
            this.kryptonLabel5.Values.Text = "product_more_info";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(459, 323);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(147, 24);
            this.kryptonLabel1.TabIndex = 8;
            this.kryptonLabel1.Values.Text = "product_description";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(454, 383);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(156, 24);
            this.kryptonLabel2.TabIndex = 9;
            this.kryptonLabel2.Values.Text = "product_description2";
            // 
            // txt_product_more_info
            // 
            this.txt_product_more_info.Location = new System.Drawing.Point(648, 106);
            this.txt_product_more_info.Name = "txt_product_more_info";
            this.txt_product_more_info.Size = new System.Drawing.Size(315, 27);
            this.txt_product_more_info.TabIndex = 10;
            this.txt_product_more_info.Text = "kryptonTextBox1";
            // 
            // txt_product_size_and_fit
            // 
            this.txt_product_size_and_fit.Location = new System.Drawing.Point(648, 150);
            this.txt_product_size_and_fit.Name = "txt_product_size_and_fit";
            this.txt_product_size_and_fit.Size = new System.Drawing.Size(315, 27);
            this.txt_product_size_and_fit.TabIndex = 11;
            this.txt_product_size_and_fit.Text = "kryptonTextBox2";
            // 
            // txt_product_style_code
            // 
            this.txt_product_style_code.Location = new System.Drawing.Point(648, 198);
            this.txt_product_style_code.Name = "txt_product_style_code";
            this.txt_product_style_code.Size = new System.Drawing.Size(315, 27);
            this.txt_product_style_code.TabIndex = 12;
            this.txt_product_style_code.Text = "kryptonTextBox3";
            // 
            // txt_product_color_shown
            // 
            this.txt_product_color_shown.Location = new System.Drawing.Point(648, 248);
            this.txt_product_color_shown.Name = "txt_product_color_shown";
            this.txt_product_color_shown.Size = new System.Drawing.Size(315, 27);
            this.txt_product_color_shown.TabIndex = 13;
            this.txt_product_color_shown.Text = "kryptonTextBox4";
            // 
            // txt_product_description2
            // 
            this.txt_product_description2.Location = new System.Drawing.Point(648, 373);
            this.txt_product_description2.Name = "txt_product_description2";
            this.txt_product_description2.Size = new System.Drawing.Size(315, 49);
            this.txt_product_description2.TabIndex = 16;
            this.txt_product_description2.Text = "kryptonRichTextBox1";
            // 
            // txt_product_description
            // 
            this.txt_product_description.Location = new System.Drawing.Point(648, 308);
            this.txt_product_description.Name = "txt_product_description";
            this.txt_product_description.Size = new System.Drawing.Size(315, 49);
            this.txt_product_description.TabIndex = 17;
            this.txt_product_description.Text = "kryptonRichTextBox2";
            // 
            // btnAddSize
            // 
            this.btnAddSize.Location = new System.Drawing.Point(367, 446);
            this.btnAddSize.Name = "btnAddSize";
            this.btnAddSize.Size = new System.Drawing.Size(127, 55);
            this.btnAddSize.TabIndex = 18;
            this.btnAddSize.Values.Text = "Add";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(525, 446);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(129, 55);
            this.btnEdit.TabIndex = 19;
            this.btnEdit.Values.Text = "Edit";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(865, 446);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(98, 55);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Values.Text = "Cancel";
            // 
            // btnDeleteSize
            // 
            this.btnDeleteSize.Location = new System.Drawing.Point(705, 446);
            this.btnDeleteSize.Name = "btnDeleteSize";
            this.btnDeleteSize.Size = new System.Drawing.Size(124, 55);
            this.btnDeleteSize.TabIndex = 21;
            this.btnDeleteSize.Values.Text = "Delete";
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(461, 57);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(84, 24);
            this.kryptonLabel6.TabIndex = 22;
            this.kryptonLabel6.Values.Text = "product_id";
            // 
            // txt_product_id
            // 
            this.txt_product_id.Location = new System.Drawing.Point(648, 57);
            this.txt_product_id.Name = "txt_product_id";
            this.txt_product_id.ReadOnly = true;
            this.txt_product_id.Size = new System.Drawing.Size(308, 27);
            this.txt_product_id.TabIndex = 23;
            // 
            // u_PictureBox1
            // 
            this.u_PictureBox1.Location = new System.Drawing.Point(12, 70);
            this.u_PictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.u_PictureBox1.Name = "u_PictureBox1";
            this.u_PictureBox1.PathThumbail = null;
            this.u_PictureBox1.Size = new System.Drawing.Size(357, 333);
            this.u_PictureBox1.TabIndex = 7;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // Form_View_Product_Color
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 771);
            this.Controls.Add(this.txt_product_id);
            this.Controls.Add(this.kryptonLabel6);
            this.Controls.Add(this.btnDeleteSize);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAddSize);
            this.Controls.Add(this.txt_product_description);
            this.Controls.Add(this.txt_product_description2);
            this.Controls.Add(this.txt_product_color_shown);
            this.Controls.Add(this.txt_product_style_code);
            this.Controls.Add(this.txt_product_size_and_fit);
            this.Controls.Add(this.txt_product_more_info);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.u_PictureBox1);
            this.Controls.Add(this.kryptonLabel5);
            this.Controls.Add(this.kryptonLabel4);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.lol);
            this.Controls.Add(this.lbl_NameProductParent);
            this.Controls.Add(this.data_size);
            this.Name = "Form_View_Product_Color";
            this.Text = "Form_View_Product_Color";
            ((System.ComponentModel.ISupportInitialize)(this.data_size)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView data_size;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_NameProductParent;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lol;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private u_PictureBox u_PictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_product_more_info;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_product_size_and_fit;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_product_style_code;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_product_color_shown;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox txt_product_description2;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox txt_product_description;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAddSize;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnEdit;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCancel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnDeleteSize;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_product_id;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}