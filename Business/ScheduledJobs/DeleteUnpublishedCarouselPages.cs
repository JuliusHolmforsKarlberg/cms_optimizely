using EPiServer.PlugIn;
using EPiServer.Scheduler;
using EPiServer.Web;
using Nackademin2023v2.Business.Extensions;
using Nackademin2023v2.Models.Pages;

namespace Nackademin2023v2.Business.ScheduledJobs
{
    [ScheduledPlugIn(
        GUID = "D98EFC8A-5BEE-426A-9ED2-937F04851755",
        DisplayName = "Delete Unpublished Carousel Pages",
        Description = "This job deletes unpublished carousel pages"
    )]
    public class DeleteUnpublishedCarouselPages : ScheduledJobBase
    {
        private readonly IContentLoader _contentLoader;
        private readonly ISiteDefinitionRepository _siteDefinitionRepository;
        private readonly IContentRepository _contentRepository;
        private bool _stopSignaled;

        public DeleteUnpublishedCarouselPages(IContentLoader contentLoader,
            ISiteDefinitionRepository siteDefinitionRepository, IContentRepository contentRepository)
        {
            _contentLoader = contentLoader;
            _siteDefinitionRepository = siteDefinitionRepository;
            _contentRepository = contentRepository;

            IsStoppable = true;
        }

        public override void Stop()
        {
            _stopSignaled = true;
        }

        public override string Execute()
        {
            var carouselPages = GetCarouselPages();
            var status = 0;

            foreach (var item in carouselPages)
            {
                if (item.StopPublish != null)
                {
                    _contentRepository.Delete(item.ContentLink, true, EPiServer.Security.AccessLevel.NoAccess);

                    status++;
                }
            }

            if (_stopSignaled)
            {
                return "The job has been cancelled";
            }

            return $"Unpublished carousel pages deleted: {status}";
        }

        private IEnumerable<CarouselPage> GetCarouselPages()
        {
            var contentReference = _siteDefinitionRepository.List().FirstOrDefault().StartPage;
            var startPage = _contentLoader.Get<StartPage>(contentReference);
            var carouselPages = new List<CarouselPage>();

            startPage.GetDescendantsOfType(carouselPages);

            return carouselPages;
        }
    }
}
