using Mobembo.cd_Back_c____.Business.DTO;
using Mobembo.cd_Back_c____.Data_Access.Entity;

namespace Mobembo.cd_Back_c____.Business.Mapper
{
    public class AdressePersonneMapper : IMapper<AdressePersonneDTO, AdressePersonne>
    {
        private Context Context = new Context();
        private PaysMapper paysMapper = new PaysMapper();

        public AdressePersonneDTO toDTO(AdressePersonne Entity)
        {
            AdressePersonneDTO dto = new AdressePersonneDTO();
            dto.NumHabitation = Entity.NumHabitation;
            dto.NomRue = Entity.NomRue;
            dto.CodePostalLocalite = Entity.CodePostalLocalite;
            dto.Pays = paysMapper.toDTO(Context.pays.FirstOrDefault(p => p.Id == Entity.PaysId));
            
            return dto;
        }

        public AdressePersonne toEntity(AdressePersonneDTO DTO)
        {
            AdressePersonne entity = new AdressePersonne();
            entity.NumHabitation = DTO.NumHabitation;
            entity.NomRue = DTO.NomRue;
            entity.CodePostalLocalite = DTO.CodePostalLocalite;
            entity.Pays = Context.pays.FirstOrDefault(p => p.Id == DTO.Pays.Id);

            return entity;
        }
    }
}
