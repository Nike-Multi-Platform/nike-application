using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nike_Shop_Management.BLL;
using Nike_Shop_Management.DAL;
using Nike_Shop_Management.DTO;

namespace Nike_Shop_Management.GUI.Test
{
    public partial class ProductParent_Test : Form
    {
        ProductParentManager ppM;

        public ProductParent_Test()
        {
            InitializeComponent();
            DbContext db = new DbContext();
            ppM = new ProductParentManager(new DAL.ProductParentRepository(db));
            Load_Data();
            u_ProductParent.ClickChanged += U_DataGridView1_ClickChanged;
        }

        private void U_DataGridView1_ClickChanged(object sender, EventArgs e)
        {
            ProductParentDTO product = (ProductParentDTO)u_ProductParent.DataSelected;
            if (product != null)
            {
                if (u_ProductParent.GetIndexSelected == 1)
                {
                }
                if (u_ProductParent.GetIndexSelected == 0)
                {

                    Form_Sua_Thong_Tin_ProductParent_Test form_Sua_Thong_Tin_ProductParent_Test = new Form_Sua_Thong_Tin_ProductParent_Test();

                    form_Sua_Thong_Tin_ProductParent_Test.ShowDialog();
                }
                if (u_ProductParent.GetIndexSelected == -1)
                {
                    //MessageBox.Show("hehe");
                    List<ProductDTO> list = ppM.GetProductColors(product.product_parent_id);
                    u_ProductColors.LoadData(list);
                }
            }
        }

        private void ProductParent_Test_Load(object sender, EventArgs e)
        {
            //List<ProductCategoryDTO> = ppM.
        }
        public void Load_Data()
        {
            List<ProductParentDTO> list = ppM.GetProductParents();
            u_ProductParent.LoadData(list);
        }

        private void datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

    }
}
