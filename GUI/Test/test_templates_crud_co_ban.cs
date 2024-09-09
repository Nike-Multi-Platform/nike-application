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

namespace Nike_Shop_Management.GUI.Test
{
    public partial class test_templates_crud_co_ban : Form
    {
        private readonly UserAccountManager accountManager;
        ProductParentManager ppM;
        public test_templates_crud_co_ban()
        {
            InitializeComponent();
            //  accountManager = new UserAccountManager(new DAL.UserAccountRepository(new DAL.DbContext()));
            ppM = new ProductParentManager(new DAL.ProductParentRepository(new DAL.DbContext()));
            LoadData();
        }
        public void LoadData()
        {
            List<ProductParentDTO> list = ppM.GetProductParents();
            templates_CRUD_Co_Ban1.SetList(list);
            templates_CRUD_Co_Ban1.SetTitle(ppM.GetType().Name);
            TextBox textBox = new TextBox();
            TextBox textBox1 = new TextBox(); 
            TextBox textBox2 = new TextBox(); 
            TextBox textBox3 = new TextBox();
            TextBox textBox4 = new TextBox();

            templates_CRUD_Co_Ban1.PaintTheInputText(textBox, textBox1, textBox2, textBox3, textBox4);
        }
    }
}
