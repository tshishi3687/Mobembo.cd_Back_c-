namespace Mobembo.cd_Back_c____.Data_Access.Entity
{
    public class RolePersonne
    {
        public int Id { get; set; } 
        public string NomRole { get; set; }
        public IEnumerable<Personne> Personnes { get; set; }
    }
}
