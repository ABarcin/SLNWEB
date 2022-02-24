using SLNWEB.Core;
using SLNWEB.DAL.Mapping;
using SLNWEB.DAO.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLNWEB.DAL.Repository
{
    public class ProductDAL : EntityRepository<Product, NorthwindEntities>, IProductDAL
    {
        public List<ProductVM> GetAllProductVMByCategoryID(object id)
        {
            return new ProductMapping().ListProductToListProductVM(this.GetAll(x => x.CategoryID == Convert.ToInt32(id))).ToList();
        }

        public int UpdateProduct(ProductVM productVM)
        {
             
            return this.Update(new ProductMapping().ProductVMToProduct(productVM)); 
        }
        public List<ProductVM> GetAllProduct()
        {
            return new ProductMapping().ListProductToListProductVM(this.GetAll()).ToList();
        }
        public ProductVM GetProductByID(int id)
        {
            return new ProductMapping().ProductToProductVM(this.GetAll(x=>x.ProductID==id).SingleOrDefault());
        }

    }
}
