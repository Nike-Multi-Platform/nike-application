using Nike_Shop_Management.BLL;
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
        /// <summary>
        /// đây là hàm được sử dụng với mục đích truyền vào các control để khởi tạo ra các component tự động ở trong panel
        /// bên trong chứa các đối tượng textbox,... để cho việc thêm, xóa, sửa,...
        /// </summary>
        /// <param name="controls"></param>
        public void PaintTheInputText(params Control[] controls)
        {
            tableLayoutPanel_Show.ColumnCount = 2;
            tableLayoutPanel_Show.RowCount = controls.Length;

            tableLayoutPanel_Show.ColumnStyles.Clear();
            tableLayoutPanel_Show.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel_Show.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));

            tableLayoutPanel_Show.RowStyles.Clear();
            for (int i = 0; i < tableLayoutPanel_Show.RowCount; i++)
            {
                tableLayoutPanel_Show.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            }

            tableLayoutPanel_Show.Controls.Clear();

            int row = 0;

            foreach (var control in controls)
            {
                // Tạo một Label tương ứng với mỗi Control
                Label label = new Label
                {
                    Margin = new Padding(10, 8, 0, 0),
                    Text = "lbl_" + control.Name, 
                    AutoSize = true  
                };

                tableLayoutPanel_Show.Controls.Add(label, 0, row);
                tableLayoutPanel_Show.Controls.Add(control, 1, row);

                row++;
            }
        }
        /// <summary>
        /// hàm được gọi ra để truyền danh sách biến về bên trong datagirdview
        /// cũng như cho việc setup component
        /// </summary>
        /// <param name="list"></param>
        public void SetForm<T>(IList<T> list)
        {
            u_DataGridView1.LoadData(list);
            List<Control> controls = new List<Control>();

            foreach (DataGridViewColumn column in u_DataGridView1.Columns)
            {
                Type columnType = column.ValueType;
                if (columnType == typeof(string) || columnType == typeof(int))
                {
                    TextBox tx = new TextBox
                    {
                        Name = "txt_" + column.HeaderText
                    };
                    controls.Add(tx);
                }
            }

            PaintTheInputText(controls.ToArray());
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
