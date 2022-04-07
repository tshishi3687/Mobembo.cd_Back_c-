using Mobembo.cd_Back_c____.Business.DTO;
using Mobembo.cd_Back_c____.Data_Access.Entity;
using Mobembo.cd_Back_c____.Exeption;
using Mobembo.cd_Back_c____.Security;
using System.ComponentModel.DataAnnotations;

namespace Mobembo.cd_Back_c____.Business.Service
{
    public class PersonneService : ICrudService<PersonneCreatDTO, int>
    {
        private Context Context = new Context();
        private VerifDTO VerifDTO = new VerifDTO();
        public void Create(PersonneCreatDTO DTO)
        {
            if (DTO == null)
                throw new ElementNullExeption();

            if (DTO.Mdp != DTO.verifMdp)
                throw new Exception("Les mdp ne sont pas identique");

            if (!VerifDTO.VerifDate(DTO.Ddn))
                throw new Exception("La date de naissance n'est pas valide");

            if (!VerifDTO.IsValidEmail(DTO.Email))
                throw new Exception("l'adresse E-mail n'est pas vailde!");

            if (VerifDTO.EmailExiste(DTO.Email)
                throw new Exception("Un compte est déjà associé à cet E-mail");

            ContactPersonne contact = new ContactPersonne();
            contact.Email = DTO.Email;
            contact.Telephone = DTO.Telephone;

            PassWord passWord = new PassWord();
            passWord.Mdp = DTO.Mdp;

            Personne entity = new Personne();
            entity.Nom = DTO.Nom;
            entity.Prenom = DTO.Prenom;
            entity.Ddn = DTO.Ddn;
            entity.RolePersonne = Context.roles.FirstOrDefault(x => x.NomRole == Constente.RoleCl);
            entity.Contact = contact;
            entity.mdp = passWord;


            Context.contacts.Add(contact);
            Context.passWords.Add(passWord);
            Context.personnes.Add(entity);

            
            Context.SaveChanges();

        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public List<PersonneCreatDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public PersonneCreatDTO GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(PersonneCreatDTO DTO)
        {
            throw new NotImplementedException();
        }
    }
}
