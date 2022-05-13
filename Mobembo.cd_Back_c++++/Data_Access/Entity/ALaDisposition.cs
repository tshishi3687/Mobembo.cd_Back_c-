namespace Mobembo.cd_Back_c____.Data_Access.Entity
{
    public class ALaDisposition
    {
        public int Id { get; set; }
        public string NomDuDisponible { get; set; }
        public IEnumerable<ALaDispositionBien> Bien { get; set; }
    }
}
