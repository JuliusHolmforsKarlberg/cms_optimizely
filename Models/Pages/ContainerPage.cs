using Nackademin2023v2.Business.Descriptors;
using static Nackademin2023v2.Globals;

namespace Nackademin2023v2.Models.Pages
{
    [ContentType(
        GUID = "923925F4-C5D1-40BF-820B-F976B1633D24",
        GroupName = GroupNames.Specialized,
        DisplayName = "Container",
        Description = "This is a container template"
    )]
    [AvailableContentTypes(
        Availability.Specific,
        Include = new[] { typeof(CarouselPage) }
    )]
    [ImageUrl("/gfx/snoopy.jpg")]
    public class ContainerPage : PageData, IContainerIcon
    {
    }
}
