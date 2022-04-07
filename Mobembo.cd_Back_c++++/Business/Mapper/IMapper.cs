namespace Mobembo.cd_Back_c____.Business.Mapper
{
    public interface IMapper<DTO, EnTity>
    {
        DTO toDTO(EnTity Entity);
        EnTity toEntity(int id, DTO DTO);
    }
}
