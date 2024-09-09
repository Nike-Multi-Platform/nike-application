﻿using Nike_Shop_Management.BLL;
using Nike_Shop_Management.DAL;
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
    public partial class CRUD_Account_Test : Form
    {
        private readonly UserAccountManager accountManager;
        public CRUD_Account_Test()
        {
            InitializeComponent();
            accountManager = new UserAccountManager(new UserAccountRepository(new DbContext()));
            load_data();
            
        }
        public void load_data()
        {
          
            List<UserAccountDTO> list = new List<UserAccountDTO>();
       
            list = accountManager.GetUserAccounts();
            dataGridView.DataSource = list;
            dataGridView.Columns[11].Visible = false; // Hidden ID
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        
       

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txID.Text = dataGridView.Rows[e.RowIndex].Cells[11].Value.ToString();
                address.Text = dataGridView.Rows[e.RowIndex].Cells[5].Value != null ? dataGridView.Rows[e.RowIndex].Cells[5].Value.ToString() : " ";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txID.Text!=String.Empty)
            {
                UserAccountDTO ucc = accountManager.GetUserByID(Int32.Parse(txID.Text.ToString()));
                ucc.user_address = address.Text;
                // các thuộc tính khác
                int fl = accountManager.EditUser(ucc);
                if(fl==1)
                {
                    MessageBox.Show("Cap nhat thanh cong");
                    load_data();
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(address.Text!=String.Empty)
            {
                var result = accountManager.SearchUser(address.Text);
                if(result!=null)
                {
                    dataGridView.DataSource = result;
                }
                else
                {
                    load_data();
                }
            }
            else
            {
                load_data();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(txID.Text!=String.Empty)
            {
                int flag = accountManager.DeleleUser(Int32.Parse(txID.Text));
                if(flag==1)
                {
                    MessageBox.Show("Xóa thành công");
                    load_data();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
