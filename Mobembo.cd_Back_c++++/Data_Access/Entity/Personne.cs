namespace Mobembo.cd_Back_c____.Data_Access.Entity
{
    public class Personne
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime Ddn { get; set; }
        public RolePersonne RolePersonne { get; set; }
        public ContactPersonne Contact {get; set; }
        public PassWord mdp {get; set; }
    }
}
