using StolenCarPTBackend.Data.Converter.Contract;
using StolenCarPTBackend.Data.VO;
using StolenCarPTBackend.Model;

namespace StolenCarPTBackend.Data.Converter.Implementations
{
    public class BrandsConverter : IParser<BrandsVO, Brands>, IParser<Brands, BrandsVO>
    {
        public BrandsVO Parse(Brands origin)
        {
            if (origin == null) return null;
            return new BrandsVO
            {
                Id = origin.Id,
                Name = origin.Name,
            };
        }

        public Brands Parse(BrandsVO origin)
        {
            if (origin == null) return null;
            return new Brands
            {
                Id = origin.Id,
                Name = origin.Name,
            };
        }

        public List<Brands> Parse(List<BrandsVO> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }

        public List<BrandsVO> Parse(List<Brands> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }
    }
}
