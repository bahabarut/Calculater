using System.Linq.Expressions;

namespace HesapMakinesiMVC.Business.Abstract
{
    public interface IGenericService<T> where T : class
    {
        void Add(T t);
        List<T> GetList(Expression<Func<T, bool>>? condition);
    }
}
