using Microsoft.AspNetCore.Mvc;
using Mobembo.cd_Back_c____.Business.Service;

namespace Mobembo.cd_Back_c____.Controller
{
    public abstract class AbstratCrudController<DTO, Id> : ControllerBase, CrudController<DTO, Id>
    {
        protected ICrudService<DTO, Id> service;

        public AbstratCrudController(ICrudService<DTO, Id> service)
        {
            this.service = service;
        }

        [HttpPost]
        public void Create(DTO dto)
        {
            service.Create(dto);
        }

        [HttpDelete]
        public void Delete(Id id)
        {
            service.Delete(id);
        }

        [HttpGet("getall")]
        public List<DTO> GetAll()
        {
            return service.GetAll();
        }

        [HttpGet("getone")]
        public DTO GetOne(Id id)
        {
            return service.GetById(id);
        }

        [HttpPut()]
        public void Update(DTO dto)
        {
            service.Update(dto);
        }
    }
}
