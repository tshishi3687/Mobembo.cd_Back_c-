using Microsoft.EntityFrameworkCore;
using Mobembo.cd_Back_c____.Business.DTO;
using Mobembo.cd_Back_c____.Business.Mapper;
using Mobembo.cd_Back_c____.Data_Access.Entity;
using Mobembo.cd_Back_c____.Exeption;
using Mobembo.cd_Back_c____.Security;
using System.Diagnostics;

namespace Mobembo.cd_Back_c____.Business.Service
{
    public class ProvinceService : ICrudService<ProvinceDTO, int>
    {
        private Context Context;
        private ProvinceMapper provinceMapper = new ProvinceMapper();

        public ProvinceService(Context Context)
        {
            this.Context = Context;
        }


        public void Create(ProvinceDTO DTO)
        {
            if (DTO == null)
                throw new ElementNullExeption();

            if (Context.provinces.FirstOrDefault(p => p.NomProvince == DTO.NomProvince) != null)
                throw new NotImplementedException();

            Context.provinces.Add(provinceMapper.toEntity(DTO));

            try
            {
                Context.SaveChanges();
            }
            catch (DbUpdateException e)
            {
                Debug.WriteLine(e);
            }
        }

        public void Delete(int Id)
        {
            if (Id ==0 || Context.provinces.FirstOrDefault(p => p.Id == Id) == null)
                throw new Exception("L'element recherché n'existe pas");

            Context.provinces.Remove(Context.provinces.FirstOrDefault(p => p.Id == Id));
            Context.SaveChanges();
        }

        public List<ProvinceDTO> GetAll()
        {
            return Context.provinces.Select(p => provinceMapper.toDTO(p)).ToList();
        }

        public ProvinceDTO GetById(int Id)
        {
            if (Id == 0 || Context.provinces.FirstOrDefault(p => p.Id == Id) == null)
                throw new NotImplementedException();
            return provinceMapper.toDTO(Context.provinces.FirstOrDefault(p => p.Id == Id));
        }

        public void Update(ProvinceDTO DTO)
        {
            if (DTO.Id == 0 || Context.provinces.FirstOrDefault(p => p.Id == DTO.Id) == null)
                throw new NotImplementedException();
            Context.provinces.Remove(Context.provinces.FirstOrDefault(p => p.Id == DTO.Id));
            Context.provinces.Add(provinceMapper.toEntity(DTO));
            Context.SaveChanges();
        }


        public PersonneVuDTO InfoPerspnne()
        {
            throw new NotImplementedException();
        }

        public string Login(string mail, string mdp)
        {
            throw new NotImplementedException();
        }
    }
}
