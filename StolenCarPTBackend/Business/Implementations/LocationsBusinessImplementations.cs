using StolenCarPTBackend.Data.Converter.Implementations;
using StolenCarPTBackend.Data.VO;
using StolenCarPTBackend.Model;
using StolenCarPTBackend.Repository;

namespace StolenCarPTBackend.Business.Implementations
{
    public class LocationsBusinessImplementations : ILocationsBusiness
    {
        private readonly IRepository<Locations>  _repository;

        private readonly LocationsConverter _converter;

        public LocationsBusinessImplementations(IRepository<Locations> repository) 
        {
            _repository = repository;
            _converter = new LocationsConverter();
        }

        public LocationsVO Create(LocationsVO locations)
        {
            var locationsEntity = _converter.Parse(locations);
            locationsEntity = _repository.Create(locationsEntity);
            return _converter.Parse(_repository.Create(locationsEntity));
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }

        public List<LocationsVO> FindAll()
        {
            return _converter.Parse(_repository.FindAll());
        }

        public LocationsVO FindById(long id)
        {
            return _converter.Parse(_repository.FindById(id));
        }

        public LocationsVO Update(LocationsVO locations)
        {
            var locationsEntity = _converter.Parse(locations);
            locationsEntity = _repository.Update(locationsEntity);
            return _converter.Parse(_repository.Update(locationsEntity));
        }
    }
}
