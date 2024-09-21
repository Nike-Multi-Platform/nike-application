
namespace Nike_Shop_Management.DAL
{
    partial class U_ProductParent
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
            this.lbl_product_name = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_price = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_product_name
            // 
            this.lbl_product_name.Location = new System.Drawing.Point(65, 19);
            this.lbl_product_name.Name = "lbl_product_name";
            this.lbl_product_name.Size = new System.Drawing.Size(76, 24);
            this.lbl_product_name.TabIndex = 0;
            this.lbl_product_name.Values.Text = "TÊN GIÀY";
            // 
            // lbl
            // 
            this.lbl.Location = new System.Drawing.Point(3, 189);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(34, 24);
            this.lbl.TabIndex = 3;
            this.lbl.Values.Text = "Giá";
            // 
            // lbl_price
            // 
            this.lbl_price.Location = new System.Drawing.Point(43, 188);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(134, 25);
            this.lbl_price.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lbl_price.TabIndex = 4;
            this.lbl_price.Values.Text = "kryptonLabel1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Nike_Shop_Management.Properties.Resources.delete;
            this.pictureBox2.Location = new System.Drawing.Point(192, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.ErrorImage = global::Nike_Shop_Management.Properties.Resources._default;
            this.pictureBox1.Image = global::Nike_Shop_Management.Properties.Resources._default;
            this.pictureBox1.InitialImage = global::Nike_Shop_Management.Properties.Resources._default;
            this.pictureBox1.Location = new System.Drawing.Point(25, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // U_ProductParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_product_name);
            this.Name = "U_ProductParent";
            this.Size = new System.Drawing.Size(224, 236);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_product_name;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_price;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
