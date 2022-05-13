namespace Mobembo.cd_Back_c____.Data_Access.Entity
{
    public class Pays
    {
        public int Id { get; set; }
        public int Code { get; set; }
        public string Alpha2 { get; set; }
        public string Alpha3 { get; set; }
        public string NomEnGb { get; set; }
        public string NomFrFr { get; set; }
        public List<AdressePersonne> Adresses { get; set; }
    }
}
