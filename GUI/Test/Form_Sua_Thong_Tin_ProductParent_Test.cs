using Nike_Shop_Management.BLL;
using Nike_Shop_Management.DTO;
using Nike_Shop_Management.DAL;
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
    public partial class Form_Sua_Thong_Tin_ProductParent_Test : Form
    {
        public ProductParentDTO productParentDTO { get; set; }
        ProductParentManager ppM;
        public Form_Sua_Thong_Tin_ProductParent_Test()
        {
            InitializeComponent();
            DbContext db = new DbContext();
            ppM = new ProductParentManager(new ProductParentRepository(db));
            btnEdit.Click += BtnEdit_Click;
            u_PictureBox.ClickChanged += U_PictureBox_ClickChanged;
        }

        private void U_PictureBox_ClickChanged(object sender, EventArgs e)
        {

        }

        public void PaintData(ProductParentDTO productParentDTO)
        {
            txt_productParent_id.Text = productParentDTO.product_parent_id.ToString();
            txt_product_name.Text = productParentDTO.product_parent_name.ToString();
            txt_product_icons_id.Text = productParentDTO.product_icons_id.ToString();
            txt_product_price.Text = productParentDTO.product_price.ToString();
            u_PictureBox.LoadImgFromResources(productParentDTO.thumbnail.ToString());
            cb_new_release.Checked = productParentDTO.is_new_release;
        }

        public event EventHandler FormClosedSuccessfully;
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (txt_product_name.Text.Length == 0 || txt_product_price.Text.Length == 0)
            {
                MessageBox.Show("Don't leave it blank");
                return;
            }
            int flag = ppM.EditProductParents(new ProductParentDTO()
            {
                thumbnail = u_PictureBox.Thumbnail,
                product_price = txt_product_price.Text,
                product_parent_id = int.Parse(txt_productParent_id.Text),
                is_new_release = cb_new_release.Checked,
                product_icons_id = int.Parse(txt_product_icons_id.Text),
                product_parent_name = txt_product_name.Text,
                product_category_id = 2,
                product_object_id = 1,
            });
            if(flag==1)
            {
                MessageBox.Show("Edit successful");
                FormClosedSuccessfully?.Invoke(this, EventArgs.Empty);
                this.Close();
            }
            else
            {
                MessageBox.Show("Edit failed");
            }
        }

        private void Form_Sua_Thong_Tin_ProductParent_Test_Load(object sender, EventArgs e)
        {

        }

    }
}
