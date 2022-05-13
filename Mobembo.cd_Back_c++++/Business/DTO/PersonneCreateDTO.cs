using Mobembo.cd_Back_c____.Security;
using Mobembo.cd_Back_c____.Validation;
using System.ComponentModel.DataAnnotations;

namespace Mobembo.cd_Back_c____.Business.DTO
{
    public class PersonneCreateDTO
    {
        [Required]
        [MinLength(3)]
        [MaxLength(50)]
        public string Nom { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(50)]
        public string Prenom { get; set; }

        [Required]
        [Date18]
        public DateTime Ddn { get; set; }

        [Required]
        [EmailExiste]
        [ValidationEmail]
        public string Email { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(320)]
        public string Telephone { get; set; }

        [Required]
        [MinLength(6)]
        [MaxLength(50)]
        public string Mdp { get; set; }

        [Required]
        [MinLength(6)]
        [MaxLength(50)]
        public string verifMdp { get; set; }
    }
}
