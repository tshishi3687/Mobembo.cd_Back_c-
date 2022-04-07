namespace Mobembo.cd_Back_c____.Business.Service
{
    public interface ICrudService<DTO, Id>
    {
        void Create(DTO DTO);
        List<DTO> GetAll();
        DTO GetById(Id Id);
        void Update(DTO DTO);
        void Delete(Id Id);
    }
}
