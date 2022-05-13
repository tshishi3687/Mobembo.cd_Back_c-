namespace Mobembo.cd_Back_c____.Data_Access.Entity
{
    public class PersonnesRoles
    {
        public int PersonneId { get; set; }
        public Personne Personnes { get; set; }
        public int RoleId { get; set; }
        public Role Roles { get; set; }
    }
}
