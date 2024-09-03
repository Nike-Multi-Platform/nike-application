using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nike_Shop_Management
{
    public partial class u_DataGridView : UserControl
    {
        public u_DataGridView()
        {
            InitializeComponent();
            dataGridView.MouseDown += DataGridView_MouseDown; ;
        }

        private void DataGridView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hitTestInfo = dataGridView.HitTest(e.X, e.Y);

                if (hitTestInfo.RowIndex >= 0)
                {
                    Point mousePosition = dataGridView.PointToClient(MousePosition);
                    cmsData.Show(dataGridView, mousePosition);
                }
            }
        }

        public void LoadData<T>(IList<T> list)
        {
            this.dataGridView.DataSource = list;
        }
    }
}
