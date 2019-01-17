using EPiServer;
using EPiServer.Cms.Shell.Json.Internal;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace EpiserverPROG17.Models.Blocks
{
    //[SiteBlockIcon]
    [ContentType(DisplayName = "Image right",
    GroupName = SiteGroupNames.Common,
    Description = "Image right and text left block")]
    public class ImageRightBlock: BlockData
    {
        [CultureSpecific]
        [Display(Name = "Heading", Order = 10, GroupName = SystemTabNames.PageHeader)]
        public virtual string Heading { get; set; }

        [CultureSpecific]
        [Display(Name = "Heading 2", Order = 15, GroupName = SystemTabNames.PageHeader)]
        public virtual string Heading2 { get; set; }

        [CultureSpecific]
        [Display(Name = "Rich text before link", Order = 20)]
        public virtual XhtmlString Text { get; set; }

        [Display(Name = "Link", Order = 40, GroupName = SystemTabNames.PageHeader)]
        [JsonProperty]
        [JsonConverter(typeof(UrlConverter))]
        public virtual Url Link { get; set; }

        [Display(Name = "Link text", Order = 45, GroupName = SystemTabNames.PageHeader)]
        public virtual string LinkText { get; set; }

        [CultureSpecific]
        [Display(Name = "Rich text after link", Order = 50)]
        public virtual XhtmlString Text2 { get; set; }

        [Display(Name = "Image", Order = 60, GroupName = SystemTabNames.PageHeader)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference Image { get; set; }

    }
}

