namespace Mobembo.cd_Back_c____.Business.DTO
{
    public class VilleDTO
    {
        public int Id { get; set; }
        public string NomVille { get; set; }
        public int NHabitant { get; set; }
        public string Description { get; set; }
        public ProvinceDTO Province { get; set; }
    }
}
