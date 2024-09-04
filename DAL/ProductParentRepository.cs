using Nike_Shop_Management.MappingLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nike_Shop_Management.DTO;
namespace Nike_Shop_Management.DAL
{
    class ProductParentRepository
    {
        private readonly DbContext _db;

        public ProductParentRepository(DbContext db)
        {
            _db = db;
        }
        public List<ProductParentDTO> getProductParents()
        {
            List<ProductParentDTO> l = _db.product_parents.Select(emp => AutoMapperConfig.Mapper.Map<product_parent, ProductParentDTO>(emp)).ToList();
            if (l != null)
            {
                return l;
            }
            return null;
        }

        public List<ProductDTO> getProductColor(int product_parent_id)
        {
            List<product> products = _db.products.Where(emp => (int)emp.product_parent_id == product_parent_id).ToList();
            List<ProductDTO> l = new List<ProductDTO>();
            foreach (product p in products)
            {
                l.Add(AutoMapperConfig.Mapper.Map<product, ProductDTO>(p));
            }
            if(l!=null)
            {
                return l;
            }
            return null;
        }

        public void Save(ProductParentDTO productParent)
        {
            //throw new NotImplementedException();

            _db.product_parents.InsertOnSubmit(AutoMapperConfig.Mapper.Map<ProductParentDTO, product_parent>(productParent));
        }
        public int Edit(ProductParentDTO productParent)
        {
            try
            {
                var existingProductParent = _db.product_parents.FirstOrDefault(p => p.product_parent_id == productParent.product_parent_id);
                if (existingProductParent != null)
                {
                    var productLinq = AutoMapperConfig.Mapper.Map<ProductParentDTO, product_parent>(productParent);
                    existingProductParent = productLinq;
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

        public List<ProductParentDTO> Search(string inputSearch)
        {
            try
            {
                bool isNumericSearch = int.TryParse(inputSearch, out int numericSearch);
                List<ProductParentDTO> result = _db.product_parents.Where(pd => pd.product_parent_name.Contains(inputSearch)
                || pd.product_parent_id == numericSearch || pd.product_price == numericSearch)
                    .ToList().Select(p => AutoMapperConfig.Mapper.Map<product_parent, ProductParentDTO>(p)).ToList();
                if (result != null)
                {
                    return result;
                }
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public int Delete(int product_parent_id)
        {
            try
            {
                var existProductParents = _db.product_parents.Where(pd => pd.product_parent_id == product_parent_id).FirstOrDefault();
                _db.product_parents.DeleteOnSubmit(existProductParents);
                _db.SubmitChanges();
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
