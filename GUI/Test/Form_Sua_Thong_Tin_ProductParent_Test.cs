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
        }
        public void PaintData(ProductParentDTO productParentDTO)
        {
            txt_product_id.Text = productParentDTO.product_parent_id.ToString();
            txt_product_name.Text = productParentDTO.product_parent_name.ToString();
            txt_product_icons_id.Text = productParentDTO.product_icons_id.ToString();
            txt_product_price.Text = productParentDTO.product_price.ToString();
            //pc_Product_path.Image = new i
            cb_new_release.Checked = productParentDTO.is_new_release;
        }
        private void BtnEdit_Click(object sender, EventArgs e)
        {

        }

        private void Form_Sua_Thong_Tin_ProductParent_Test_Load(object sender, EventArgs e)
        {

        }
    }
}
