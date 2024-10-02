using Nike_Shop_Management.BLL;
using Nike_Shop_Management.DAL;
using Nike_Shop_Management.DTO;
using Nike_Shop_Management.MappingLayer;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace Nike_Shop_Management.GUI
{
    public partial class EditProductSizeForm : Form
    {
        List<SizeDTO> listInventory;
        List<GetTheSizeProductCurrentResult> listCurrent;
        public EditProductSizeForm()
        {
            InitializeComponent();
            btnLeftToRight.Click += BtnLeftToRight_Click;
            btnRightToLeft.Click += BtnRightToLeft_Click;
            btnSave.Click += BtnSave_Click;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 2; i++)
            {

            }
        }

        private void BtnRightToLeft_Click(object sender, EventArgs e)
        {
            if (ListSizeCurrent.SelectedRows != null)
            {
                var valueSelected = ListSizeCurrent.CurrentRow;
                ListSizeCurrent.Rows.Remove(valueSelected);
                ListSizeInventory.Rows.Add(new object[] { valueSelected.Cells[0].Value.ToString(), valueSelected.Cells[1].Value.ToString(), valueSelected.Cells[2].Value != null ? valueSelected.Cells[2].Value.ToString() : null });
            }
        }

        private void BtnLeftToRight_Click(object sender, EventArgs e)
        {
            if (ListSizeInventory.SelectedRows != null)
            {
                var valueSelected = ListSizeInventory.CurrentRow;
                ListSizeInventory.Rows.Remove(valueSelected);
                ListSizeCurrent.Rows.Add(new object[] {valueSelected.Cells[0].Value.ToString(), valueSelected.Cells[1].Value.ToString(), valueSelected.Cells[2].Value != null ? valueSelected.Cells[2].Value.ToString() : null});
            }
        }

        public void InitData(int product_id, TypeSize typeSize)
        {
            ProductSizeManager pzM = new ProductSizeManager();
            listInventory = pzM.GetProductSizeInventory(product_id, typeSize);
            ListSizeInventory.Columns.Clear();
            ListSizeInventory.Columns.Add("size_id", "Size ID");
            ListSizeInventory.Columns.Add("size_name", "Size Name");
            ListSizeInventory.Columns.Add("product_size_id", "Product_size_id");

            ListSizeCurrent.Columns.Clear();
            ListSizeCurrent.Columns.Add("size_id", "Size ID");
            ListSizeCurrent.Columns.Add("size_name", "Size Name");
            ListSizeCurrent.Columns.Add("product_size_id", "Product_size_id");
            //  ListSizeCurrent.Columns[2].Visible = false;
            foreach (var item in listInventory)
            {
                ListSizeInventory.Rows.Add(new object[] { item.size_id, item.size_name, null });
            }

            ProductColorManager pcM = new ProductColorManager();
            listCurrent = pcM.GetProductSizesByID(product_id);
            foreach (var item in listCurrent)
            {
                ListSizeCurrent.Rows.Add(new object[] { item.size_id, item.size_name, item.product_size_id });
            }


        }
        private void EditProductSizeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
