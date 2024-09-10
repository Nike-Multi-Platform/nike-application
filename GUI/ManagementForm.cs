﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nike_Shop_Management.GUI;
using ComponentFactory.Krypton.Toolkit;
using Nike_Shop_Management.BLL;
using Nike_Shop_Management.DTO;

namespace Nike_Shop_Management.GUI
{
    public partial class ManagementForm : Form
    {
        Util util = new Util();
        public ManagementForm()
        {
            InitializeComponent();
        }
        private void btn_Home_Click(object sender, EventArgs e)
        {
            menuTransition.Start();

        }
        bool sidebarExpland = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpland)
            {
                sidebar.Width -= 5;
                if (sidebar.Width <= 60)
                {
                    sidebarExpland = false;
                    sidebarTransition.Stop();
                }
            }
            else
            {
                sidebar.Width += 5;
                if (sidebar.Width >= 200)
                {
                    sidebarExpland = true;
                    sidebarTransition.Stop();
                }
            }
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void btn_product_Click(object sender, EventArgs e)
        {
            util.OpenChildForm(new GUI.ProductForm(), panelBody);
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {

        }

        private void btn_ParentProduct_Click(object sender, EventArgs e)
        {
            util.OpenChildForm(new GUI.Test.ProductParent_Test(), panelBody);
        }

        private void btnProductObject_Click(object sender, EventArgs e)
        {
            ProductObjectManager p = new ProductObjectManager(new DAL.ProductObjectRepository(new DAL.DbContext()));
            GenericService<ProductObjectDTO> o = new GenericService<ProductObjectDTO>(p);
            util.OpenChildForm(new GUI.Test.test_templates_crud_co_ban<ProductObjectDTO>(o),panelBody);
        }

        private void btn_customer_Click(object sender, EventArgs e)
        {
            UserAccountManager p = new UserAccountManager(new DAL.UserAccountRepository(new DAL.DbContext()));
            GenericService<UserAccountDTO> o = new GenericService<UserAccountDTO>(p);

            util.OpenChildForm(new GUI.Test.test_templates_crud_co_ban<UserAccountDTO>(o), panelBody);
        }
    }
}
