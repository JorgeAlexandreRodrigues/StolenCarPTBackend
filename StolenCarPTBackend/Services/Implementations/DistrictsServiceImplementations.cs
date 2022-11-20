using StolenCarPTBackend.Model;
using StolenCarPTBackend.Model.Context;

namespace StolenCarPTBackend.Services.Implementations
{
    public class DistrictsServiceImplementations : IDistrictsService
    {
        private MySqlContext _context;

        public DistrictsServiceImplementations(MySqlContext context) 
        {
            _context= context;
        }

        public Districts Create(Districts districts)
        {
            return districts;
        }

        public void Delete(long id)
        {
            throw new NotImplementedException();
        }

        public List<Districts> FindAll()
        {
            return _context.Districts.ToList();
        }

        public Districts FindById(long id)
        {
            throw new NotImplementedException();
        }

        public Districts Update(Districts districts)
        {
            throw new NotImplementedException();
        }
    }
}
