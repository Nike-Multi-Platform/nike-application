using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nike_Shop_Management.DAL;
using Nike_Shop_Management.DTO;
namespace Nike_Shop_Management.BLL
{
    class ProductParentManager
    {
        private readonly ProductParentRepository _productParentRepository;

        public ProductParentManager(ProductParentRepository productParentRepository)
        {
            _productParentRepository = productParentRepository;
        }
        /// <summary>
        /// lấy ra danh sách các sản phẩm parent đại diện
        /// </summary>
        /// <returns>null nếu danh sách rỗng</returns>
        public List<ProductParentDTO> GetProductParents()
        {
            return _productParentRepository.getProductParents();
        }
        /// <summary>
        /// lấy ra các sản phẩm là đối tượng con của product Parent, /t tham số truyền vào là 1 khóa chỉnh của productParent kiểu int
        /// </summary>
        /// <param name="product_parent_id"></param>
        /// <returns> null nếu danh sách rỗng</returns>
        public List<ProductDTO> GetProductColors(int product_parent_id)
        {
            return _productParentRepository.getProductColor(product_parent_id);
        }
        /// <summary>
        /// thêm vào hệ thống một sản phẩm
        /// </summary>
        /// <param name="productParent"></param>
        /// <returns>1 nếu thêm thành công, 0 nếu thêm thất bại thì hỏi thằng Vinh nó debug cho</returns>
        public int InsertProductParents(ProductParentDTO productParent)
        {
            try
            {
                _productParentRepository.Save(productParent);
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        /// <summary>
        /// Hàm với mục đích là sửa thông tin product parent
        /// </summary>
        /// <param name="productParent">tham số là 1 productParentDTO</param>
        /// <returns>1 là sửa thành công, 0 là sửa thất bại thì hỏi thằng Vinh nó debug cho</returns>
        public int EditProductParents(ProductParentDTO productParent)
        {
            return _productParentRepository.Edit(productParent);
        }
        /// <summary>
        /// Hàm xóa 1 sản phẩm trong product parentm tham số truyền vào là 1 khóa chính int của product cần xóa
        /// </summary>
        /// <param name="product_parent_id"></param>
        /// <returns> 1 nếu xóa thành công , 0 nếu xóa thất bại - có thể liên quan đến khóa ngoại</returns>
        public int DeleteProductParents(int product_parent_id)
        {
            return _productParentRepository.Delete(product_parent_id);
        }
        /// <summary>
        /// tìm kiếm product parent, đầu vào có thể là giá, mã sản phẩm, tên sản phẩm
        /// </summary>
        /// <param name="inputSearch"></param>
        /// <returns>list sản phẩm null nếu rỗng</returns>
        public List<ProductParentDTO> SearchProductParents(string inputSearch)
        {
            return _productParentRepository.Search(inputSearch);
        }

        public List<ProductObjectDTO> GetProductObjects()
        {
            return _productParentRepository.GetProductObjects();
        }
        public List<ProductIconsDTO> GetProductIcons()
        {
            return _productParentRepository.GetProductIcons();
        }

        public List<ProductCategoryDTO> GetProductCategories()
        {
            return _productParentRepository.GetProductCategories();
        }
    }
}
