using HesapMakinesiMVC.DataAccess.Abstract;
using HesapMakinesiMVC.DataAccess.Repository;
using HesapMakinesiMVC.Entities;

namespace HesapMakinesiMVC.DataAccess.Concrete
{
    public class ProcessDal : GenericRepository<Process>, IProcessDal
    {
    }
}
