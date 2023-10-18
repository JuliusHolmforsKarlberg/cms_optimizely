using static Nackademin2023v2.Globals;
using System.ComponentModel.DataAnnotations;
using Nackademin2023v2.Business.Descriptors;

namespace Nackademin2023v2.Models.Pages
{
    [ContentType(
        GUID = "2F3DF028-1204-4CB4-95B2-0D181704757C",
        GroupName = GroupNames.Specialized
    )]
    [ImageUrl("/gfx/page-type-thumbnail.png")]
    public class SettingsPage : SitePageData, ISettingsIcon
    {
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 10
        )]
        public virtual PageReference MoviesContainer { get; set; }
    }
}
