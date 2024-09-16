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
            List<ProductObjectDTO> ListProductObjectDTOs = (List<ProductObjectDTO>)poM.GetAll();
            comboBox_product_category.DataSource = ListProductObjectDTOs;
            comboBox_product_category.DisplayMember = "product_object_name";
            comboBox_product_category.ValueMember = "product_object_id";


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
           if(PathHolder!=null)
            {
                string fileNameWithoutExtension = System.IO.Path.GetFileNameWithoutExtension(PathHolder);
                PathHolder = "Nike-application/" + fileNameWithoutExtension;
                ProductParentDTO pro = new ProductParentDTO
                {
                    is_new_release = true,
                    product_category_id = 2,
                    product_object_id = 1,
                    product_icons_id = 1,
                    product_parent_name = txt_product_name.Text,
                    product_price = txt_product_price.Text.ToString(),
                    thumbnail = PathHolder
                };
                int flag =  ppM.InsertProductParents(pro);
                if(flag==1)
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
