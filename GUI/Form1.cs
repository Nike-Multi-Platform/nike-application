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
    }
}
