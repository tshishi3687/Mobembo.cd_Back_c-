using Mobembo.cd_Back_c____.Business.DTO;
using Mobembo.cd_Back_c____.Data_Access.Entity;

namespace Mobembo.cd_Back_c____.Business.Mapper
{
    public class PaysMapper : IMapper<PaysDTO, Pays>
    {
        public PaysDTO toDTO(Pays Entity)
        {
            PaysDTO dto = new PaysDTO();
            dto.Code = Entity.Code;
            dto.Alpha2 = Entity.Alpha2;
            dto.Alpha3 = Entity.Alpha3;
            dto.NomFrFr = Entity.NomFrFr;
            dto.NomEnGb = Entity.NomEnGb;

            return dto;
        }

        public Pays toEntity(PaysDTO DTO)
        {
            throw new NotImplementedException();
        }
    }
}
