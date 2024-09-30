﻿using Nike_Shop_Management.BLL;
using Nike_Shop_Management.CloudService;
using Nike_Shop_Management.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Nike_Shop_Management.GUI
{
    public partial class ProductDetailsForm : Form
    {
        CloudIService CloudIService;
        bool flag = false;
        ProductColorsDTO productColorsDTO;
        ProductColorManager pcM = new ProductColorManager(new DAL.ProductColorRepository(new DAL.DbContextDataContext()));
        public int Product_id { get; set; }
        public int ProductParentID { get; set; }
        List<ProductSizeDTO> listSize;
        public ProductDetailsForm()
        {
            InitializeComponent();
            listView1.Click += ListView1_Click;
            btnAdd.Click += BtnAdd_Click;
            btnEdit.Click += BtnEdit_Click;
            btnDelete.Click += BtnDelete_Click;
            comboSize.SelectedValueChanged += ComboSize_SelectedValueChanged;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure delete this item?",
                                          "Message",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (listSize != null)
                {
                    foreach (var item in listSize)
                    {
                        pcM.DeleteProductSize(item.product_size_id);
                    }
                    int flag = pcM.Delete(Product_id);
                    if(flag==1)
                    {
                        MessageBox.Show("Deleted");
                        return;

                    }
                }
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            AddProductColor ad = new AddProductColor();
            TypeSize typeSize = pcM.GetTypeSize(ProductParentID);
            ad.SetConditionSize(typeSize);
            ad.ProductParentID = ProductParentID;
            ad.ShowDialog();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (productColorsDTO != null)
            {
                backgroundWorker1.RunWorkerAsync();
            }
        }
        private void ComboSize_SelectedValueChanged(object sender, EventArgs e)
        {
            if (flag)
            {
                lbl_quantity.Text = pcM.GetQuantity((int)comboSize.SelectedValue).ToString();
            }
        }

        private void ListView1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                u_PictureBox.LoadImgFromUrl(selectedItem.SubItems[1].Text);
                BindingData(int.Parse(listView1.SelectedItems[0].Text), int.Parse(selectedItem.SubItems[2].Text));
            }
        }

        public void BindingData(int product_id, int supplier_id)
        {
            Product_id = product_id;
            listSize = pcM.GetProductSizesByID(product_id);
            List<SupplierDTO> listSupplier = pcM.GetSuppliers(supplier_id);
            if (listSize.Count > 0 && listSupplier.Count > 0)
            {
                comboSize.DataSource = listSize;
                comboSize.DisplayMember = "size_id";
                comboSize.ValueMember = "product_size_id";
                comboSupplier.DataSource = listSupplier;
                comboSupplier.DisplayMember = "supplier_name";
                comboSupplier.ValueMember = "supplier_id";
            }
            productColorsDTO = pcM.GetByID(product_id);
            if (productColorsDTO != null)
            {
                txColorShown.Text = productColorsDTO.product_color_shown;
                tx_price.Text = productColorsDTO.sale_prices;
                txSizeAndFit.Text = productColorsDTO.product_size_and_fit;
                txSolds.Text = productColorsDTO.sold;
                txStylecode.Text = productColorsDTO.product_style_code;
                txTotalStock.Text = productColorsDTO.total_stock;
                tx_description.Text = productColorsDTO.product_description;
                tx_description2.Text = productColorsDTO.product_description2;
                tx_more_info.Text = productColorsDTO.product_more_info;
            }
            flag = true;
        }
        public void PaintData(int product_parent_id)
        {
            listView1.Items.Clear();
            listView1.Columns.Clear();
            listView1.FullRowSelect = false;
            listView1.MultiSelect = false;
            ProductParentID = product_parent_id;
            ProductParentManager ppM = new ProductParentManager(new DAL.ProductParentRepository(new DAL.DbContextDataContext()));
            List<ProductColorsDTO> list = ppM.GetProductColors(product_parent_id);
            ImageList imageListSmall = new ImageList();
            ImageList imageListLarge = new ImageList();
            if (list != null)
            {
                ServiceConfig ServiceConfig = new ServiceConfig();
                int i = 0;
                CloudIService = new CloudIService(ServiceConfig.CloudinaryCloudName, ServiceConfig.CloudinaryApiKey, ServiceConfig.CloudinaryApiSecret);
                foreach (var product in list)
                {

                    PictureBox img_product = new PictureBox();
                    ListViewItem item = new ListViewItem(product.product_id.ToString(), i++);
                    item.SubItems.Add(product.product_img);
                    item.SubItems.Add(product.supplier_id.ToString());
                    img_product.ImageLocation = CloudIService.GetImageUrlByPublicId(product.product_img);
                    try
                    {
                        img_product.Load();
                    }
                    catch (Exception)
                    {
                        img_product.Image = img_product.ErrorImage;
                    }
                    imageListSmall.Images.Add(img_product.Image);
                    imageListLarge.Images.Add(img_product.Image);
                    imageListLarge.ColorDepth = ColorDepth.Depth32Bit;
                    imageListSmall.ColorDepth = ColorDepth.Depth32Bit;
                    listView1.Items.Add(item);
                }
            }
            imageListSmall.ImageSize = new Size(50, 50);
            imageListLarge.ImageSize = new Size(60, 80);

            listView1.LargeImageList = imageListLarge;
            listView1.SmallImageList = imageListSmall;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            u_PictureBox.UploadImage(u_PictureBox.PathThumbail);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            string fileNameWithoutExtension = System.IO.Path.GetFileNameWithoutExtension(u_PictureBox.PathThumbail);
            string linkHolder = "Nike-application/" + fileNameWithoutExtension;
            productColorsDTO.product_color_shown = txColorShown.Text;
            productColorsDTO.product_description = tx_description.Text;
            productColorsDTO.product_description2 = tx_description2.Text;
            productColorsDTO.product_img = linkHolder;
            productColorsDTO.product_more_info = tx_more_info.Text;
            productColorsDTO.product_size_and_fit = txSizeAndFit.Text;
            productColorsDTO.product_style_code = txStylecode.Text;
            productColorsDTO.sale_prices = tx_price.Text;
            productColorsDTO.supplier_id = 1;
            int flag = pcM.Update(productColorsDTO);
            if (flag == 1)
            {
                MessageBox.Show("EDIT SUCCESSFULL");
            }
            else
            {
                MessageBox.Show("failed");
            }

        }
    }
}
