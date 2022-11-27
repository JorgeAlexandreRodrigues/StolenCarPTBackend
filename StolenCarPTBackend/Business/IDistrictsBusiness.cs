using StolenCarPTBackend.Data.VO;

namespace StolenCarPTBackend.Business
{
    public interface IDistrictsBusiness
    {
        DistrictsVO Create(DistrictsVO districts);
        DistrictsVO Update(DistrictsVO districts);
        DistrictsVO FindById(long id);
        List<DistrictsVO> FindAll();
        void Delete(long id);

    }
}
