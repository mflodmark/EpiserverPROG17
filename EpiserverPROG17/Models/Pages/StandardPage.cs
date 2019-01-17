using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace EpiserverPROG17.Models.Pages
{
    [ContentType(DisplayName = "Standard",
            GroupName = SiteGroupNames.Common,
            Description = "Use this page type unless you need a more specialized one")]
    //[SitePageIcon]
    [AvailableContentTypes(Include = new[] { typeof(StandardPage) })]
    public class StandardPage : SitePageData
    {

        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 150)]
        public virtual XhtmlString MainBody { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Main content area",
            Description = "Drag and drop images, blocks, folders, and pages with partial templates.",
            GroupName = SystemTabNames.Content, Order = 200)]
        [AllowedTypes(typeof(StandardPage), typeof(BlockData),
            typeof(ImageData), typeof(ContentFolder))]
        public virtual ContentArea MainContentArea { get; set; }

    }
}