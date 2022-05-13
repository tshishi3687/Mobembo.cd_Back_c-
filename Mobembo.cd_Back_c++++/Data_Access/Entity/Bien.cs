using System.ComponentModel.DataAnnotations.Schema;

namespace Mobembo.cd_Back_c____.Data_Access.Entity
{
    public class Bien
    {
        public int Id { get; set; }
        public TypeBien TypeBien { get; set; }

        [ForeignKey(nameof(TypeBien))]
        public int TypeBienId { get; set; }
        public IEnumerable<ALaDispositionBien> AlaDisposition { get; set; }
        public Coordonnee Coordonnee { get; set; }
        public int CoordonneeId { get; set; }
        public int Prix { get; set; }
        public int NPMin { get; set; }
        public int NPMax { get; set; }
        public int NChambre { get; set; }
        public int NSDB { get; set; }
        public int NWC { get; set; }
        public int Superficie { get; set; }
        public string Description { get; set; }
        public Personne AppartientA { get; set; }

        [ForeignKey(nameof(Personne))]
        public int AppartientAId { get; set; }
    }
}
