namespace Mobembo.cd_Back_c____.Business.DTO
{
    public class CoordonneeDTO
    {
        public string CPostal { get; set; }
        public string Rue { get; set; }
        public string Num { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public VilleDTO Ville { get; set; }
    }
}
