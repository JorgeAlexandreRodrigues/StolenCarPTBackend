using StolenCarPTBackend.Data.VO;

namespace StolenCarPTBackend.Business
{
    public interface IModelsBusiness
    {
        ModelsVO Create(ModelsVO model);
        ModelsVO Update(ModelsVO model);
        ModelsVO FindById(long id);
        List<ModelsVO> FindAll();
        void Delete(long id);
    }
}
