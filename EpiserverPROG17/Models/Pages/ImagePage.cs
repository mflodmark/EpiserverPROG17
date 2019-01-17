using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace EpiserverPROG17.Models.Pages
{
    [ContentType(DisplayName = "Image",
            GroupName = SiteGroupNames.Common,
            Description = "Show images")]
    //[SitePageIcon]
    [AvailableContentTypes(Include = new[] { typeof(StandardPage) })]
    public class ImagePage : SitePageData
    {
               
    }
}