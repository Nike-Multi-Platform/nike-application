namespace Nike_Shop_Management.GUI
{
    partial class ManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagementForm));
            this.headerPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.FormLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btn_Menu = new System.Windows.Forms.PictureBox();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btn_product = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.menuTransition = new System.Windows.Forms.Timer(this.components);
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.panelBody = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.headerPanel)).BeginInit();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Menu)).BeginInit();
            this.sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelBody)).BeginInit();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.Controls.Add(this.pictureBox2);
            this.headerPanel.Controls.Add(this.FormLabel);
            this.headerPanel.Controls.Add(this.btn_Menu);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.headerPanel.Size = new System.Drawing.Size(1100, 47);
            this.headerPanel.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(262, 1);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 46);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // FormLabel
            // 
            this.FormLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormLabel.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.FormLabel.Location = new System.Drawing.Point(75, 12);
            this.FormLabel.Margin = new System.Windows.Forms.Padding(0);
            this.FormLabel.Name = "FormLabel";
            this.FormLabel.Size = new System.Drawing.Size(187, 24);
            this.FormLabel.TabIndex = 1;
            this.FormLabel.Values.Text = "Nike Shop Management";
            // 
            // btn_Menu
            // 
            this.btn_Menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Menu.Image = ((System.Drawing.Image)(resources.GetObject("btn_Menu.Image")));
            this.btn_Menu.Location = new System.Drawing.Point(23, 12);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Size = new System.Drawing.Size(26, 28);
            this.btn_Menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Menu.TabIndex = 1;
            this.btn_Menu.TabStop = false;
            this.btn_Menu.Click += new System.EventHandler(this.btn_Menu_Click);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.sidebar.Controls.Add(this.kryptonPanel1);
            this.sidebar.Controls.Add(this.btn_product);
            this.sidebar.Controls.Add(this.kryptonButton1);
            this.sidebar.Controls.Add(this.kryptonButton2);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.sidebar.Location = new System.Drawing.Point(0, 47);
            this.sidebar.Margin = new System.Windows.Forms.Padding(0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(200, 603);
            this.sidebar.TabIndex = 1;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(200, 58);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.Transparent;
            this.kryptonPanel1.TabIndex = 6;
            // 
            // btn_product
            // 
            this.btn_product.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.ListItem;
            this.btn_product.Location = new System.Drawing.Point(0, 58);
            this.btn_product.Margin = new System.Windows.Forms.Padding(0);
            this.btn_product.Name = "btn_product";
            this.btn_product.Palette = this.kryptonPalette1;
            this.btn_product.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btn_product.Size = new System.Drawing.Size(200, 58);
            this.btn_product.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btn_product.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btn_product.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterLeft;
            this.btn_product.StateCommon.Border.Color1 = System.Drawing.Color.Cyan;
            this.btn_product.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_product.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_product.StateCommon.Content.LongText.Color1 = System.Drawing.Color.White;
            this.btn_product.StateCommon.Content.LongText.Color2 = System.Drawing.Color.White;
            this.btn_product.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            this.btn_product.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_product.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_product.StatePressed.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidRightLine;
            this.btn_product.StatePressed.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btn_product.TabIndex = 5;
            this.btn_product.Values.Image = ((System.Drawing.Image)(resources.GetObject("btn_product.Values.Image")));
            this.btn_product.Values.Text = "         Product";
            this.btn_product.Click += new System.EventHandler(this.btn_product_Click);
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 15;
            // 
            // menuTransition
            // 
            this.menuTransition.Interval = 10;
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 10;
            this.sidebarTransition.Tick += new System.EventHandler(this.sidebarTransition_Tick);
            // 
            // panelBody
            // 
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(200, 47);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(900, 603);
            this.panelBody.TabIndex = 5;
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.ListItem;
            this.kryptonButton1.Location = new System.Drawing.Point(0, 116);
            this.kryptonButton1.Margin = new System.Windows.Forms.Padding(0);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Palette = this.kryptonPalette1;
            this.kryptonButton1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.kryptonButton1.Size = new System.Drawing.Size(200, 58);
            this.kryptonButton1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.kryptonButton1.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.kryptonButton1.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterLeft;
            this.kryptonButton1.StateCommon.Border.Color1 = System.Drawing.Color.Cyan;
            this.kryptonButton1.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kryptonButton1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateCommon.Content.LongText.Color1 = System.Drawing.Color.White;
            this.kryptonButton1.StateCommon.Content.LongText.Color2 = System.Drawing.Color.White;
            this.kryptonButton1.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            this.kryptonButton1.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton1.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonButton1.StatePressed.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidRightLine;
            this.kryptonButton1.StatePressed.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.kryptonButton1.TabIndex = 7;
            this.kryptonButton1.Values.Image = ((System.Drawing.Image)(resources.GetObject("kryptonButton1.Values.Image")));
            this.kryptonButton1.Values.Text = "         Product";
            // 
            // kryptonButton2
            // 
            this.kryptonButton2.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.ListItem;
            this.kryptonButton2.Location = new System.Drawing.Point(0, 174);
            this.kryptonButton2.Margin = new System.Windows.Forms.Padding(0);
            this.kryptonButton2.Name = "kryptonButton2";
            this.kryptonButton2.Palette = this.kryptonPalette1;
            this.kryptonButton2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.kryptonButton2.Size = new System.Drawing.Size(200, 58);
            this.kryptonButton2.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.kryptonButton2.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.kryptonButton2.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterLeft;
            this.kryptonButton2.StateCommon.Border.Color1 = System.Drawing.Color.Cyan;
            this.kryptonButton2.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kryptonButton2.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton2.StateCommon.Content.LongText.Color1 = System.Drawing.Color.White;
            this.kryptonButton2.StateCommon.Content.LongText.Color2 = System.Drawing.Color.White;
            this.kryptonButton2.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            this.kryptonButton2.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton2.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonButton2.StatePressed.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidRightLine;
            this.kryptonButton2.StatePressed.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.kryptonButton2.TabIndex = 8;
            this.kryptonButton2.Values.Image = ((System.Drawing.Image)(resources.GetObject("kryptonButton2.Values.Image")));
            this.kryptonButton2.Values.Text = "         Product";
            // 
            // ManagementForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.Name = "ManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagementForm";
            ((System.ComponentModel.ISupportInitialize)(this.headerPanel)).EndInit();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Menu)).EndInit();
            this.sidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelBody)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel headerPanel;
        private System.Windows.Forms.PictureBox btn_Menu;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel FormLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Timer menuTransition;
        private System.Windows.Forms.Timer sidebarTransition;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_product;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel panelBody;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton2;
    }
}