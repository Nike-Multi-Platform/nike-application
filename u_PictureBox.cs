using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nike_Shop_Management
{
    public partial class u_PictureBox : UserControl
    {
        public u_PictureBox()
        {
            InitializeComponent();
            btnEdit.Click += BtnEdit_Click;
        }
        public event EventHandler ClickChanged;
        public string Thumbnail { get; set; }
        public string PathThumbail { get; set; }
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "Image Files (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp",
                Title = "Chọn một hình ảnh"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Thumbnail = Path.GetFileName(openFileDialog.FileName);
                Picture.Image = Image.FromFile(openFileDialog.FileName);
                PathThumbail = Path.GetFullPath(openFileDialog.FileName);
                ClickChanged?.Invoke(sender, EventArgs.Empty);
            }
        }

        /// <summary>
        /// hàm được dùng để load hình ảnh lên picture, đơn giản là truyền vào cái tên ảnh thôi
        /// </summary>
        /// <param name="path"></param>
        public void LoadImgFromResources(string path)
        {
            Thumbnail = path;
            Picture.Image = (Image)Properties.Resources.ResourceManager.GetObject(path);
            if (Picture.Image == null)
            {
                // keeu vinh
                Picture.Image = (Image)Properties.Resources._default;
            }
        }

    }
}
