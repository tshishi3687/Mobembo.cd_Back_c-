using Mobembo.cd_Back_c____.Business.DTO;
using Mobembo.cd_Back_c____.Data_Access.Entity;

namespace Mobembo.cd_Back_c____.Business.Mapper
{
    public class CoordonneeMapper : IMapper<CoordonneeDTO, Coordonnee>
    {
        private Context Context = new Context();
        private VilleMapper VilleMapper = new VilleMapper();

        public CoordonneeDTO toDTO(Coordonnee Entity)
        {
            CoordonneeDTO coordonneeDTO = new CoordonneeDTO();
            coordonneeDTO.CPostal = Entity.CPostal;
            coordonneeDTO.Rue = Entity.Rue;
            coordonneeDTO.Num = Entity.Num;
            coordonneeDTO.Email = Entity.Email;
            coordonneeDTO.Telephone = Entity.Telephone;
            coordonneeDTO.Ville = VilleMapper.toDTO(Context.villes.FirstOrDefault(v => v.Id == Entity.VilleID));
            return coordonneeDTO;
        }

        public Coordonnee toEntity(CoordonneeDTO DTO)
        {
            Coordonnee coordonnee = new Coordonnee();
            coordonnee.CPostal = DTO.CPostal;
            coordonnee.Rue = DTO.Rue;
            coordonnee.Num = DTO.Num;
            coordonnee.Email = DTO.Email;
            coordonnee.Telephone = DTO.Telephone;
            coordonnee.Ville = Context.villes.FirstOrDefault(v => v.Id == DTO.Ville.Id);
            return coordonnee;
        }
    }
}
