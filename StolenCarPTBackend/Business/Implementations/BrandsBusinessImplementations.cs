using StolenCarPTBackend.Data.Converter.Implementations;
using StolenCarPTBackend.Data.VO;
using StolenCarPTBackend.Model;
using StolenCarPTBackend.Repository;

namespace StolenCarPTBackend.Business.Implementations
{
    public class BrandsBusinessImplementations : IBrandsBusiness
    {
        private readonly IRepository<Brands>  _repository;

        private readonly BrandsConverter _converter;

        public BrandsBusinessImplementations(IRepository<Brands> repository) 
        {
            _repository = repository;
            _converter = new BrandsConverter();
        }

        public BrandsVO Create(BrandsVO brands)
        {
            var brandsEntity = _converter.Parse(brands);
            brandsEntity = _repository.Create(brandsEntity);
            return _converter.Parse(_repository.Create(brandsEntity));
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }

        public List<BrandsVO> FindAll()
        {
            return _converter.Parse(_repository.FindAll());
        }

        public BrandsVO FindById(long id)
        {
            return _converter.Parse(_repository.FindById(id));
        }

        public BrandsVO Update(BrandsVO brands)
        {
            var brandsEntity = _converter.Parse(brands);
            brandsEntity = _repository.Update(brandsEntity);
            return _converter.Parse(_repository.Update(brandsEntity));
        }
    }
}
