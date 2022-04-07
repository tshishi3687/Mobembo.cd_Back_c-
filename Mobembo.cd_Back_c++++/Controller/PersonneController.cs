using Microsoft.AspNetCore.Mvc;
using Mobembo.cd_Back_c____.Business.DTO;
using Mobembo.cd_Back_c____.Business.Service;

namespace Mobembo.cd_Back_c____.Controller
{
    [ApiController]
    [Route("personne")]
    public class PersonneController : AbstratCrudController<PersonneCreatDTO, int>
    {
        private ICrudService<PersonneCreatDTO, int> crudService;
        private PersonneService personneService;

        public PersonneController(ICrudService<PersonneCreatDTO, int> crudService) : base(crudService)
        {
            this.crudService = crudService;
        }
    }
}
