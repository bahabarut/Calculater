using System.Linq.Expressions;

namespace HesapMakinesiMVC.DataAccess.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        public void Add(T t);
        public List<T> GetList(Expression<Func<T, bool>>? condition);
    }
}
