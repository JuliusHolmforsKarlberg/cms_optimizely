using EPiServer.Shell;

namespace Nackademin2023v2.Business.Descriptors
{
    [UIDescriptorRegistration]
    public class CarouselIconDescriptor : UIDescriptor<ICarouselIcon>
    {
        public CarouselIconDescriptor()
        {
            IconClass = ContentIcons.ObjectIcons.Video;
        }
    }

    public interface ICarouselIcon
    {
    }
}
