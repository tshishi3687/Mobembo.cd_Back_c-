using System.ComponentModel.DataAnnotations.Schema;

namespace Mobembo.cd_Back_c____.Data_Access.Entity
{
    public class Ville
    {
        public int Id { get; set; }
        public string NomVille { get; set; }
        public int NHabitant { get; set; }
        public string Description { get; set; }
        public Province Province { get; set; }

        [ForeignKey(nameof(Province))]
        public int ProvinceId { get; set; }
        public IEnumerable<Coordonnee> Coordonnees { get; set; }
    }
}