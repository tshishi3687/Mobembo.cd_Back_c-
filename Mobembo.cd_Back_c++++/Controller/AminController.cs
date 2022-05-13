using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Mobembo.cd_Back_c____.Business.DTO;
using Mobembo.cd_Back_c____.Business.Service;
using Mobembo.cd_Back_c____.Security;

namespace Mobembo.cd_Back_c____.Controller
{
    [ApiController]
    [Route("/Admin")]
    [Authorize(Roles = "Admin")]
    public class AminController : AbstratCrudController
    {
        private readonly IHttpContextAccessor _contextAccessor;
        private ICrudService<PersonneCreateDTO, int> personneService;
        private ICrudService<ProvinceDTO, int> provinceService;



        public AminController(IHttpContextAccessor cc, Constente constente, ICrudService<ProvinceDTO, int> provinceService) : base(cc, constente)
        {
            this.provinceService = provinceService; 
            this._contextAccessor = cc;
        }
        //Gestion Personne



        //Gestion Province
        [HttpPost("/createPro")]
        public void CreateProvince(ProvinceDTO dto)
        {
            provinceService.Create(dto);
        }

        [HttpPost("/updatePro")]
        public void ModifProvince(ProvinceDTO dto)
        {
            provinceService.Update(dto);
        }

        [HttpDelete("/deletePro")]
        public void DeleteProvince(int Id)
        {
            provinceService.Delete(Id);
        }
    }
}
