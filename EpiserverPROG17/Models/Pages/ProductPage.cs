using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace EpiserverPROG17.Models.Pages
{
    [ContentType(DisplayName = "Product",
        GroupName = SiteGroupNames.Specialized,
        Description = "Use this for software products")]
    //[SiteCommerceIcon]
    public class ProductPage : SitePageData
    {
        [Display(Name = "Header",
            Description = "Header text",
            GroupName = SystemTabNames.Content, Order = 30)]
        public virtual string Header { get; set; }

        [Display(Name = "Main content area",
            Description = "Drag and drop blocks and pages with partial templates.",
            GroupName = SystemTabNames.Content, Order = 330)]
        public virtual ContentArea MainContentArea { get; set; }

    }
}