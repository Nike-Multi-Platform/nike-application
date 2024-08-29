using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nike_Shop_Management.DTO
{
    class ProductDTO
    {
        public int product_id { get => product_id; set => product_id = value; }
        public int product_parent_id { get => product_parent_id; set => product_parent_id = value; }
        public string product_more_info { get => product_more_info; set => product_more_info = value; }
        public string product_img { get => product_img; set => product_img = value; }
        public string product_size_and_fit { get => product_size_and_fit; set => product_size_and_fit = value; }
        public string product_style_code { get => product_style_code; set => product_style_code = value; }
        public string product_color_shown { get => product_color_shown; set => product_color_shown = value; }
        public string product_description { get => product_description; set => product_description = value; }
        public string product_description2 { get => product_description2; set => product_description2 = value; }

        public ProductImgDTO product_color_img { get; set; }
        public ProductSizeDTO productSize { get; set; }


    }
}
