using StolenCarPTBackend.Data.Converter.Contract;
using StolenCarPTBackend.Data.VO;
using StolenCarPTBackend.Model;

namespace StolenCarPTBackend.Data.Converter.Implementations
{
    public class DistrictsConverter : IParser<DistrictsVO, Districts>, IParser<Districts, DistrictsVO>
    {
        public DistrictsVO Parse(Districts origin)
        {
            if (origin == null) return null;
            return new DistrictsVO
            {
                Id = origin.Id,
                Name = origin.Name,
            };
        }

        public Districts Parse(DistrictsVO origin)
        {
            if (origin == null) return null;
            return new Districts
            {
                Id = origin.Id,
                Name = origin.Name,
            };
        }

        public List<Districts> Parse(List<DistrictsVO> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }

        public List<DistrictsVO> Parse(List<Districts> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }
    }
}
