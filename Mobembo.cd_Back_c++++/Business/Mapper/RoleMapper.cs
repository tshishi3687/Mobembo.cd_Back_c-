using Mobembo.cd_Back_c____.Business.DTO;
using Mobembo.cd_Back_c____.Data_Access.Entity;

namespace Mobembo.cd_Back_c____.Business.Mapper
{
    public class RoleMapper : IMapper<RoleDTO, Role>
    {
        public RoleDTO toDTO(Role Entity)
        {
            RoleDTO roleDTO = new RoleDTO();
            roleDTO.NomRole = Entity.NomRole;
            return roleDTO;
        }

        public Role toEntity(RoleDTO DTO)
        {
            throw new NotImplementedException();
        }
    }
}
