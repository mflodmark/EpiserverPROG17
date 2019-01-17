using EPiServer.Core;
using System.Collections.Generic;

namespace EpiserverPROG17.Models.ViewModels
{
    public class ListingBlockViewModel
    {
        public string Heading { get; set; }
        public IEnumerable<PageData> Pages { get; set; }
    }
}