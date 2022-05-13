using Mobembo.cd_Back_c____.Business.DTO;
using Mobembo.cd_Back_c____.Data_Access.Entity;

namespace Mobembo.cd_Back_c____.Business.Mapper
{
    public class ALaDispositionMapper : IMapper<ALaDispositionDTO, ALaDisposition>
    {
        public ALaDispositionDTO toDTO(ALaDisposition Entity)
        {
            ALaDispositionDTO dto = new ALaDispositionDTO();
            dto.NomDuDisponible = Entity.NomDuDisponible;
            return dto;
        }

        public ALaDisposition toEntity(ALaDispositionDTO DTO)
        {
            ALaDisposition entity = new ALaDisposition();
            entity.NomDuDisponible = DTO.NomDuDisponible;
            return entity;
        }
    }
}
