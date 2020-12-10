using System.Web.Mvc;

namespace MaternityCareSystem.Areas.PN
{
    public class PNAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "PN";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            //context.MapRoute(
            //    "PN_default",
            //    "PN/{controller}/{action}/{id}",
            //    new { action = "Index", id = UrlParameter.Optional }
            //);
            context.MapRoute(
                "PN_default",
                "PN/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional },
              namespaces: new[] { "MaternityCareSystem.Areas.PN.Controllers" }
          ).DataTokens["UseNamespaceFallback"] = true;
        }
    }
}