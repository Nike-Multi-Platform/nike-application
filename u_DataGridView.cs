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
        public object DataSelected { get; set; }
        public int GetIndexSelected { get; set; }
        public event EventHandler ClickChanged;
        public u_DataGridView()
        {
            InitializeComponent();
            dataGridView.MouseDown += DataGridView_MouseDown;
            dataGridView.CellClick += GetDataGridSelected;
        }
        private void DataGridView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hitTestInfo = dataGridView.HitTest(e.X, e.Y);

                if (hitTestInfo.RowIndex >= 0)
                {
                    dataGridView.ClearSelection();
                    dataGridView.Rows[hitTestInfo.RowIndex].Selected = true;
                    DataSelected = dataGridView.Rows[hitTestInfo.RowIndex].DataBoundItem;

                    Point mousePosition = dataGridView.PointToClient(MousePosition);
                    cmsData.Show(dataGridView, mousePosition);

                }
            }
        }
        public void GetDataGridSelected(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                GetIndexSelected = -1;
                DataSelected = dataGridView.Rows[e.RowIndex].DataBoundItem;
                ClickChanged?.Invoke(this, EventArgs.Empty);
            }
        }
        public void LoadData<T>(IList<T> list)
        {
            if (this.dataGridView.RowCount > 0)
            {
                this.dataGridView.DataSource = null;
            }

            this.dataGridView.DataSource = list;
        }

        private void suaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DataSelected != null)
            {
                GetIndexSelected = 0;
                ClickChanged?.Invoke(this, EventArgs.Empty);
            }
        }



        private void xoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DataSelected != null)
            {
                GetIndexSelected = 1;
                ClickChanged?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
