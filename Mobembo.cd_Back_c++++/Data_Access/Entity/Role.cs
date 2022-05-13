namespace Mobembo.cd_Back_c____.Data_Access.Entity
{
    public class Role
    {
        public int Id { get; set; } 
        public string NomRole { get; set; }
        public ICollection<PersonnesRoles> Personnes { get; set; }
    }
}
