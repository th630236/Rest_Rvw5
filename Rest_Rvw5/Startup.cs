using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Rest_Rvw5.Startup))]
namespace Rest_Rvw5
{
  public partial class Startup
  {
    public void Configuration(IAppBuilder app)
    {
      ConfigureAuth(app);
      //app.UseCookieAuthentication(new Microsoft.Owin.Security.Cookies.CookieAuthenticationOptions
      //{
      //  AuthenticationType = DefaultAuthenticationTypes.ApplicaionCookie
      //});
    }
  }
}
