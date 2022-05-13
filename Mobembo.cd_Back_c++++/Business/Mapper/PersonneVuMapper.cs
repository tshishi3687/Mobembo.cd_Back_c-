using Mobembo.cd_Back_c____.Business.DTO;
using Mobembo.cd_Back_c____.Data_Access.Entity;
using Mobembo.cd_Back_c____.Exeption;

namespace Mobembo.cd_Back_c____.Business.Mapper
{
    public class PersonneVuMapper : IMapper<PersonneVuDTO, Personne>
    {
        private Context Context = new Context();
        private RoleMapper RoleMapper = new RoleMapper();
        public PersonneVuDTO toDTO(Personne Entity)
        {
            List<PersonnesRoles> listPR = Context.PersonneRoles.Where(pr => pr.PersonneId == Entity.Id).ToList();
            List<Role> listR = Context.roles.Where(r => r.Id ==listPR.Count).ToList();
            PersonneVuDTO dto = new PersonneVuDTO();
            dto.Prenom = Entity.Prenom;
            dto.Nom = Entity.Nom;
            dto.Roles = listR.Select(r => RoleMapper.toDTO(r)).ToList();

            return dto;
        }

        public Personne toEntity(PersonneVuDTO DTO)
        {
            throw new ElementNullExeption();
        }
    }
}
