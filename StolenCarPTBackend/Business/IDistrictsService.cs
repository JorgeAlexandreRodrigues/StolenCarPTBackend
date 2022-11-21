using StolenCarPTBackend.Model;

namespace StolenCarPTBackend.Business
{
    public interface IDistrictsService
    {
        Districts Create(Districts districts);
        Districts Update(Districts districts);
        Districts FindById(long id);
        List<Districts> FindAll();
        void Delete(long id);

    }
}
