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
            List<ProductParentDTO> list = ppM.GetDatasProductParent();
            datagrid.DataSource = list;

        }
    }
}
