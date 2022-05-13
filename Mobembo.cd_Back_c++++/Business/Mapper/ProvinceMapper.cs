using Mobembo.cd_Back_c____.Business.DTO;
using Mobembo.cd_Back_c____.Data_Access.Entity;

namespace Mobembo.cd_Back_c____.Business.Mapper
{
    public class ProvinceMapper : IMapper<ProvinceDTO, Province>
    {
        public ProvinceDTO toDTO(Province Entity)
        {
            ProvinceDTO Province = new ProvinceDTO();
            Province.Id = Entity.Id;
            Province.NomProvince = Entity.NomProvince;
            Province.Description = Entity.Description;
            return Province;
        }

        public Province toEntity(ProvinceDTO DTO)
        {
            Province province = new Province();
            province.Id = DTO.Id;
            province.NomProvince = DTO.NomProvince;
            province.Description = DTO.Description;
            return province;
        }
    }
}
