using SLNWEB.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLNWEB.DAL.Repository
{
    public interface IEntityRepositoryDAL<T> where T:class,IEntity
    {
        List<T> GetAll(Func<T, bool> condition=null);
        T Get(object id);
        int Add(T entity);
        int Update(T entity);
        int Delete(T entity);
    }
}
