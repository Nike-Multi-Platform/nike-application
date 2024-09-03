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
        }


        private void ProductParent_Test_Load(object sender, EventArgs e)
        {
            //List<ProductCategoryDTO> = ppM.
        }
        public void Load_Data()
        {
            List<ProductParentDTO> list = ppM.GetProductParents();
            u_DataGridView1.LoadData(list);
        }

        private void datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        //private void datagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.RowIndex >= 0)
        //    {
        //        if (dg_productColor.RowCount > 0)
        //        {
        //            dg_productColor.DataSource = null;
        //            dg_productColor.Rows.Clear();
        //        }
        //        List<ProductDTO> list = new List<ProductDTO>();
        //        list = ppM.GetProductColors((int)datagrid.Rows[e.RowIndex].Cells[0].Value);
        //        if (list != null)
        //        {
        //            dg_productColor.DataSource = list;
        //        }
        //        else
        //        {
        //            MessageBox.Show("haha");
        //        }
        //    }
        //}
    }
}
