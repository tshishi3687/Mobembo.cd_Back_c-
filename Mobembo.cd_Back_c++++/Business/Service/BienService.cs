using Mobembo.cd_Back_c____.Business.DTO;
using Mobembo.cd_Back_c____.Business.Mapper;
using Mobembo.cd_Back_c____.Data_Access.Entity;
using Mobembo.cd_Back_c____.Security;

namespace Mobembo.cd_Back_c____.Business.Service
{
    public class BienService : ICrudService<BienDTO, int>
    {
        private IConstente Constente;
        private Context Context;
        private BienMapper BienMapper = new BienMapper();
        private ALaDispositionMapper AlaDispositionMapper = new ALaDispositionMapper();

        public BienService(IConstente Constente, Context Context)
        {
            this.Constente = Constente;
            this.Context = Context;
        }

        public void Create(BienDTO DTO)
        {
            if (DTO==null)
                throw new NotImplementedException();

            Bien Entity = BienMapper.toEntity(DTO);
            Entity.TypeBien = Context.typeBiens.FirstOrDefault(tb => tb.NomType == DTO.TypeBien.NomType);

            foreach (ALaDispositionDTO a in DTO.AlaDisposition)
            {
                ALaDispositionBien aLaDispositionBien = new ALaDispositionBien();
                aLaDispositionBien.ALaDispositions = Context.aLaDispositions.FirstOrDefault(a => a.NomDuDisponible == a.NomDuDisponible);
                aLaDispositionBien.Biens = Entity;
                Context.aLaDispositionBiens.Add(aLaDispositionBien);
            }
            Context.biens.Add(Entity);
        }

        public void Delete(int Id)
        {
            if (
                Id == 0 ||
                Context.biens.FirstOrDefault(b => b.Id == Id) == null ||
                Context.biens.FirstOrDefault(b => b.AppartientAId != Constente.Connected.Id) != null 
                )
                throw new NotImplementedException();

            Context.biens.Remove(Context.biens.FirstOrDefault(b => b.Id == Id));
        }

        public List<BienDTO> GetAll()
        {

            List<BienDTO> listDTO = Context.biens.Select(b => BienMapper.toDTO(b)).ToList();

            foreach(BienDTO dto in listDTO)
            {
                List<ALaDispositionBien> BienList = Context.aLaDispositionBiens.Where(ab => ab.BienId == dto.Id).ToList();
                List<ALaDisposition> aLaDispositions = Context.aLaDispositions.Where(a => a.Id == BienList.Count).ToList();
                dto.AlaDisposition = aLaDispositions.Select(a => AlaDispositionMapper.toDTO(a)).ToList();
            }
            return listDTO;
        }

        public BienDTO GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(BienDTO DTO)
        {
            throw new NotImplementedException();
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
