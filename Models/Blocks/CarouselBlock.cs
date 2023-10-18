using Nackademin2023v2.Models.Pages;
using static Nackademin2023v2.Globals;
using System.ComponentModel.DataAnnotations;

namespace Nackademin2023v2.Models.Blocks
{
    [ContentType(
        GUID = "5BD135AD-E878-42D3-9BB7-8ACF67ABC437",
        GroupName = GroupNames.Specialized,
        DisplayName = "Carousel Block",
        Description = "This is a carousel block template"
    )]
    [ImageUrl("/gfx/page-type-thumbnail.png")]
    public class CarouselBlock : BlockData
    {
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 10
        )]
        [AllowedTypes(typeof(CarouselPage))]
        public virtual ContentArea Carousel { get; set; }
    }
}
