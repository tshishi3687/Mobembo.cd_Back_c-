namespace Mobembo.cd_Back_c____.Data_Access.Entity
{
    public class PassWord
    {
        public int Id { get; set; }
        public string Mdp { get; set; }
        public bool IsActive { get; set; }
        public Personne AppartientA { get; set; }
    }
}
