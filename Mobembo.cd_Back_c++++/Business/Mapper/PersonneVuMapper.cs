using Mobembo.cd_Back_c____.Business.DTO;
using Mobembo.cd_Back_c____.Data_Access.Entity;
using Mobembo.cd_Back_c____.Exeption;

namespace Mobembo.cd_Back_c____.Business.Mapper
{
    public class PersonneVuMapper : IMapper<PersonneVuDTO, Personne>
    {
        public PersonneVuDTO toDTO(Personne Entity)
        {
            PersonneVuDTO dto = new PersonneVuDTO();
            dto.Prenom = Entity.Prenom;
            dto.Nom = Entity.Nom;
            dto.Ddn = Entity.Ddn;
            dto.RolePersonne = Entity.RolePersonne.NomRole;

            return dto;
        }

        public Personne toEntity(int id, PersonneVuDTO DTO)
        {
            throw new ElementNullExeption();
        }
    }
}
