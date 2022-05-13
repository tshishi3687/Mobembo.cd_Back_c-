using Microsoft.AspNetCore.Mvc;
using Mobembo.cd_Back_c____.Business.DTO;
using Mobembo.cd_Back_c____.Business.Service;

namespace Mobembo.cd_Back_c____.Controller
{
    [ApiController]
    [Route("/permisAll")]
    public class PermisAllController: ControllerBase
    {
        private ICrudService<PersonneCreateDTO, int> personneService;
        private ICrudService<ProvinceDTO, int> provinceService;

        public PermisAllController(ICrudService<PersonneCreateDTO, int> personneService, ICrudService<ProvinceDTO, int> provinceService)
        {
            this.personneService = personneService;
            this.provinceService = provinceService;
        }


        [HttpPost("/insciption")]
        public void inscription(PersonneCreateDTO dto)
        {
            personneService.Create(dto);
        }


        [HttpPost("/connection")]
        public IActionResult verifMdp(LogDTO log)
        {
            string token = personneService.Login(log.Mail, log.Mdp);
            return token != null ? new OkObjectResult(token) : Unauthorized();
        }

        [HttpGet("/allProvince")]
        public List<ProvinceDTO> AllProvince()
        {
            return provinceService.GetAll();
        }
    }
}
