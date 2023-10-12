using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using Nackademin2023v2.Models.Pages;
using Nackademin2023v2.Models.ViewModels;
using EPiServer.Web.Routing;

namespace Nackademin2023v2.Business
{
    public class PageContextActionFilter : IResultFilter
    {
        private readonly PageViewContextFactory _contextFactory;

        public PageContextActionFilter(PageViewContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public void OnResultExecuting(ResultExecutingContext context)
        {
            var controller = context.Controller as Controller;
            var viewModel = controller?.ViewData.Model;

            if (viewModel is IPageViewModel<SitePageData> model)
            {
                var currentContentLink = context.HttpContext.GetContentLink();
                var layoutModel = model.Layout ?? _contextFactory.CreateLayoutModel(currentContentLink, context.HttpContext);

                if (context.Controller is IModifyLayout layoutController)
                {
                    layoutController.ModifyLayout(layoutModel);
                }

                model.Layout = layoutModel;
            }
        }

        public void OnResultExecuted(ResultExecutedContext context)
        {
        }
    }
}