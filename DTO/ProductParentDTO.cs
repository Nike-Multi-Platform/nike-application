using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nike_Shop_Management.DTO
{
    class ProductParentDTO
    {
        private int id;
        private string category_product_name;
        private string category_product_desciption;
        

        public int Id { get => id; set => id = value; }
        public string Category_product_name { get => category_product_name; set => category_product_name = value; }
        public string Category_product_desciption { get => category_product_desciption; set => category_product_desciption = value; }
         
    }
}
