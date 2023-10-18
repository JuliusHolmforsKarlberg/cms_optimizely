using EPiServer.Shell;

namespace Nackademin2023v2.Business.Descriptors
{
    [UIDescriptorRegistration]
    public class SettingsIconDescriptor : UIDescriptor<ISettingsIcon>
    {
        public SettingsIconDescriptor()
        {
            IconClass = ContentIcons.ActionIcons.Settings;
        }
    }

    public interface ISettingsIcon
    {
    }
}
