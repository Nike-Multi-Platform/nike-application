using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nike_Shop_Management.MappingLayer;
using Nike_Shop_Management.DTO;
namespace Nike_Shop_Management.DAL
{
    class ProductObjectRepository
    {
        private readonly DbContext _db;
        public ProductObjectRepository(DbContext db)
        {
            _db = db;
        }
        public List<ProductObjectDTO> GetAll()
        {
            List<ProductObjectDTO> list = _db.product_objects.Select(temp => AutoMapperConfig.Mapper.Map<product_object, ProductObjectDTO>(temp)).ToList();
            return list;
        }
        public int Add(ProductObjectDTO enity)
        {
            try
            {
                _db.product_objects.InsertOnSubmit(AutoMapperConfig.Mapper.Map<ProductObjectDTO, product_object>(enity));
                _db.SubmitChanges();
                return 1;
            }
            catch (Exception)
            {

                return 0;
            }
        }

        internal int Delete(int id)
        {
            try
            {
                var existEntiy = _db.product_objects.Where(temp => temp.product_object_id == id).FirstOrDefault();
                if (existEntiy != null)
                {
                    _db.product_objects.DeleteOnSubmit(existEntiy);
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

        public int Update(ProductObjectDTO enity)
        {
            try
            {
                var existEntity = _db.product_objects.Where(temp => temp.product_object_id == enity.product_object_id).FirstOrDefault();
                if (existEntity != null)
                {
                    existEntity.product_object_name = enity.product_object_name;
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
