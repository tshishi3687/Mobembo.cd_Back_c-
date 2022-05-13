using System.Security.Claims;

namespace Mobembo.cd_Back_c____.Security
{
    public interface IJwtAuthenticationService
    {
        string GenerateToken(List<Claim> cleams);
    }
}
