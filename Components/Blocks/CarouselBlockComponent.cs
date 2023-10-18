using EPiServer.Web;
using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using Nackademin2023v2.Models.Blocks;
using Nackademin2023v2.Models.Pages;
using Nackademin2023v2.Models.ViewModels;

namespace Nackademin2023v2.Components.Blocks
{
    public class CarouselBlockComponent : AsyncBlockComponent<CarouselBlock>
    {
        protected override async Task<IViewComponentResult> InvokeComponentAsync(CarouselBlock currentContent)
        {
            var model = new CarouselBlockViewModel();

            var i = 0;
            var ii = 1;

            foreach (var item in currentContent.Carousel.FilteredItems.Select(x => x.LoadContent()))
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

            return View("~/components/blocks/default.cshtml", model);
        }
    }
}