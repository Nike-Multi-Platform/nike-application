
namespace Nike_Shop_Management
{
    partial class Form1
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
            this.kryptonTextBox1 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // kryptonTextBox1
            // 
            this.kryptonTextBox1.Location = new System.Drawing.Point(94, 208);
            this.kryptonTextBox1.Name = "kryptonTextBox1";
            this.kryptonTextBox1.Size = new System.Drawing.Size(138, 39);
            this.kryptonTextBox1.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonTextBox1.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.kryptonTextBox1.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.kryptonTextBox1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonTextBox1.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonTextBox1.StateCommon.Border.Rounding = 20;
            this.kryptonTextBox1.TabIndex = 0;
            this.kryptonTextBox1.Text = "kryptonTextBox1";
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(473, 296);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(90, 25);
            this.kryptonButton1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateCommon.Border.Rounding = 20;
            this.kryptonButton1.TabIndex = 1;
            this.kryptonButton1.Values.Text = "kryptonButton1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 608);
            this.Controls.Add(this.kryptonButton1);
            this.Controls.Add(this.kryptonTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
    }
}

