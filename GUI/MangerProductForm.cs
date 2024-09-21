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
using Nike_Shop_Management.DTO;
namespace Nike_Shop_Management.GUI
{
    public partial class MangerProductForm : Form
    {

        public MangerProductForm()
        {
            InitializeComponent();
            InitData();
            comboProductObjectFilter.SelectedIndexChanged += ComboProductObjectFilter_SelectedIndexChanged;
            comboProductObjectFilter.SelectedIndexChanged += ComboProductObjectFilter_SelectedIndexChanged1;
        }

        private void ComboProductObjectFilter_SelectedIndexChanged1(object sender, EventArgs e)
        {
          // y chang object filter mai lam` =))
        }

        private void ComboProductObjectFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedValue = comboProductObjectFilter.SelectedValue?.ToString();
            ProductCategoriesManager pcM = new ProductCategoriesManager(new DAL.ProductCategoriesRepository(new DAL.DbContext()));
            List<ProductCategoriesDTO> list = new List<ProductCategoriesDTO>();

            if (selectedValue != "0")
            {
                if (!comboProductCategoriesFileter.Enabled)
                {
                    comboProductCategoriesFileter.Enabled = true;
                }
                list = (List<ProductCategoriesDTO>)pcM.GetProductCategoriesByID(int.Parse(selectedValue));
            }
            else
            {
                list = (List<ProductCategoriesDTO>)pcM.GetAll();
            }

            comboProductCategoriesFileter.DataSource = list;
            comboProductCategoriesFileter.DisplayMember = "categories_name";
            comboProductCategoriesFileter.ValueMember = "categories_id";
        }

        public void InitData()
        {
            ProductObjectManager poM = new ProductObjectManager(new DAL.ProductObjectRepository(new DAL.DbContext()));
            List<ProductObjectDTO> list = (List<ProductObjectDTO>)poM.GetAll();
            list.Add(new ProductObjectDTO { product_object_name = "ALL", product_object_id = 0 });
            comboProductObjectFilter.DataSource = list;
            comboProductObjectFilter.DisplayMember = "product_object_name";
            comboProductObjectFilter.ValueMember = "product_object_id";
        }

    }
}
