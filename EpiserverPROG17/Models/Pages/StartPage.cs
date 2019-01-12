﻿using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;
using System.ComponentModel.DataAnnotations;

namespace EpiserverPROG17.Models.Pages
{
    [ContentType(DisplayName = "Start",
        GroupName = SiteGroupNames.Specialized,
        GUID = "088b0f68-e005-44d1-9cce-127af7c40c97",
        Description = "Used as start page")]
    public class StartPage : PageData
    {
        [CultureSpecific]
        [Display(
            Name = "Heading",
            Description = "If the Heading is not set, the page falls back to showing the Name.",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual string Heading { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Description",
            Description = "Description of the page",
            GroupName = SystemTabNames.Content,
            Order = 20)]
        public virtual string Description { get; set; }


        [CultureSpecific]
        [Display(
            Name = "Twitter",
            Description = "Link to twitter page",
            GroupName = SystemTabNames.Content,
            Order = 30)]
        public virtual string TwitterLink { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Github",
            Description = "Link to github page",
            GroupName = SystemTabNames.Content,
            Order = 40)]
        public virtual string GithubLink { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Linkedin",
            Description = "Link to linkedin page",
            GroupName = SystemTabNames.Content,
            Order = 50)]
        public virtual string LinkedinLink { get; set; }


        [Display(
            Name = "Page image", 
            GroupName = SystemTabNames.Content, 
            Order = 100)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference PageImage { get; set; }

        //    [CultureSpecific]
        //    [Display(
        //        Name = "Main body",
        //        Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
        //        GroupName = SystemTabNames.Content,
        //        Order = 1)]
        //    public virtual XhtmlString MainBody { get; set; }

        //    [CultureSpecific]
        //    [Display(Name = "Main content area",
        //Description = "Drag and drop images, blocks, folders, and pages with partial templates.",
        //GroupName = SystemTabNames.Content, Order = 30)]
        //    [AllowedTypes(typeof(StandardPage), typeof(BlockData),
        //typeof(ImageData), typeof(ContentFolder))]
        //    public virtual ContentArea MainContentArea { get; set; }

    }
}