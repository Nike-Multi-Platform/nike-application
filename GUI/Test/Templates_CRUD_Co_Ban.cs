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
    public partial class Templates_CRUD_Co_Ban : UserControl
    {
        public Templates_CRUD_Co_Ban()
        {
            InitializeComponent();
        }

        public void PaintTheInputText(params object[] listObject)
        {
            // Thiết lập TableLayoutPanel có 2 cột chia đều
            tableLayoutPanel_Show.ColumnCount = 2;
            tableLayoutPanel_Show.RowCount = listObject.Length * 2; // Mỗi điều khiển chiếm 2 hàng

            // Đặt chiều rộng các cột chia đều (50%)
            tableLayoutPanel_Show.ColumnStyles.Clear();
            tableLayoutPanel_Show.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel_Show.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));

            // Đặt tất cả các hàng có kích thước tự động
            tableLayoutPanel_Show.RowStyles.Clear();
            for (int i = 0; i < tableLayoutPanel_Show.RowCount; i++)
            {
                tableLayoutPanel_Show.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            }

            int row = 0;

            foreach (var item in listObject)
            {
                if (item is Control control)
                {
                    // Tạo một Label tương ứng với mỗi Control
                    Label label = new Label();
                    label.Margin = new Padding(50, 8, 0, 0);
                    label.Text = "Label for " + control.GetType().Name;  // Đặt tên label dựa trên loại control
                    label.AutoSize = true;  // Đảm bảo label có kích thước phù hợp với nội dung

                    // Thêm Label vào cột 0 và Control vào cột 1 trong cùng hàng
                    tableLayoutPanel_Show.Controls.Add(label, 0, row);
                    tableLayoutPanel_Show.Controls.Add(control, 1, row);

                    // Tăng chỉ số hàng để chuyển sang hàng tiếp theo
                    row++;
                }
                else
                {
                    Console.WriteLine($"Item không phải là Control: {item.ToString()}");
                }
            }
        }



        public void SetList<T>(IList<T>list )
        {
            u_DataGridView1.LoadData(list);
        }
        public void SetTitle(string nameTitle)
        {
            Label_Name_of_Bussiness.Text = nameTitle;
        }

        private void u_DataGridView1_Load(object sender, EventArgs e)
        {

        }
    }
}
