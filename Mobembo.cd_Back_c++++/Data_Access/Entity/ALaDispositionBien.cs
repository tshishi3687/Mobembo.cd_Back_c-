namespace Mobembo.cd_Back_c____.Data_Access.Entity
{
    public class ALaDispositionBien
    {
        public int BienId { get; set; }
        public Bien Biens { get; set; }
        public int ALaDispositionId { get; set; }
        public ALaDisposition ALaDispositions  { get; set; }
    }
}