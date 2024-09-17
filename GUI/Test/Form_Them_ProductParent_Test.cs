using Nike_Shop_Management.BLL;
using Nike_Shop_Management.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nike_Shop_Management.GUI.Test
{
    public partial class Form_Them_ProductParent_Test : Form
    {
        public ProductParentDTO productParentDTO { get; set; }
        ProductParentManager ppM;
        public string PathHolder { get; set; }

        public Form_Them_ProductParent_Test()
        {
            InitializeComponent();
            initComboBox();
            ppM = new ProductParentManager(new DAL.ProductParentRepository(new DAL.DbContext()));
            u_PictureBox.ClickChanged += U_PictureBox_ClickChanged;
            btnSave.Click += BtnSave_Click;
        }
        public void initComboBox()
        {
            ProductObjectManager poM = new ProductObjectManager(new DAL.ProductObjectRepository(new DAL.DbContext()));
            List<ProductObjectDTO> ListProductObjectDTO = (List<ProductObjectDTO>)poM.GetAll();
            comboBox_product_object.DataSource = ListProductObjectDTO;
            comboBox_product_object.DisplayMember = "product_object_name";
            comboBox_product_object.ValueMember = "product_object_id";

            ProductIconsManager piM = new ProductIconsManager(new DAL.ProductIconsRepository(new DAL.DbContext()));
            List<ProductIconsDTO> ListProductIconsDTO = (List<ProductIconsDTO>)piM.GetAll();
            combox_productIcons.DataSource = ListProductIconsDTO;
            combox_productIcons.ValueMember = "product_icons_id";
            combox_productIcons.DisplayMember = "icon_name";

            ProductCategoryManager pcM = new ProductCategoryManager(new DAL.ProductCategoryRepository(new DAL.DbContext()));
            List<ProductCategoryDTO> ListProductCategoryDTO = (List<ProductCategoryDTO>)pcM.GetAll();
            comboBox_product_category.DataSource = ListProductCategoryDTO;
            comboBox_product_category.ValueMember = "category_product_id";
            comboBox_product_category.DisplayMember = "category_product_name";

        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            // check valid here !!!
            if(txt_product_price.Text.Length!=0)
            {
                backgroundWorker1.RunWorkerAsync();
            }
          

        }

        private void U_PictureBox_ClickChanged(object sender, EventArgs e)
        {
            PathHolder = u_PictureBox.PathThumbail;
        }
        
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            this.u_PictureBox.UploadImage(PathHolder);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (PathHolder != null)
            {
                string fileNameWithoutExtension = System.IO.Path.GetFileNameWithoutExtension(PathHolder);
                PathHolder = "Nike-application/" + fileNameWithoutExtension;
                int flag = ppM.InsertProductParents(new ProductParentDTO()
                {
                    is_new_release = true,
                    product_parent_name = txt_product_name.Text,
                    product_price = txt_product_price.Text.ToString(),
                    thumbnail = PathHolder,
                    product_category_id = int.Parse(comboBox_product_category.SelectedValue.ToString()),
                    product_object_id = int.Parse(comboBox_product_object.SelectedValue.ToString()),
                    product_icons_id = int.Parse(combox_productIcons.SelectedValue.ToString())
                });
                if (flag == 1)
                {
                    MessageBox.Show("Thêm thành công");
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
        }
    }
}
