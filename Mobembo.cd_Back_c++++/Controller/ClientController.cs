using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Mobembo.cd_Back_c____.Business.DTO;
using Mobembo.cd_Back_c____.Business.Service;
using Mobembo.cd_Back_c____.Security;

namespace Mobembo.cd_Back_c____.Controller
{
    [ApiController]
    [Route("/Client")]
    [Authorize(Roles = "Admin,Client")]

    public class ClientController : AbstratCrudController
    {
        private ICrudService<BienDTO, int> bienService;
        private ICrudService<PersonneCreateDTO, int> personneService;
        private IConstente constente;



        public ClientController(IHttpContextAccessor cc, IConstente constt, ICrudService<BienDTO, int> bienService, ICrudService<PersonneCreateDTO, int> personneService) : base( cc, constt)
        {
            this.constente = constt;
            this.bienService = bienService;
            this.personneService = personneService;
        }
        // Client
        [HttpGet("/info_personne")]
        public PersonneVuDTO infoPersonne()
        {
            return personneService.InfoPerspnne();
        }

// Gestion de Personne
        [HttpPost("/createBien")]
        public void CreateBien(BienDTO bienDTO)
        {
            bienService.Create(bienDTO);
        }
    }
}
