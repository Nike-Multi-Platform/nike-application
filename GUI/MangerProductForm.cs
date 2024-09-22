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
namespace Nike_Shop_Management.GUI
{
    public partial class MangerProductForm : Form
    {
        ProductParentManager ppM = new ProductParentManager(new DAL.ProductParentRepository(new DAL.DbContext()));
        List<ProductParentDTO> listProductParent;

        public ProductParentDTO productParentClicked { get; set; }
        public MangerProductForm()
        {
            InitializeComponent();
            InitData();
            comboProductObjectFilter.SelectedIndexChanged += ComboProductObjectFilter_SelectedIndexChanged;
            comboProductCategoriesFileter.SelectedIndexChanged += ComboProductCategoriesFileter_SelectedValueChanged;
            ComboSubCategoriesFilter.SelectedIndexChanged += ComboSubCategoriesFilter_SelectedIndexChanged;
            btnEdit.Click += BtnEdit_Click;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {

        }

        private void ComboSubCategoriesFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

            SubCategoryDTO valueSelected = (SubCategoryDTO)ComboSubCategoriesFilter.SelectedItem;
            listProductParent = ppM.GetProductParentsBySubCategory(valueSelected.sub_categories_id);
            if (panel_product_parent.Controls.Count > 0)
            {
                panel_product_parent.Controls.Clear();
            }
            if (listProductParent != null)
            {
                foreach (var item in listProductParent)
                {
                    U_ProductParent u = new U_ProductParent();
                    u.PaintData(item);
                    panel_product_parent.Controls.Add(u);
                    u.Clicked += U_Clicked;
                }
            }

        }

        private void U_Clicked(object sender, EventArgs e)
        {
            U_ProductParent clickedProduct = sender as U_ProductParent;
            if (clickedProduct != null)
            {
                productParentClicked = clickedProduct.productParentDTO;
                PaintDataDetails(productParentClicked);
            }
        }

        private void ComboProductCategoriesFileter_SelectedValueChanged(object sender, EventArgs e)
        {
            if (panel_product_parent.Controls.Count > 0)
            {
                panel_product_parent.Controls.Clear();
            }
            ProductCategoriesDTO selectedValue = (ProductCategoriesDTO)comboProductCategoriesFileter.SelectedItem;
            SubCategoryManager sbM = new SubCategoryManager(new DAL.SubcategoryRepository(new DAL.DbContext()));
            List<SubCategoryDTO> list = (List<SubCategoryDTO>)sbM.GetAllByID(selectedValue.categories_id);
            ComboSubCategoriesFilter.DataSource = list;
            ComboSubCategoriesFilter.DisplayMember = "sub_categories_name";
            ComboSubCategoriesFilter.ValueMember = "sub_categories_id";
            ComboSubCategoriesFilter.Enabled = true;

        }

        private void ComboProductObjectFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (panel_product_parent.Controls.Count > 0)
            {
                panel_product_parent.Controls.Clear();
            }
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

        public void PaintDataDetails(ProductParentDTO productParent)
        {
            u_PictureBox.LoadImgFromUrl(productParent.thumbnail);
            txProductID.Text = productParent.product_parent_id.ToString();
            txProductPrice.Text = productParent.product_price.ToString();
            txProductName.Text = productParent.product_parent_name.ToString();

        }
    }
}
