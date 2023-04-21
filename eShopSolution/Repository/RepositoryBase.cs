using AutoMapper;
using eShopSolution.Api.Data.DbContext;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace eShopSolution.Api.Repository
{
    public abstract class RepositoryBase<T> : IRepository<T> where T : class
    {
        private readonly EShopDbContext _context;

        protected RepositoryBase(EShopDbContext context)
        {
            _context = context;
        }
        public virtual void Add(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }


        public virtual void Update(T entity)
        {
            _context.Set<T>().Attach(entity);
            _context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }
        public virtual void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
        }
        public virtual void Delete(int? id)
        {
            var entity = _context.Set<T>().Find(id);
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
        }
        public virtual void DeleteMulti(Expression<Func<T, bool>> where)
        {
            IEnumerable<T> objects = _context.Set<T>().Where<T>(where).AsEnumerable();
            foreach (T obj in objects)
                _context.Set<T>().Remove(obj);
        }
        public virtual void DeleteRange(List<T> obj)
        {
            _context.Set<T>().RemoveRange(obj);
        }
        public bool CheckUniqueName(Expression<Func<T, bool>> where)
        {
            //Check Unique Name of T

            return _context.Set<T>().Where(where).FirstOrDefault() == null ? true : false;
        }
        public virtual void AddMulti(IEnumerable<T> entity)
        {
            _context.Set<T>().AddRange(entity);
        }
        public virtual T GetSingleById(int? id)
        {
            return _context.Set<T>().Find(id);
        }
        public virtual IEnumerable<T> GetMany(Expression<Func<T, bool>> where, string includes)
        {
            return _context.Set<T>().Where(where).ToList();
        }
        public virtual int Count(Expression<Func<T, bool>> where)
        {
            return _context.Set<T>().Count(where);
        }

        public IEnumerable<T> GetAll(string[] includes = null)
        {
            //HANDLE INCLUDES FOR ASSOCIATED OBJECTS IF APPLICABLE
            if (includes != null && includes.Count() > 0)
            {
                var query = _context.Set<T>().Include(includes.First());
                foreach (var include in includes.Skip(1))
                    query = query.Include(include);
                return query.AsQueryable();
            }

            return _context.Set<T>().AsQueryable();
        }

        public T GetSingleByCondition(Expression<Func<T, bool>> expression, string[] includes = null)
        {
            if (includes != null && includes.Count() > 0)
            {
                var query = _context.Set<T>().Include(includes.First());
                foreach (var include in includes.Skip(1))
                    query = query.Include(include);
                return query.FirstOrDefault(expression);
            }
            return _context.Set<T>().FirstOrDefault(expression);
        }

        public virtual IEnumerable<T> GetMulti(Expression<Func<T, bool>> predicate, string[] includes = null)
        {
            //HANDLE INCLUDES FOR ASSOCIATED OBJECTS IF APPLICABLE
            if (includes != null && includes.Count() > 0)
            {
                var query = _context.Set<T>().Include(includes.First());
                foreach (var include in includes.Skip(1))
                    query = query.Include(include);
                return query.Where<T>(predicate).AsQueryable<T>();
            }

            return _context.Set<T>().Where<T>(predicate).AsQueryable<T>();
        }

        public virtual IEnumerable<T> GetMultiPaging(Expression<Func<T, bool>> predicate, out int total, int index = 0, int size = 20, string[] includes = null)
        {
            int skipCount = index * size;
            IQueryable<T> _resetSet;

            //HANDLE INCLUDES FOR ASSOCIATED OBJECTS IF APPLICABLE
            if (includes != null && includes.Count() > 0)
            {
                var query = _context.Set<T>().Include(includes.First());
                foreach (var include in includes.Skip(1))
                    query = query.Include(include);
                _resetSet = predicate != null ? query.Where<T>(predicate).AsQueryable() : query.AsQueryable();
            }
            else
            {
                _resetSet = predicate != null ? _context.Set<T>().Where<T>(predicate).AsQueryable() : _context.Set<T>().AsQueryable();
            }

            _resetSet = skipCount == 0 ? _resetSet.Take(size) : _resetSet.Skip(skipCount).Take(size);
            total = _resetSet.Count();
            return _resetSet.AsQueryable();
        }

        public bool CheckContains(Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>().Count<T>(predicate) > 0;
        }

    }
}
