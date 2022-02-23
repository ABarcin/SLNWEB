using SLNWEB.Core;
using SLNWEB.DAO.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLNWEB.DAL.Mapping
{
    public class CategoryMapping
    {
        public CategoryVM CategoryToCategoryVM(Category category)
        {
            return new CategoryVM()
            {
                CategoryID=category.CategoryID,
                CategoryName=category.CategoryName
            };
        }
        public Category CategoryVMToCategory(CategoryVM vm)
        {
            return new Category()
            {
                CategoryID = vm.CategoryID,
                CategoryName = vm.CategoryName
            };
        }
        public List<CategoryVM> ListCategoryToListCategoryVM(List<Category> categories)
        {
            List<CategoryVM> categoryVMs = new List<CategoryVM>();
            foreach (Category item in categories)
            {
                categoryVMs.Add(CategoryToCategoryVM(item));
            }
            return categoryVMs;
        }
        public List<Category> ListCategoryVMToListCategory(List<CategoryVM> vms)
        {
            List<Category> categories = new List<Category>();
            foreach (CategoryVM item in vms)
            {
                categories.Add(CategoryVMToCategory(item));
            }
            return categories;
        }
    }
}
