using EPiServer.Web;
using System.ComponentModel.DataAnnotations;
using static Nackademin2023v2.Globals;

namespace Nackademin2023v2.Models.Pages
{
    [ContentType(
        GUID = "EBBD5109-A981-4232-933F-4CE1115B71A9",
        GroupName = GroupNames.Specialized,
        DisplayName = "Start",
        Description = "This is a start template"
    )]
    [AvailableContentTypes(Availability.Specific,
        Include = new[]
        {
            typeof(SettingsPage)
        }
    )]
    [ImageUrl("/gfx/snoopy.jpg")]
    public class StartPage : SitePageData
    {
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 10,
            Name = "Image",
            Description = "This is an image"
        )]
        [UIHint(UIHint.Image)]
        public virtual ContentReference? Image { get; set; }

        [Display(
            GroupName = SystemTabNames.Content,
            Order = 20
        )]
        public virtual string Heading { get; set; } = string.Empty;

        [Display(
            GroupName = SystemTabNames.Content,
            Order = 30
        )]
        [UIHint(UIHint.Textarea)]
        public virtual XhtmlString Preamble { get; set; }

        [Display(
            GroupName = SystemTabNames.Content,
            Order = 40
        )]
        public virtual XhtmlString MainBody { get; set; }
    }
}