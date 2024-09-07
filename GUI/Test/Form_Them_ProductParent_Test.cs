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
    public partial class Form_Them_ProductParent_Test : Form
    {

        public ProductParentDTO productParentDTO { get; set; }
        public string PathHolder { get; set; }
        public Form_Them_ProductParent_Test()
        {
            InitializeComponent();
            u_PictureBox.ClickChanged += U_PictureBox_ClickChanged;
        }

        private void U_PictureBox_ClickChanged(object sender, EventArgs e)
        {

        }
    }
}
