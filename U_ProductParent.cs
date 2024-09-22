using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nike_Shop_Management.CloudService;
using Nike_Shop_Management.DTO;
namespace Nike_Shop_Management.DAL
{
    public partial class U_ProductParent : UserControl
    {
        CloudIService CloudIService;
        ServiceConfig ServiceConfig;
        public ProductParentDTO productParentDTO { get; set; }
        public U_ProductParent()
        {
            InitializeComponent();
            this.Click += U_ProductParent_Click1;
            this.MouseEnter += U_ProductParent_MouseEnter;
            this.MouseLeave += U_ProductParent_MouseLeave;
            img_product.MouseEnter += U_ProductParent_MouseEnter;
            img_product.MouseLeave += U_ProductParent_MouseLeave;
            img_product.Click += U_ProductParent_Click1;
        }
        public event EventHandler Clicked;
        private void U_ProductParent_Click1(object sender, EventArgs e)
        {
            
            Clicked?.Invoke(this, EventArgs.Empty);
        }

        private void U_ProductParent_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#fff");
        }

        private void U_ProductParent_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#ddd");
        }

        public void PaintData(ProductParentDTO productParent)
        {
            productParentDTO = productParent;
            lbl_product_name.Text = productParent.product_parent_name;
            lbl_price.Text = productParent.product_price;
            LoadImgFromUrl(productParent.thumbnail);
        }
        public void LoadImgFromUrl(string path)
        {
            ServiceConfig = new ServiceConfig();
            CloudIService = new CloudIService(ServiceConfig.CloudinaryCloudName, ServiceConfig.CloudinaryApiKey, ServiceConfig.CloudinaryApiSecret);
            img_product.ImageLocation = CloudIService.GetImageUrlByPublicId(path);
            img_product.ErrorImage = (Image)Properties.Resources._default;
        }
    }
}
