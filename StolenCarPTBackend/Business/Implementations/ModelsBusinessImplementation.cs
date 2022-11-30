using StolenCarPTBackend.Data.Converter.Implementations;
using StolenCarPTBackend.Data.VO;
using StolenCarPTBackend.Model;
using StolenCarPTBackend.Repository;

namespace StolenCarPTBackend.Business.Implementations
{
    public class ModelsBusinessImplementation : IModelsBusiness
    {
        private readonly IRepository<Models> _repository;
        private readonly ModelsConverter _converter;

        public ModelsBusinessImplementation(IRepository<Models> repository)
        {
            _repository = repository;
            _converter = new ModelsConverter();
        }

        public ModelsVO Create(ModelsVO model)
        {
            var modelsEntity = _converter.Parse(model);
            modelsEntity = _repository.Create(modelsEntity);
            return _converter.Parse(_repository.Create(modelsEntity));
        } 
        
        public ModelsVO Update(ModelsVO model)
        {
            var modelsEntity = _converter.Parse(model);
            modelsEntity = _repository.Update(modelsEntity);
            return _converter.Parse(_repository.Update(modelsEntity));
        } 
        
        public List<ModelsVO> FindAll()
        {
            return _converter.Parse(_repository.FindAll());
        }
        
        public ModelsVO FindById(long id)
        {
            return _converter.Parse(_repository.FindById(id));
        }

        public void Delete(long id)
        {
            throw new NotImplementedException();
        }
    }
}
