using SLNWEB.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLNWEB.DAL.Repository
{
    public class ProductDAL : EntityRepository<Product, NorthwindEntities>, IProductDAL
    {
    }
}
