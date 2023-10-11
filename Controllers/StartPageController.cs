using Microsoft.AspNetCore.Mvc;
using Nackademin2023v2.Models.Pages;
using Nackademin2023v2.Models.ViewModels;
using Nackademin2023v2.Controllers;

namespace Nackademin2023v2.Controllers
{
    public class StartPageController : PageControllerBase<StartPage>
    {
        public IActionResult Index(StartPage currentPage)
        {
            var model = new StartPageViewModel(currentPage);

            return View(model);
        }
    }
}