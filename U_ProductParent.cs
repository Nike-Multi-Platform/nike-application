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
        public U_ProductParent()
        {
            InitializeComponent();
        }
        public void PaintData(ProductParentDTO productParent)
        {
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
