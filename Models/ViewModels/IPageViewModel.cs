using Nackademin2023v2.Models.Pages;

namespace Nackademin2023v2.Models.ViewModels
{
    public interface IPageViewModel<out T> where T : SitePageData
    {
        T CurrentPage { get; }

        LayoutModel Layout { get; }

        IContent Section { get; }
    }
}