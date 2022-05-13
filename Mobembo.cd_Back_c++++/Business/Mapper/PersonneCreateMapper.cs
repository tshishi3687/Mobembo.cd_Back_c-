using Mobembo.cd_Back_c____.Business.DTO;
using Mobembo.cd_Back_c____.Data_Access.Entity;
using Mobembo.cd_Back_c____.Security;

namespace Mobembo.cd_Back_c____.Business.Mapper
{
    public class PersonneCreateMapper : IMapper<PersonneCreateDTO, Personne>
    {
        private MyMdpCrypte mdpCrypte = new MyMdpCrypte();
        public PersonneCreateDTO toDTO(Personne Entity)
        {
            throw new NotImplementedException();
        }

        public Personne toEntity(PersonneCreateDTO DTO)
        {
            Personne personne = new Personne();
            personne.Nom = DTO.Nom;
            personne.Prenom = DTO.Prenom;
            personne.Ddn = DTO.Ddn;
            personne.Email = DTO.Email;
            personne.Telephone = DTO.Telephone;
            personne.Mdp = mdpCrypte.CryptMdp(DTO.Mdp);
            personne.IsActive = false;
            return personne;
        }
    }
}
