using Nackademin2023v2.Models.Pages;
using Nackademin2023v2.Models.ViewModels;

namespace Nackademin2023v2.Models.ViewModels
{
    public class PageViewModel<T> : IPageViewModel<T> where T : SitePageData
    {
        public PageViewModel(T currentPage)
        {
            CurrentPage = currentPage;
        }

        public T CurrentPage { get; set; }

        public LayoutModel Layout { get; set; }

        public IContent Section { get; set; }
    }

    public static class PageViewModel
    {
        public static PageViewModel<T> Create<T>(T page) where T : SitePageData => new(page);
    }
}