using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Framework.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace EpiserverPROG17.Models.Media
{
    [ContentType(DisplayName = "Image File",
        GUID = "361d39e8-aef2-4d64-9098-cab5957eef73",
        Description = "“Use this to upload image files")]
    [MediaDescriptor(ExtensionString = "png,gif,jpg,jpeg")]
    public class ImageFile : ImageData
    {

        [CultureSpecific]
        [Editable(true)]
        [Display(
            Name = "Description",
            Description = "Description field's description",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string Description { get; set; }

    }
}