using StolenCarPTBackend.Data.Converter.Contract;
using StolenCarPTBackend.Data.VO;
using StolenCarPTBackend.Model;

namespace StolenCarPTBackend.Data.Converter.Implementations
{
    public class LocationsConverter : IParser<LocationsVO, Locations>, IParser<Locations, LocationsVO>
    {
        public LocationsVO Parse(Locations origin)
        {
            if (origin == null) return null;
            return new LocationsVO
            {
                Id = origin.Id,
                Name = origin.Name,
                district_id = origin.district_id
            };
        }

        public Locations Parse(LocationsVO origin)
        {
            if (origin == null) return null;
            return new Locations
            {
                Id = origin.Id,
                Name = origin.Name,
                district_id = origin.district_id
            };
        }

        public List<Locations> Parse(List<LocationsVO> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }

        public List<LocationsVO> Parse(List<Locations> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }
    }
}
