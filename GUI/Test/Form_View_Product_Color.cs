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
        //ProductSizeManager pzM;
        ProductColorManager pcM;
        public ProductDTO _ProductDTO { get; set; }
        public string linkHolder { get; set; }
        public event EventHandler FormClosedSuccessfully;

        public Form_View_Product_Color()
        {
            InitializeComponent();
            pcM = new ProductColorManager(new DAL.ProductColorRepository(new DbContext()));
            btnAddSize.Click += BtnAddSize_Click;
            btnEdit.Click += BtnEdit_Click;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
             if(txt_product_id.Text.Length ==0)
            {
                MessageBox.Show("Some error! Try later, please");return;
            }
           
            backgroundWorker1.RunWorkerAsync();
        }

        private void BtnAddSize_Click(object sender, EventArgs e)
        {
        /// viết form thêm size vào đây =)) !! rồi tính gì tính    
        }

        public void PaintData(ProductDTO productDTO, ProductParentDTO productParentDTO)
        {
            if(productDTO!=null && productParentDTO!=null)
            {
                _ProductDTO = productDTO;
                txt_product_id.Text = productDTO.product_id.ToString();
                u_PictureBox1.LoadImgFromUrl(productDTO.product_img);
                lbl_NameProductParent.Text = productParentDTO.product_parent_name;
                txt_product_color_shown.Text = productDTO.product_color_shown;
                txt_product_description.Text = productDTO.product_description;
                txt_product_description2.Text = productDTO.product_description2;
                txt_product_more_info.Text = productDTO.product_more_info;
                txt_product_size_and_fit.Text = productDTO.product_size_and_fit;
                txt_product_style_code.Text = productDTO.product_style_code;
                data_size.DataSource = pcM.GetProductSizesByID(productDTO.product_id);
            }


        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            linkHolder = u_PictureBox1.UploadImage(u_PictureBox1.PathThumbail);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (linkHolder != "")
            {
                string fileNameWithoutExtension = System.IO.Path.GetFileNameWithoutExtension(linkHolder);
                linkHolder = "Nike-application/" + fileNameWithoutExtension;
                _ProductDTO.product_img = linkHolder;
                _ProductDTO.product_color_shown = txt_product_color_shown.Text;
                _ProductDTO.product_description = txt_product_description.Text;
                _ProductDTO.product_description2 = txt_product_description2.Text;
                _ProductDTO.product_style_code = txt_product_style_code.Text;
                _ProductDTO.product_size_and_fit = txt_product_size_and_fit.Text;
                _ProductDTO.product_more_info = txt_product_more_info.Text;
                int flag = pcM.Update(_ProductDTO);
                if (flag == 1)
                {
                    MessageBox.Show("Edit successful");
                    FormClosedSuccessfully?.Invoke(this, EventArgs.Empty);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Update failed");
                }
            }
        }
    }
}
