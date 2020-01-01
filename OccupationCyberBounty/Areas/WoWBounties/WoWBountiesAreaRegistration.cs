using System.Web.Mvc;

namespace OccupationCyberBounty.Areas.WoWBounties
{
    public class WoWBountiesAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "WoWBounties";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "WoWBounties_default",
                "WoWBounties/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}