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
    public class CategoryDAL : EntityRepository<Category, NorthwindEntities>, ICategoryDAL
    {
        CategoryMapping mapping = new CategoryMapping();
        public List<CategoryVM> GetAllCategories()
        {
            return mapping.ListCategoryToListCategoryVM(this.GetAll()).ToList();
        }
    }
}
