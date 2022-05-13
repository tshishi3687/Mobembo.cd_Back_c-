using Mobembo.cd_Back_c____.Business.DTO;
using Mobembo.cd_Back_c____.Data_Access.Entity;

namespace Mobembo.cd_Back_c____.Business.Mapper
{
    public class BienMapper : IMapper<BienDTO, Bien>
    {
        private Context Context = new Context();
        private TypeBienMapper TypeBienMapper = new TypeBienMapper();
        private CoordonneeMapper CoordonneeMapper = new CoordonneeMapper();
        private Personne personne;

        public BienDTO toDTO(Bien Entity)
        {

            BienDTO bien = new BienDTO();
            bien.Id = Entity.Id;
            bien.TypeBien = TypeBienMapper.toDTO(Entity.TypeBien);
            bien.Coordonnee = CoordonneeMapper.toDTO(Entity.Coordonnee);
            bien.Prix = Entity.Prix;
            bien.NPMin = Entity.NPMin;
            bien.NPMax = Entity.NPMax;
            bien.NChambre = Entity.NChambre;
            bien.NSDB = Entity.NSDB;
            bien.Superficie = Entity.Superficie;
            bien.Description = Entity.Description;
            return bien;
        }

        public Bien toEntity(BienDTO DTO)
        {
            Bien bien = new Bien();
            bien.Coordonnee = CoordonneeMapper.toEntity(DTO.Coordonnee);
            bien.Prix = DTO.Prix;
            bien.NPMin = DTO.NPMin;
            bien.NPMax = DTO.NPMax;
            bien.NChambre = DTO.NChambre;
            bien.NSDB = DTO.NSDB;
            bien.NWC = DTO.NWC;
            bien.Superficie = DTO.Superficie;
            bien.Description = DTO.Description;
            bien.AppartientA = personne;
            return bien;
        }
    }
}
