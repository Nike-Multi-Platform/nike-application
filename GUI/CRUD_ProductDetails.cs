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
                BindingData(int.Parse(listView1.SelectedItems[0].Text),int.Parse(selectedItem.SubItems[2].Text));
            }
        }
        public void BindingData(int product_id,int supplier_id)
        {
            ProductColorManager productColorManager = new ProductColorManager(new DAL.ProductColorRepository(new DAL.DbContextDataContext()));
            List<ProductSizeDTO> listSize = productColorManager.GetProductSizesByID(product_id);
            List<SupplierDTO> listSupplier = productColorManager.GetSuppliers(supplier_id);
            if (listSize.Count>0 && listSupplier.Count>0)
            {
                
                comboSize.DataSource = listSize;
                comboSize.DisplayMember = "size_id";
                comboSize.ValueMember = "product_size_id";
                

                lbl_quantity.Text = productColorManager.GetQuantity((int)comboSize.SelectedValue).ToString();
                comboSupplier.DataSource = listSupplier;
                comboSupplier.DisplayMember = "supplier_name";
                comboSupplier.ValueMember = "supplier_id";
            }
            ProductColorsDTO productColorsDTO = productColorManager.GetByID(product_id);
            if(productColorsDTO!=null)
            {
                txColorShown.Text = productColorsDTO.product_color_shown;
                txSalePrices.Text = productColorsDTO.sale_prices;
                txSizeAndFit.Text = productColorsDTO.product_size_and_fit;
                txSolds.Text = productColorsDTO.sold;
                txStylecode.Text = productColorsDTO.product_style_code;
                txTotalStock.Text = productColorsDTO.total_stock;
                tx_description.Text = productColorsDTO.product_description;
                tx_description2.Text = productColorsDTO.product_description2;
                tx_more_info.Text = productColorsDTO.product_more_info;
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
                    ListViewItem item = new ListViewItem(product.product_id.ToString(), i++);
                    item.SubItems.Add(product.product_img);
                    item.SubItems.Add(product.supplier_id.ToString());
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
