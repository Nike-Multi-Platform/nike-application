using Nike_Shop_Management.DTO;
using Nike_Shop_Management.MappingLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nike_Shop_Management.DAL
{
    class ProductColorRepository
    {
        private readonly DbContextDataContext _db;

        public ProductColorRepository(DbContextDataContext db)
        {
            _db = db;
        }

        internal int Add(ProductColorsDTO entity)
        {
            try
            {
                var tempEntity = AutoMapperConfig.Mapper.Map<ProductColorsDTO, product>(entity);
                _db.products.InsertOnSubmit(tempEntity);
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
                var existEntity = _db.products.Where(t => t.product_id == id).FirstOrDefault();
                if (existEntity != null)
                {
                    _db.products.DeleteOnSubmit(existEntity);
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

        internal ProductColorsDTO GetByID(int id)
        {
            var productDTO = _db.products.Where(t => t.product_id == id).FirstOrDefault();
            if (productDTO != null)
            {
                return AutoMapperConfig.Mapper.Map<product, ProductColorsDTO>(productDTO);
            }
            return null;
        }

        internal ProductParentDTO BelongsTo()
        {
            throw new NotImplementedException();
        }

        internal int DeleteProductSize(int product_size_id)
        {
            try
            {
                var existEntity = _db.product_sizes.Where(t => t.product_size_id == product_size_id).FirstOrDefault();
                if(existEntity!=null)
                {
                    _db.product_sizes.DeleteOnSubmit(existEntity);
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

        internal int Update(ProductColorsDTO entity)
        {
            try
            {
                var existEntity = _db.products.Where(t => t.product_id == entity.product_id).FirstOrDefault();
                if (existEntity != null)
                {
                    existEntity.product_more_info = entity.product_more_info;
                    existEntity.product_img = entity.product_img;
                    existEntity.product_size_and_fit = entity.product_size_and_fit;
                    existEntity.product_style_code = entity.product_style_code;
                    existEntity.product_color_shown = entity.product_color_shown;
                    existEntity.product_description = entity.product_description;
                    existEntity.product_description2 = entity.product_description2;
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<ProductSizeDTO> GetProductSize(int product_id)
        {
            var list = _db.product_sizes.Where(t => t.product_id == product_id).ToList().Select(temp => AutoMapperConfig.Mapper.Map<product_size, ProductSizeDTO>(temp)).ToList();
            return list;
        }

        public List<ProductImgDTO> GetImages(int product_id)
        {
            var list = _db.product_imgs.Where(t => t.product_id == product_id).ToList().Select(temp => AutoMapperConfig.Mapper.Map<product_img, ProductImgDTO>(temp)).ToList();
            return list;
        }
    }
}
