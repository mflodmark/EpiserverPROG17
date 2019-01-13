using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations;

namespace EpiserverPROG17.Models.Blocks
{
    [ContentType(DisplayName = "Employee",
        GroupName = SiteGroupNames.Specialized,
        GUID = "f94ef0b2-2972-4c70-ade0-38564639cafa",
        Description = "Use this to store information about an employee")]
    //[SiteBlockIcon]
    public class EmployeeBlock : BlockData
    {
        [Display(Name = "First name", GroupName = SystemTabNames.Content, Order = 10)]
        public virtual string FirstName { get; set; }

        [Display(Name = "Last name", GroupName = SystemTabNames.Content, Order = 20)]
        public virtual string LastName { get; set; }

        [Display(Name = "Hire date", GroupName = SystemTabNames.Content, Order = 30)]
        public virtual DateTime? HireDate { get; set; }

        [CultureSpecific]
        [Display(Name = "Rich text", Order = 50)]
        public virtual XhtmlString Description { get; set; }
    }
}