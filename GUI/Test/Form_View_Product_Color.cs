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
using Nike_Shop_Management.DAL;
namespace Nike_Shop_Management.GUI.Test
{
    public partial class Form_View_Product_Color : Form
    {
        ProductSizeManager pzM;

        public Form_View_Product_Color()
        {
            InitializeComponent();
            pzM = new ProductSizeManager(new DAL.ProductSizeRepository(new DbContext()));
        }

        public void PaintData(ProductDTO productDTO, ProductParentDTO productParentDTO)
        {
            if(productDTO!=null && productParentDTO!=null)
            {
                u_PictureBox1.LoadImgFromUrl(productDTO.product_img);
                lbl_NameProductParent.Text = productParentDTO.product_parent_name;
                txt_product_color_shown.Text = productDTO.product_color_shown;
                txt_product_description.Text = productDTO.product_description;
                txt_product_description2.Text = productDTO.product_description2;
                txt_product_more_info.Text = productDTO.product_more_info;
                txt_product_size_and_fit.Text = productDTO.product_size_and_fit;
                txt_product_style_code.Text = productDTO.product_style_code;
                data_size.DataSource = pzM.GetProductSizesByID(productDTO.product_id);
            }


        }
    }
}
