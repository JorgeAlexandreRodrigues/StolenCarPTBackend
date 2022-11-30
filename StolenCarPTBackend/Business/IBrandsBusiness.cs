using StolenCarPTBackend.Data.VO;

namespace StolenCarPTBackend.Business
{
    public interface IBrandsBusiness
    {
        BrandsVO Create(BrandsVO brands);
        BrandsVO Update(BrandsVO brands);
        BrandsVO FindById(long id);
        List<BrandsVO> FindAll();
        void Delete(long id);

    }
}
