using System.Web.Http;
using System.Web.Http.Controllers;

namespace CrewProfile.API.Commons.Securities
{
    public class JwtTokenValidationAttribute : AuthorizeAttribute
    {
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            base.OnAuthorization(actionContext);
        }


    }
}