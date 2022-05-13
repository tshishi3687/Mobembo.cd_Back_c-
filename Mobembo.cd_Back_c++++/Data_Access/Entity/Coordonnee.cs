using System.ComponentModel.DataAnnotations.Schema;

namespace Mobembo.cd_Back_c____.Data_Access.Entity
{
    public class Coordonnee
    {
        public int Id { get; set; }
        public string CPostal { get; set; }
        public string Rue { get; set; }
        public string Num { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public Ville Ville { get; set; }

        [ForeignKey(nameof(Ville))]
        public int VilleID { get; set; }
        public IEnumerable<Bien> Biens { get; set; }
    }
}
