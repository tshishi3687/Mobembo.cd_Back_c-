namespace Mobembo.cd_Back_c____.Data_Access.Entity
{
    public class ContactPersonne
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public Personne AppartientA { get; set; }

    }
}
