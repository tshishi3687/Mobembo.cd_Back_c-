using Mobembo.cd_Back_c____.Data_Access.Entity;
using System.Security.Claims;

namespace Mobembo.cd_Back_c____.Security
{
    public interface IConstente
    {

        Personne Connected { get; set; }
        string GenerateToken(List<Claim> cleams);
        void Mapersonne(string accessToken);
    }
}
