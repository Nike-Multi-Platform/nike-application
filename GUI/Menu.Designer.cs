
namespace Nike_Shop_Management.GUI
{
    partial class Menu
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
            this.panelNavBar = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btnCloseChildForm = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panelMenu = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.panelLogo = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.panelDesktop = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelNavBar)).BeginInit();
            this.panelNavBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelMenu)).BeginInit();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelLogo)).BeginInit();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelDesktop)).BeginInit();
            this.panelDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNavBar
            // 
            this.panelNavBar.Controls.Add(this.label3);
            this.panelNavBar.Controls.Add(this.btnCloseChildForm);
            this.panelNavBar.Location = new System.Drawing.Point(311, 12);
            this.panelNavBar.Name = "panelNavBar";
            this.panelNavBar.Size = new System.Drawing.Size(859, 57);
            this.panelNavBar.TabIndex = 0;
            // 
            // btnCloseChildForm
            // 
            this.btnCloseChildForm.Location = new System.Drawing.Point(830, 3);
            this.btnCloseChildForm.Name = "btnCloseChildForm";
            this.btnCloseChildForm.Size = new System.Drawing.Size(26, 25);
            this.btnCloseChildForm.TabIndex = 1;
            this.btnCloseChildForm.Values.Text = "X";
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.label2);
            this.panelMenu.Location = new System.Drawing.Point(30, 146);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(246, 494);
            this.panelMenu.TabIndex = 2;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Location = new System.Drawing.Point(30, 12);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(246, 117);
            this.panelLogo.TabIndex = 3;
            // 
            // panelDesktop
            // 
            this.panelDesktop.Controls.Add(this.label4);
            this.panelDesktop.Location = new System.Drawing.Point(311, 88);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(859, 552);
            this.panelDesktop.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Danh mục chức năng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(298, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên danh mục chức năng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(347, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Thay đổi form con";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 663);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelLogo);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelNavBar);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.panelNavBar)).EndInit();
            this.panelNavBar.ResumeLayout(false);
            this.panelNavBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelMenu)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelLogo)).EndInit();
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelDesktop)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel panelNavBar;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCloseChildForm;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel panelMenu;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel panelLogo;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel panelDesktop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}