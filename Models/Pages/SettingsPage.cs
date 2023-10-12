using static Nackademin2023v2.Globals;
using System.ComponentModel.DataAnnotations;

namespace Nackademin2023v2.Models.Pages
{
    [ContentType(
        GUID = "E1300D3A-3076-4CBB-83C0-05675A72FDF1",
        GroupName = GroupNames.Specialized
    )]
    [ImageUrl("/gfx/snoopy.jpg")]
    public class SettingsPage : SitePageData
    {
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 10
        )]
        public virtual PageReference MoviesContainer { get; set; }
    }
}
