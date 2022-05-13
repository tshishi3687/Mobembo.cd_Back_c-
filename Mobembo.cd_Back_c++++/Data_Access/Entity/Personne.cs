using System.ComponentModel.DataAnnotations.Schema;

namespace Mobembo.cd_Back_c____.Data_Access.Entity
{
    public class Personne
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime Ddn { get; set; }
        public ICollection<PersonnesRoles> Roles { get; set; }
        public AdressePersonne AdressePersonne { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public string Mdp { get; set; }
        public string NomBanque { get; set; }
        public string NumCarte { get; set; }
        public string NumCompte { get; set; }
        public DateTime DateExpiration { get; set; }
        public bool IsActive { get; set; }
        public IEnumerable<Bien> biens { get; set; }
    }
}
