using Nike_Shop_Management.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nike_Shop_Management.MappingLayer;
namespace Nike_Shop_Management.DAL
{
    class ProductSizeRepository
    {
        private readonly DbContext _db;
        //IRepository<T>
        public ProductSizeRepository(DbContext db)
        {
            _db = db;
        }

        internal List<ProductSizeDTO> GetProductSizesByID(int id)
        {
            var list = _db.product_sizes.Where(t => t.product_id == id).ToList().Select(t => AutoMapperConfig.Mapper.Map<product_size, ProductSizeDTO>(t)).ToList();
            if (list != null)
            {
                return list;
            }
            return null;

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="productSize"></param>
        /// <returns>1 nếu thành công, 0 nếu thất bại</returns>
        internal int Update(ProductSizeDTO productSize)
        {
            try
            {
                var existPz = _db.product_sizes.Where(p => p.product_size_id == productSize.product_size_id).FirstOrDefault();
                if(existPz!=null)
                {
                    existPz.soluong = productSize.soluong;
                    _db.SubmitChanges();
                return 1;
                }
                return 0;
            }
            catch (Exception)
            {

                return 0;
            }
        }
    }
}
