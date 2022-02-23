using SLNWEB.Core;
using SLNWEB.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLNWEB.DAL.Repository
{
    public class EntityRepository<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity
        where TContext : DbContext, new()
    {
        public EntityRepository()
        {
            _context = new TContext();
        }
        private readonly TContext _context;
        public int Add(TEntity entity)
        {
            int value = 0;
            using (TContext db=new TContext())
            {
                var addedEntity = db.Entry(entity);
                addedEntity.State = EntityState.Added;
                value = db.SaveChanges();
            }
            return value;
        }

        public TEntity Get(object id)
        {
            using (TContext db=new TContext())
            {
                return db.Set<TEntity>().SingleOrDefault();
            }
        }

        public List<TEntity> GetAll(Func<TEntity, bool> condition=null)
        {
            using (TContext db = new TContext())
            {
                return db.Set<TEntity>().Where(condition).ToList();
            }
        }

        public int Update(TEntity entity)
        {
            int value = 0;
            using (TContext db = new TContext())
            {
                var updatedEntity = db.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                value = db.SaveChanges();
            }
            return value;
        }
        public int Delete(TEntity entity)
        {
            int value = 0;
            using (TContext db = new TContext())
            {
                var deletedEntity = db.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                value = db.SaveChanges();
            }
            return value;
        }

    }
}
