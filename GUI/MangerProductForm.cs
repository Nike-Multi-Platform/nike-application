﻿using System;
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
        ProductParentManager ppM = new ProductParentManager(new DAL.ProductParentRepository(new DAL.DbContextDataContext()));
        List<ProductParentDTO> listProductParent;
        public string linkHolder { get; set; }
        public string linkHolderTemp { get; set; }
        public ProductParentDTO productParentClicked { get; set; }
        public MangerProductForm()
        {
            InitializeComponent();
            InitData();
            comboProductObjectFilter.SelectedIndexChanged += ComboProductObjectFilter_SelectedIndexChanged;
            comboProductCategoriesFileter.SelectedIndexChanged += ComboProductCategoriesFileter_SelectedValueChanged;
            ComboSubCategoriesFilter.SelectedIndexChanged += ComboSubCategoriesFilter_SelectedIndexChanged;
            ComboDateFilter.SelectedIndexChanged += ComboDateFilter_SelectedIndexChanged;
            comboPriceFilter.SelectedIndexChanged += ComboPriceFilter_SelectedIndexChanged;
            btnEdit.Click += BtnEdit_Click;
            btnShowMore.Click += BtnShowMore_Click;
        
            btnAdd.Click += BtnAdd_Click;
            btnSearch.Click += BtnSearch_Click;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
           // search thì cx dậy lun nha :< 
            
        }

        private void ComboPriceFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            // code phần sort ở đây nha. ý tưởng là duyệt vào cái panel lấy ra cái danh sách  hoặc là dùng cái list danh sách biến toàn cục để sort
        }

        private void ComboDateFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            // code phần sort ở đây nha. ý tưởng là duyệt vào cái panel lấy ra cái danh sách  hoặc là dùng cái list danh sách biến toàn cục để sort

        }


        private void BtnAdd_Click(object sender, EventArgs e)
        {
            AddProductParentForm addProductParentForm = new AddProductParentForm();
            addProductParentForm.ShowDialog();

        }


        private void BtnShowMore_Click(object sender, EventArgs e)
        {
            if (productParentClicked != null)
            {

                CRUD_ProductDetails crud = new CRUD_ProductDetails();
                crud.PaintData(productParentClicked.product_parent_id);
                crud.ShowDialog();
            }

        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (txProductName.Text.Length == 0 || txProductPrice.Text.Length == 0)
            {
                MessageBox.Show("Don't leave it blank");
                return;
            }

            backgroundWorker1.RunWorkerAsync();
        }

        private void ComboSubCategoriesFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataPanel();
        }
        private void LoadDataPanel()
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
                    u.DeleteClicked += U_DeleteClicked;
                    u.DoubleClicked += U_DoubleClicked;
                }
            }
        }

        private void U_DoubleClicked(object sender, EventArgs e)
        {
            if (productParentClicked != null)
            {
                CRUD_ProductDetails crud = new CRUD_ProductDetails();
                crud.PaintData(productParentClicked.product_parent_id);
                crud.ShowDialog();
            }
        }

        private void U_DeleteClicked(object sender, EventArgs e)
        {
            U_ProductParent clickedProduct = sender as U_ProductParent;
            if (clickedProduct != null)
            {
                int flag = ppM.DeleteProductParents(clickedProduct.productParentDTO.product_parent_id);
                if (flag == 1)
                {
                    MessageBox.Show("Item deleted successfully.");
                }
                else
                {
                    MessageBox.Show("Delete failed");
                }
                LoadDataPanel();
                PaintDataDetails(null);
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
            SubCategoryManager sbM = new SubCategoryManager(new DAL.SubcategoryRepository(new DAL.DbContextDataContext()));
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
            ProductCategoriesManager pcM = new ProductCategoriesManager(new DAL.ProductCategoriesRepository(new DAL.DbContextDataContext()));
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
            comboPriceFilter.Items.Add("Desc");
            comboPriceFilter.Items.Add("Asce");
            ComboDateFilter.Items.Add("The Newest");
            ComboDateFilter.Items.Add("The Lastest");
            ProductObjectManager poM = new ProductObjectManager(new DAL.ProductObjectRepository(new DAL.DbContextDataContext()));
            List<ProductObjectDTO> list = (List<ProductObjectDTO>)poM.GetAll();
            list.Add(new ProductObjectDTO { product_object_name = "ALL", product_object_id = 0 });
            comboProductObjectFilter.DataSource = list;
            comboProductObjectFilter.DisplayMember = "product_object_name";
            comboProductObjectFilter.ValueMember = "product_object_id";
        }

        public void PaintDataDetails(ProductParentDTO productParent)
        {
            if (productParent != null)
            {
                List<ProductColorsDTO> productDTOs = ppM.GetProductColors(productParent.product_parent_id);
                u_PictureBox.LoadImgFromUrl(productParent.thumbnail);
                txProductPrice.Text = productParent.product_price.ToString();
                txProductName.Text = productParent.product_parent_name.ToString();
                lbl_count_types.Text = productDTOs.Count.ToString();
                linkHolder = productParent.thumbnail;
            }
            else
            {
                u_PictureBox.LoadImgFromUrl("");
                txProductName.Text = "";
                txProductPrice.Text = "";
                lbl_count_types.Text = "0";
            }

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if(u_PictureBox.PathThumbail==null)
            {
                string str = productParentClicked.thumbnail.Replace("Nike-application/", "");
                linkHolder = str;
               
            }
            else
            {
                linkHolder = u_PictureBox.PathThumbail;
            }
          
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (productParentClicked != null)
            {
                string fileNameWithoutExtension = System.IO.Path.GetFileNameWithoutExtension(linkHolder);
                linkHolder = "Nike-application/" + fileNameWithoutExtension;
                int flag = ppM.EditProductParents(new ProductParentDTO()
                {
                    thumbnail = linkHolder,
                    product_price = txProductPrice.Text,
                    product_parent_id = productParentClicked.product_parent_id,
                    is_new_release = true,
                    product_icons_id = 1,
                    product_parent_name = txProductName.Text,
                    sub_categories_id = productParentClicked.sub_categories_id
                });
                if (flag == 1)
                {
                    MessageBox.Show("Edit successful");
                }
                else
                {
                    MessageBox.Show("Edit failed");
                }
            }
            linkHolder = "";
            LoadDataPanel();
            PaintDataDetails(null);
        }
    }
}
