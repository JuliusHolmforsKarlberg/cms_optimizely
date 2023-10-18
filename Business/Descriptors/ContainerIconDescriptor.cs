using EPiServer.Shell;

namespace Nackademin2023v2.Business.Descriptors
{
    [UIDescriptorRegistration]
    public class ContainerIconDescriptor : UIDescriptor<IContainerIcon>
    {
        public ContainerIconDescriptor()
        {
            IconClass = ContentIcons.ObjectIcons.Container;
        }
    }

    public interface IContainerIcon
    {
    }
}
