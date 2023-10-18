using Microsoft.AspNetCore.Mvc;
using EPiServer.Web;
using Nackademin2023v2.Components.Blocks;
using Nackademin2023v2.Models.Pages;
using Nackademin2023v2.Models.ViewModels;

namespace Nackademin2023v2.Components.Carousel
{
    public class CarouselBlockComponent : ViewComponent
    {
        private readonly IContentLoader _contentLoader;

        public CarouselBlockComponent(IContentLoader contentLoader)
        {
            _contentLoader = contentLoader;
        }

        public IViewComponentResult Invoke()
        {
            var startPage = _contentLoader.Get<StartPage>(SiteDefinition.Current.StartPage);
            var model = new CarouselBlockViewModel();

            var i = 0;
            var ii = 1;

            foreach (var item in startPage.Carousel.FilteredItems.Select(x => x.LoadContent()))
            {
                if (item is CarouselPage)
                {
                    var page = new CarouselViewPageModel();

                    if (i == 0)
                    {
                        page.Active = "active";
                        page.AriaCurrent = "true";
                    }
                    else
                    {
                        page.Active = null;
                        page.AriaCurrent = null;
                    }

                    page.DataBsSlideTo = i++;
                    page.AriaLabel = string.Format("Slide {0}", ii++);
                    page.Page = item as CarouselPage;

                    model.Pages.Add(page);
                }
            }

            return View("~/components/carousel/default.cshtml", model);
        }
    }
}
