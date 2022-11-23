using StolenCarPTBackend.Model;
using StolenCarPTBackend.Repository;

namespace StolenCarPTBackend.Business.Implementations
{
    public class DistrictsBusinessImplementations : IDistrictsBusiness
    {
        private readonly IRepository<Districts>  _repository;

        public DistrictsBusinessImplementations(IRepository<Districts> repository) 
        {
            _repository = repository;
        }

        public Districts Create(Districts districts)
        {
            return _repository.Create(districts);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }

        public List<Districts> FindAll()
        {
            return _repository.FindAll();
        }

        public Districts FindById(long id)
        {
            return _repository.FindById(id);
        }

        public Districts Update(Districts districts)
        {
            return _repository.Update(districts);
        }
    }
}
