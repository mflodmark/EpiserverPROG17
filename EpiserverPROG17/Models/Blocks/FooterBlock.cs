using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace EpiserverPROG17.Models.Blocks
{
    [ContentType(
        DisplayName = "FooterBlock", 
        GUID = "eb7a35ca-83b1-492f-af79-cd035911032f",
        Description = "Used this for footer",
        AvailableInEditMode = false)]
    public class FooterBlock : BlockData
    {

        [CultureSpecific]
        [Display(
            Name = "Footer",
            Description = "Footer text",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string FooterText { get; set; }

    }
}