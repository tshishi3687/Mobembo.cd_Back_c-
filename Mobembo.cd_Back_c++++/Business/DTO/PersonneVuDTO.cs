using Mobembo.cd_Back_c____.Data_Access.Entity;

namespace Mobembo.cd_Back_c____.Business.DTO
{
    public class PersonneVuDTO
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public ICollection<RoleDTO> Roles { get; set; }
    }
}
