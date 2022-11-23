using Microsoft.EntityFrameworkCore;
using StolenCarPTBackend.Model;
using StolenCarPTBackend.Model.Base;

namespace StolenCarPTBackend.Repository
{
    public interface IRepository<T> where T : BaseEntity
    {
        T Create(T item);
        T Update(T item);
        T FindById(long id);
        List<T> FindAll();
        void Delete(long id);
        bool Exists(long id);
       

    }
}
