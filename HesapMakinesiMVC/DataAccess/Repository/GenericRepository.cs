using HesapMakinesiMVC.DataAccess.Abstract;
using HesapMakinesiMVC.Entities;
using System.Linq.Expressions;

namespace HesapMakinesiMVC.DataAccess.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Add(T t)
        {
            using (Context context = new Context())
            {
                context.Set<T>().Add(t);
                context.SaveChanges();
            }
        }

        public List<T> GetList(Expression<Func<T, bool>>? condition)
        {
            using (Context context = new Context())
            {
                var query = context.Set<T>().AsQueryable();
                if (condition is not null)
                    query = query.Where(condition);
                return query.ToList();
            }
        }
    }
}
