using System.ComponentModel.DataAnnotations.Schema;

namespace Mobembo.cd_Back_c____.Data_Access.Entity
{
    public class AdressePersonne
    {
        public  int Id { get; set; }
        public  string NumHabitation { get; set; }
        public  string NomRue { get; set; }
        public  string CodePostalLocalite { get; set; }
        public  Pays Pays { get; set; }

        [ForeignKey(nameof(Pays))]
        public int PaysId { get; set; }
        public  Personne AppartienA { get; set; }
    }
}
