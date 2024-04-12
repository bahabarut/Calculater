using HesapMakinesiMVC.Business.Abstract;
using HesapMakinesiMVC.DataAccess.Abstract;
using HesapMakinesiMVC.Entities;
using System.Linq.Expressions;

namespace HesapMakinesiMVC.Business.Concrete
{
    public class ProcessManager : IProcessService
    {
        private readonly IProcessDal _processDal;

        public ProcessManager(IProcessDal processDal)
        {
            _processDal = processDal;
        }

        public void Add(Process t)
        {
            _processDal.Add(t);
        }

        public List<Process> GetList(Expression<Func<Process, bool>>? condition)
        {
            return _processDal.GetList(condition);
        }
    }
}
