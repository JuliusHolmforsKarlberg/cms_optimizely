using Nackademin2023v2.Models.Pages;
using System.ComponentModel.DataAnnotations;
using static Nackademin2023v2.Globals;

namespace Nackademin2023v2.Models.Pages
{
    [ContentType(
        GUID = "3FE11628-7473-491E-88E0-14A057F97339",
        GroupName = GroupNames.Specialized
    )]
    public class StartPage : SitePageData
    {
        [Display(
            GroupName = SystemTabNames.Content
        )]
        public virtual string Heading { get; set; } = string.Empty;
    }
}