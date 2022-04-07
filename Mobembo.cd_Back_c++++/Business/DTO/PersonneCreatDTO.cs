using System.ComponentModel.DataAnnotations;

namespace Mobembo.cd_Back_c____.Business.DTO
{
    public class PersonneCreatDTO
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime Ddn { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public string Mdp { get; set; }
        public string verifMdp { get; set; }
    }
}
