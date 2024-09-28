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
    public partial class AddProductColor : Form
    {
        public AddProductColor()
        {
            InitializeComponent();
            InitData();
        }

        private void AddProductColor_Load(object sender, EventArgs e)
        {

        }
        public void InitData()
        {
            SupplierManager supplierManager = new SupplierManager();
             comboSupplier.DataSource= supplierManager.GetAll();
            comboSupplier.DisplayMember = "supplier_name";
            comboSupplier.ValueMember = "supplier_id";
        }
        public void SetCondition(TypeSize type)
        {
            switch (type)
            {
                case TypeSize.Shoes:
                    InitDataComboSizeShoes();
                    break;
                case TypeSize.Clothing:
                    InitDataComboSizeClothing();
                    break;
                
                default:
                    break;
            }
        }

        public void InitDataComboSizeClothing()
        {
            SizeManager sizeManager = new SizeManager();
            List<SizeDTO> sizeDTOs = (List<SizeDTO>)sizeManager.GetAll();
            foreach (var item in sizeDTOs)
            {
                if (item.size_name.Contains("EU"))
                {
                 checked_list_Size.Items.Add(item.size_name);
                }      
            }
        }
        public void InitDataComboSizeShoes()
        {
            SizeManager sizeManager = new SizeManager();
            List<SizeDTO> sizeDTOs = (List<SizeDTO>)sizeManager.GetAll();
            foreach (var item in sizeDTOs)
            {
                if (!item.size_name.Contains("EU"))
                {
                    checked_list_Size.Items.Add(item.size_name);
                }
            }

        }
        private void kryptonListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
