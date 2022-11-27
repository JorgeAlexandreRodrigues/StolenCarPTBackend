using StolenCarPTBackend.Data.Converter.Implementations;
using StolenCarPTBackend.Data.VO;
using StolenCarPTBackend.Model;
using StolenCarPTBackend.Repository;

namespace StolenCarPTBackend.Business.Implementations
{
    public class DistrictsBusinessImplementations : IDistrictsBusiness
    {
        private readonly IRepository<Districts>  _repository;

        private readonly DistrictsConverter _converter;

        public DistrictsBusinessImplementations(IRepository<Districts> repository) 
        {
            _repository = repository;
            _converter = new DistrictsConverter();
        }

        public DistrictsVO Create(DistrictsVO districts)
        {
            var districtsEntity = _converter.Parse(districts);
            districtsEntity = _repository.Create(districtsEntity);
            return _converter.Parse(_repository.Create(districtsEntity));
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }

        public List<DistrictsVO> FindAll()
        {
            return _converter.Parse(_repository.FindAll());
        }

        public DistrictsVO FindById(long id)
        {
            return _converter.Parse(_repository.FindById(id));
        }

        public DistrictsVO Update(DistrictsVO districts)
        {
            var districtsEntity = _converter.Parse(districts);
            districtsEntity = _repository.Update(districtsEntity);
            return _converter.Parse(_repository.Update(districtsEntity));
        }
    }
}
