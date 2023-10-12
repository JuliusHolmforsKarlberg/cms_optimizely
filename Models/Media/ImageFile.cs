using EPiServer.Framework.DataAnnotations;

namespace Nackademin2023v2.Models.Media
{
    [ContentType(
        GUID = "E733EEF4-553D-4162-9BC9-984F15F52D8D"
    )]
    [MediaDescriptor(ExtensionString = "jpg,jpeg,jpe,ico,png,gif,bmp,webp")]
    public class ImageFile : ImageData
    {
    }
}