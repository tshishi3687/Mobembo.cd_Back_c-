using Mobembo.cd_Back_c____.Business.DTO;
using Mobembo.cd_Back_c____.Data_Access.Entity;

namespace Mobembo.cd_Back_c____.Business.Mapper
{
    public class VilleMapper : IMapper<VilleDTO, Ville>
    {
        private Context Context = new Context();
        private ProvinceMapper ProvinceMapper = new ProvinceMapper();  
        public VilleDTO toDTO(Ville Entity)
        {
            VilleDTO ville = new VilleDTO();
            ville.Id = Entity.Id;
            ville.NomVille = Entity.NomVille;
            ville.NHabitant = Entity.NHabitant;
            ville.Description = Entity.Description;
            ville.Province = ProvinceMapper.toDTO(Context.provinces.FirstOrDefault(p => p.Id == Entity.ProvinceId));
            return ville;
        }

        public Ville toEntity(VilleDTO DTO)
        {
            Ville ville = new Ville();
            ville.Id = DTO.Id;
            ville.NomVille = DTO.NomVille;
            ville.NHabitant = DTO.NHabitant;
            ville.Description = DTO.Description;
            ville.Province = Context.provinces.FirstOrDefault(p => p.Id == DTO.Province.Id);
            return ville;
        }
    }
}
