using EPiServer.Web;
using Nackademin2023v2.Models.Blocks;
using System.ComponentModel.DataAnnotations;
using static Nackademin2023v2.Globals;

namespace Nackademin2023v2.Models.Pages
{
    [ContentType(
        GUID = "16853DBB-F04E-4FBB-891C-C8217FBDA05D",
        GroupName = GroupNames.Specialized,
        DisplayName = "Start",
        Description = "This is a start template"
    )]
    [AvailableContentTypes(Availability.Specific,
        Include = new[]
        {
            typeof(SettingsPage),
            typeof(ContainerPage)
        }
    )]
    [ImageUrl("/gfx/page-type-thumbnail.png")]
    public class StartPage : SitePageData
    {
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 10
        )]
        [AllowedTypes(typeof(CarouselPage), typeof(CarouselBlock))]
        public virtual ContentArea Carousel { get; set; }
    }
}