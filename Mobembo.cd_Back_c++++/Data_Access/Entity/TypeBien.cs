namespace Mobembo.cd_Back_c____.Data_Access.Entity
{
    public class TypeBien
    {
        public int Id { get; set; }
        public string NomType { get; set; }
        public IEnumerable<Bien> Biens { get; set; }
    }
}
