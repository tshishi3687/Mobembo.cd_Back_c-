using Microsoft.EntityFrameworkCore;
using Mobembo.cd_Back_c____.Business.DTO;
using Mobembo.cd_Back_c____.Data_Access.Entity;
using Mobembo.cd_Back_c____.Exeption;
using Mobembo.cd_Back_c____.Security;
using System.Diagnostics;
using Mobembo.cd_Back_c____.Business.Mapper;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

namespace Mobembo.cd_Back_c____.Business.Service
{
    public class PersonneService : ICrudService<PersonneCreateDTO, int>, ILogin<LogDTO>
    {
        private Context Context ;
        private IConstente Constente;
        private MyMdpCrypte mdpCrypte = new MyMdpCrypte();
        private PersonneVuMapper personeMapper = new PersonneVuMapper();
        private PersonneCreateMapper personneCreateMapper = new PersonneCreateMapper();


        public PersonneService(IConstente Constente, Context Context)
        {
            this.Constente = Constente;
            this.Context = Context;

        }

        public void Create(PersonneCreateDTO DTO)
        {
            if (DTO == null)
                throw new ElementNullExeption();

            if (DTO.Mdp != DTO.verifMdp)
                throw new Exception("Les mdp ne sont pas identique");

            Personne entity = personneCreateMapper.toEntity(DTO);
            Context.personnes.Add(entity);

            PersonnesRoles personnesRoles = new PersonnesRoles();
            personnesRoles.Roles = Context.roles.FirstOrDefault(x => x.NomRole == Mobembo.cd_Back_c____.Security.Constente.RoleCl);
            personnesRoles.Personnes = entity;
            Context.PersonneRoles.Add(personnesRoles);

            try
            {
                Context.SaveChanges();
            }catch(DbUpdateException e)
            {
                Debug.WriteLine(e);
            }

        }

        public string Login(string mail, string mdp)
        {
            Personne person = Context.personnes.FirstOrDefault(p => p.Email == mail);
            if (person == null)
                return null; 

            if (!mdpCrypte.Compart(person.Mdp, mdp))
                return null;

            List<string> personnesRoles = Context.PersonneRoles.Where(pr => pr.PersonneId == person.Id).Select(pr => pr.Roles.NomRole).ToList();

            List<Claim> claims = new List<Claim>();
            claims.Add(new Claim(ClaimTypes.Email, person.Email));
            foreach (var item in personnesRoles)
            {
                claims.Add(new Claim(ClaimTypes.Role, item));
            }

            return Constente.GenerateToken(claims); 
        }

        public PersonneVuDTO InfoPerspnne()
        {
            return personeMapper.toDTO(Constente.Connected);
        }

        public void Delete(int Id)
        {
            if (Id == 0 || Context.personnes.FirstOrDefault(x => x.Id == Id) == null)
                throw new Exception("L'element recherché n'existe pas");

            Context.personnes.Remove(Context.personnes.FirstOrDefault(x => x.Id == Id));

            Context.SaveChanges();
        }

        public List<PersonneCreateDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public PersonneCreateDTO GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(PersonneCreateDTO DTO)
        {
            throw new NotImplementedException();
        }

        public PersonneVuDTO infoPerspnne()
        {
            return new PersonneVuDTO();
        }
    }
}
