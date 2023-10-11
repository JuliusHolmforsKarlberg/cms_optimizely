using System.ComponentModel.DataAnnotations;
using static Nackademin2023v2.Globals;

namespace Nackademin2023v2.Models.Pages
{
    public abstract class SitePageData : PageData
    {
        [Display(
            GroupName = GroupNames.MetaData,
            Order = 100
        )]
        [CultureSpecific]
        public virtual string MetaTitle
        {
            get
            {
                var metaTitle = this.GetPropertyValue(p => p.MetaTitle);

                return !string.IsNullOrEmpty(metaTitle) ? metaTitle : PageName;
            }

            set => this.SetPropertyValue(p => p.MetaTitle, value);
        }
    }
}