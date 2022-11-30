using StolenCarPTBackend.Data.Converter.Contract;
using StolenCarPTBackend.Data.VO;
using StolenCarPTBackend.Model;

namespace StolenCarPTBackend.Data.Converter.Implementations
{
    public class ModelsConverter : IParser<ModelsVO, Models>, IParser<Models, ModelsVO>
    {
        public Models Parse(ModelsVO origin)
        {
            if (origin == null) return null;
            return new Models
            {
                Id = origin.Id,
                Name = origin.Name,
                brand_id = origin.brand_id,
            };
        } 
        
        public ModelsVO Parse(Models origin)
        {
            if (origin == null) return null;
            return new ModelsVO
            {
                Id = origin.Id,
                Name = origin.Name,
                brand_id = origin.brand_id,
            };
        }

        public List<Models> Parse(List<ModelsVO> origin)
        {
           if (origin == null) return null;
           return origin.Select(item => Parse(item)).ToList();
        }

        public List<ModelsVO> Parse(List<Models> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }
    }
}
