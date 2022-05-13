using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Mobembo.cd_Back_c____.Security;

namespace Mobembo.cd_Back_c____.Controller
{
    public abstract class AbstratCrudController : ControllerBase
    {
        
        public AbstratCrudController(IHttpContextAccessor cc, IConstente constente)
        {
             constente.Mapersonne(cc.HttpContext.GetTokenAsync("access_token").Result);
        }

    }
}
