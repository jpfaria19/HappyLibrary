using System;
using System.Net.Http;
using System.Text;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace HappyLibraryMVC
{
    public class RequireHttpsAttribute : AuthorizationFilterAttribute
    {
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            if (actionContext.Request.RequestUri.Scheme != Uri.UriSchemeHttps)
            {
                actionContext.Response = new HttpResponseMessage(System.Net.HttpStatusCode.Forbidden);
                actionContext.Response.Content = new StringContent(
                    "<p>" +
                        "OPA, VOCÊ NÃO ESTÁ USANDO O  HTTPS. POR FAVOR, MUDE SUA URL PARA HTTPS.</p><p>OPA, YOU ARE NOT USING HTTPS. PLEASE ALTER THE URI FOR HTTPS" +
                    "</p>", Encoding.UTF8, "text/html");

                UriBuilder uriBuilder = new UriBuilder(actionContext.Request.RequestUri);
                uriBuilder.Scheme = Uri.UriSchemeHttps;
                uriBuilder.Port = 44380;

                actionContext.Response.Headers.Location = uriBuilder.Uri;
            }
            else
            {
                base.OnAuthorization(actionContext);
            }
        }
    }
}