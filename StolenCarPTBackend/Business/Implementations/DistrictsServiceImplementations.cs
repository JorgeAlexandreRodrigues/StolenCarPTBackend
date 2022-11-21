using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using StolenCarPTBackend.Model;
using StolenCarPTBackend.Model.Context;

namespace StolenCarPTBackend.Business.Implementations
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
            try
            {
                _context.Add(districts);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
            return districts;
        }

        public void Delete(long id)
        {
            var result = _context.Districts.SingleOrDefault(p => p.Id.Equals(id));
            if (result != null)
            {
                try
                {
                    _context.Districts.Remove(result);
                    _context.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public List<Districts> FindAll()
        {
            return _context.Districts.ToList();
        }

        public Districts FindById(long id)
        {
            return _context.Districts.SingleOrDefault(p => p.Id.Equals(id));
        }

        public Districts Update(Districts districts)
        {
            if(!Exists(districts.Id)) return new Districts();

            var result = _context.Districts.SingleOrDefault(p => p.Id.Equals(districts.Id));

            if (result != null)
            {
                try
                {
                    _context.Entry(result).CurrentValues.SetValues(districts);
                    _context.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return districts;
        }

        private bool Exists(long id)
        {
            return _context.Districts.Any(p => p.Id.Equals(id));
        }
    }
}
