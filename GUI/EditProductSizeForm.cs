using Nike_Shop_Management.BLL;
using Nike_Shop_Management.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nike_Shop_Management.GUI
{
    public partial class EditProductSizeForm : Form
    {
        List<SizeDTO> list;
        public EditProductSizeForm()
        {
            InitializeComponent();
            
        }
        public void InitData(int product_id,TypeSize typeSize)
        {
            ProductSizeManager pzM = new ProductSizeManager();
            list =  pzM.GetProductSizeInventory(product_id, typeSize);
            ListSizeInventory.DataSource = list;
        }
        private void EditProductSizeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
