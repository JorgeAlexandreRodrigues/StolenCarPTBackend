using StolenCarPTBackend.Data.VO;

namespace StolenCarPTBackend.Business
{
    public interface ILocationsBusiness
    {
        LocationsVO Create(LocationsVO locations);
        LocationsVO Update(LocationsVO locations);
        LocationsVO FindById(long id);
        List<LocationsVO> FindAll();
        void Delete(long id);

    }
}
