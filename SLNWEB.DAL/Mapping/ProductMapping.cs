using SLNWEB.Core;
using SLNWEB.DAO.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLNWEB.DAL.Mapping
{
    public class ProductMapping
    {
        public Product ProductVMToProduct(ProductVM vm)
        {
            return new Product()
            {
                ProductID = vm.ProductID,
                ProductName = vm.ProductName,
                CategoryID = vm.CategoryID,
                QuantityPerUnit = vm.QuantityPerUnit,
                UnitPrice = vm.UnitPrice,
                UnitsInStock = vm.UnitsInStock,
                Discontinued = vm.Discontinued
            };
        }
        public ProductVM ProductToProductVM(Product p)
        {
            return new ProductVM()
            {
                ProductID = p.ProductID,
                ProductName = p.ProductName,
                CategoryID = p.CategoryID,
                QuantityPerUnit = p.QuantityPerUnit,
                UnitPrice = p.UnitPrice,
                UnitsInStock = p.UnitsInStock,
                Discontinued = p.Discontinued
            };
        }
        public List<ProductVM> ListProductToListProductVM(List<Product> products)
        {
            List<ProductVM> productVMs = new List<ProductVM>();
            foreach (Product item in products)
            {
                productVMs.Add(ProductToProductVM(item));
            }
            return productVMs;
        }
        public List<Product> ListProductVMToListProduct(List<ProductVM> vms)
        {
            List<Product> products = new List<Product>();
            foreach (ProductVM item in vms)
            {
                products.Add(ProductVMToProduct(item));
            }
            return products;
        }
    }
}
