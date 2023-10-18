using EPiServer.SpecializedProperties;
using EPiServer.Web;
using Nackademin2023v2.Business.Descriptors;
using static Nackademin2023v2.Globals;
using System.ComponentModel.DataAnnotations;

namespace Nackademin2023v2.Models.Pages
{
    [ContentType(
        GUID = "B6C7A521-E799-4264-850F-E51103DA7642",
        GroupName = GroupNames.Specialized,
        DisplayName = "Carousel",
        Description = "This is a carousel template"
    )]
    [AvailableContentTypes(Availability.None)]
    [ImageUrl("/gfx/snoopy.jpg")]
    public class CarouselPage : SitePageData, ICarouselIcon
    {
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 10,
            Name = "Image",
            Description = "This is an image"
        )]
        [UIHint(UIHint.Image)]
        public virtual ContentReference Image { get; set; }

        [Display(
            GroupName = SystemTabNames.Content,
            Order = 20
        )]
        [CultureSpecific]
        public virtual string Heading { get; set; } = string.Empty;

        [Display(
            GroupName = SystemTabNames.Content,
            Order = 30
        )]
        [CultureSpecific]
        public virtual XhtmlString Text { get; set; }

        [Display(
            GroupName = SystemTabNames.Content,
            Order = 40
        )]
        [CultureSpecific]
        public virtual LinkItem Link { get; set; }
    }
}
