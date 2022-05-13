using Mobembo.cd_Back_c____.Business.DTO;
using Mobembo.cd_Back_c____.Data_Access.Entity;

namespace Mobembo.cd_Back_c____.Business.Mapper
{
    public class TypeBienMapper : IMapper<TypeBienDTO, TypeBien>
    {
        public TypeBienDTO toDTO(TypeBien Entity)
        {
            TypeBienDTO typeBien = new TypeBienDTO();
            typeBien.NomType = Entity.NomType;
            return typeBien;
        }

        public TypeBien toEntity(TypeBienDTO DTO)
        {
            TypeBien typeBien = new TypeBien();
            typeBien.NomType = DTO.NomType;
            return typeBien;
        }
    }
}
