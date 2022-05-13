namespace Mobembo.cd_Back_c____.Data_Access.Entity
{
    public class Province
    {
        public int Id { get; set; }
        public string NomProvince { get; set; }
        public string Description { get; set; }
        public IEnumerable<Ville> Villes { get; set; }
    }
}
