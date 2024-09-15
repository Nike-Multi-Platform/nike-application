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
        Form_Sua_Thong_Tin_ProductParent_Test form_Sua_Thong_Tin_ProductParent_Test;
        public ProductParent_Test()
        {
            InitializeComponent();
            Load_Data();
            u_ProductParent.ClickChanged += U_DataGridView1_ClickChanged;
            u_ProductColors.ClickChanged += U_ProductColors_ClickChanged;
        }

        private void U_ProductColors_ClickChanged(object sender, EventArgs e)
        {
            ProductDTO productDTO = (ProductDTO)u_ProductColors.DataSelected;
            ProductParentDTO productParent = (ProductParentDTO)u_ProductParent.DataSelected;
            if(productDTO!=null && productParent!=null)
            {
                if(u_ProductColors.GetIndexSelected == 0 )
                {
                    Form_View_Product_Color p = new Form_View_Product_Color();
                    p.PaintData(productDTO, productParent);
                    p.ShowDialog();

                }
            }
        }

        private void Form_Sua_Thong_Tin_ProductParent_Test_FormClosedSuccessfully(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void U_DataGridView1_ClickChanged(object sender, EventArgs e)
        {
            ProductParentDTO product = (ProductParentDTO)u_ProductParent.DataSelected;
            if (product != null)
            {
                if (u_ProductParent.GetIndexSelected == 1)
                {
                    var result = MessageBox.Show("Are you sure you want to delete this item?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    // Kiểm tra kết quả từ hộp thoại
                    if (result == DialogResult.Yes)
                    {
                        int deleteResult = ppM.DeleteProductParents(product.product_parent_id);

                        if (deleteResult == 1)
                        {
                            MessageBox.Show("Item deleted successfully.");
                            Load_Data();
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete item.");
                        }
                    }             
                }
                if (u_ProductParent.GetIndexSelected == 0)
                {
                    form_Sua_Thong_Tin_ProductParent_Test = new Form_Sua_Thong_Tin_ProductParent_Test();
                    form_Sua_Thong_Tin_ProductParent_Test.PaintData(product);
                    form_Sua_Thong_Tin_ProductParent_Test.FormClosedSuccessfully += Form_Sua_Thong_Tin_ProductParent_Test_FormClosedSuccessfully;
                    form_Sua_Thong_Tin_ProductParent_Test.productParentDTO = product;
                    form_Sua_Thong_Tin_ProductParent_Test.ShowDialog();
                }
                if (u_ProductParent.GetIndexSelected == -1)
                {
                    List<ProductDTO> list = ppM.GetProductColors(product.product_parent_id);
                    u_ProductColors.LoadData(list);
                }
            }
        }

        private void ProductParent_Test_Load(object sender, EventArgs e)
        {
            Load_Data();
        }
        public void Load_Data()
        {
            ppM = new ProductParentManager(new DAL.ProductParentRepository(new DbContext()));
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
