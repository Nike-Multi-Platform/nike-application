using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nike_Shop_Management.DTO;
using Nike_Shop_Management.BLL;
using Nike_Shop_Management.CloudService;

namespace Nike_Shop_Management.GUI
{
    public partial class CRUD_ProductDetails : Form
    {
        CloudIService CloudIService;
        ServiceConfig ServiceConfig;
        public CRUD_ProductDetails()
        {
            InitializeComponent();
            listView1.Click += ListView1_Click;
        }

        private void ListView1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                Console.WriteLine(selectedItem.SubItems[1].Text);
                u_PictureBox.LoadImgFromUrl(selectedItem.SubItems[1].Text);
            }
        }

        public void PaintData(int product_parent_id)
        {
            listView1.Items.Clear();
            listView1.Columns.Clear();
            listView1.FullRowSelect = false;
            listView1.MultiSelect = false;
            ProductParentManager ppM = new ProductParentManager(new DAL.ProductParentRepository(new DAL.DbContextDataContext()));
            List<ProductColorsDTO> list = ppM.GetProductColors(product_parent_id);
            ImageList imageListSmall = new ImageList();
            ImageList imageListLarge = new ImageList();
            if (list != null)
            {
                ServiceConfig ServiceConfig = new ServiceConfig();
                int i = 0;
                CloudIService = new CloudIService(ServiceConfig.CloudinaryCloudName, ServiceConfig.CloudinaryApiKey, ServiceConfig.CloudinaryApiSecret);
                foreach (var product in list)
                {
          
                    PictureBox img_product = new PictureBox();
                    ListViewItem item = new ListViewItem(product.product_id.ToString(),i++);
                    item.SubItems.Add(product.product_img);
                    img_product.ImageLocation = CloudIService.GetImageUrlByPublicId(product.product_img);
                    img_product.Load();
                    imageListSmall.Images.Add(img_product.Image);
                    imageListLarge.Images.Add(img_product.Image);
                    imageListLarge.ColorDepth = ColorDepth.Depth32Bit;
                    imageListSmall.ColorDepth = ColorDepth.Depth32Bit;
                    listView1.Items.Add(item);
                }

            }
            imageListSmall.ImageSize = new Size(50, 50);
            imageListLarge.ImageSize = new Size(60, 80);

            listView1.LargeImageList = imageListLarge;
            listView1.SmallImageList = imageListSmall;
        }
       
    }
}
