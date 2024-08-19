using Nike_Shop_Management.BLL;
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
    public partial class Form1 : Form
    {
        private readonly UserAccountManager accountManager;
        public Form1()
        {
            InitializeComponent();
            DbContext db = new DbContext();
            accountManager = new UserAccountManager(new UserAccountRepository(db));
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
        
        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            UserAccountDTO user = accountManager.GetAccount("111@gmail.com", "123");
            if(user!=null)
            {
                MessageBox.Show( user.First_name+ user.Last_name);
            }
            else
            {
                MessageBox.Show("Khong tim thay du lieu ");
            }
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
                ucc.Address = address.Text;
                // các thuộc tính khác
                int fl = accountManager.EditUser(ucc);
                if(fl==1)
                {
                    MessageBox.Show("Cap nhat thanh cong");
                    load_data();
                }
            }
        }
    }
}
