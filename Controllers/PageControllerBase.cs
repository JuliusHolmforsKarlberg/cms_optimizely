using EPiServer.Web.Mvc;
using Nackademin2023v2.Models.Pages;

namespace Nackademin2023v2.Controllers
{
    public abstract class PageControllerBase<T> : PageController<T> where T : SitePageData
    {
    }
}