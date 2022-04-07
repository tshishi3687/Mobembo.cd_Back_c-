namespace Mobembo.cd_Back_c____.Controller
{
    public interface CrudController<DTO, Id>
    {
        void Create(DTO dto);
        DTO GetOne(Id id);
        List<DTO> GetAll();
        void Update(DTO dto);
        void Delete(Id id);
    }
}
