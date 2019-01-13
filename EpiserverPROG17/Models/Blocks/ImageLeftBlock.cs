using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;
using System.ComponentModel.DataAnnotations;

namespace EpiserverPROG17.Models.Blocks
{
    //[SiteBlockIcon]
    [ContentType(DisplayName = "Image left",
    GroupName = SiteGroupNames.Common,
    Description = "Image left and text right block")]
    public class ImageLeftBlock : BlockData
    {
        [CultureSpecific]
        [Display(Name = "Rich text", Order = 20)]
        public virtual XhtmlString Text { get; set; }

        [Display(Name = "Image", Order = 30, GroupName = SystemTabNames.PageHeader)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference Image { get; set; }
    }
}

