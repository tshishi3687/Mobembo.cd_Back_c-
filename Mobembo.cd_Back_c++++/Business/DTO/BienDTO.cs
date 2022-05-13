namespace Mobembo.cd_Back_c____.Business.DTO
{
    public class BienDTO
    {
        public int Id { get; set; }
        public TypeBienDTO TypeBien { get; set; }

        public IEnumerable<ALaDispositionDTO> AlaDisposition { get; set; }
        public CoordonneeDTO Coordonnee { get; set; }
        public int CoordonneeId { get; set; }
        public int Prix { get; set; }
        public int NPMin { get; set; }
        public int NPMax { get; set; }
        public int NChambre { get; set; }
        public int NSDB { get; set; }
        public int NWC { get; set; }
        public int Superficie { get; set; }
        public string Description { get; set; }
    }
}
