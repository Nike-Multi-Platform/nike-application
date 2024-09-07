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
            if (l != null)
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
                    existingProductParent.product_parent_name = productParent.product_parent_name;
                    existingProductParent.product_object_id = productParent.product_object_id;
                    existingProductParent.product_category_id = productParent.product_category_id;
                    existingProductParent.thumbnail = productParent.thumbnail;
                    if (decimal.TryParse(productParent.product_price, out decimal price))
                    {
                        existingProductParent.product_price = price;
                    }
                    else
                    {
                        return 0;
                    }

                    existingProductParent.is_new_release = productParent.is_new_release;
                    existingProductParent.product_icons_id = productParent.product_icons_id;
                    _db.SubmitChanges();
                    return 1;
                }
                return 0;
            }
            catch (Exception e)
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

        public List<ProductObjectDTO> GetProductObjects()
        {
            List<ProductObjectDTO> l = _db.product_objects.Select(temp => AutoMapperConfig.Mapper.Map<product_object, ProductObjectDTO>(temp)).ToList();
            if (l != null)
            {
                return l;
            }
            return null;
        }

        public List<ProductIconsDTO> GetProductIcons()
        {
            List<ProductIconsDTO> l = _db.product_icons.Select(temp => AutoMapperConfig.Mapper.Map<product_icon, ProductIconsDTO>(temp)).ToList();
            if (l != null)
            {
                return l;
            }
            return null;
        }
        public List<ProductCategoryDTO> GetProductCategories()
        {
            List<ProductCategoryDTO> l = _db.category_products.Select(temp => AutoMapperConfig.Mapper.Map<category_product, ProductCategoryDTO>(temp)).ToList();
            if (l != null)
            {
                return l;
            }
            return null;
        }
    }
}
