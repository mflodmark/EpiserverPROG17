using EPiServer;
using EPiServer.Core;
using EPiServer.Filters;
using EPiServer.Web.Mvc;
using EpiserverPROG17.Models.Blocks;
using EpiserverPROG17.Models.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace EpiserverPROG17.Controllers
{
    public class ListingBlockController : BlockController<ListingBlock>
    {
        private readonly IContentLoader loader;

        public ListingBlockController(IContentLoader loader)
        {
            this.loader = loader;
        }

        public override ActionResult Index(ListingBlock currentBlock)
        {
            var vm = new ListingBlockViewModel()
            {
                Heading = currentBlock.Heading
            };


            if (currentBlock.ShowChildrenOfThisPage != null)
            {
                IEnumerable<PageData> children = loader
                    .GetChildren<PageData>(currentBlock.ShowChildrenOfThisPage);
                IEnumerable<IContent> filteredChildren = FilterForVisitor
                    .Filter(children);
                vm.Pages = filteredChildren.Cast<PageData>()
                    .Where(page => page.VisibleInMenu);
            }

            return PartialView(vm);
        }
    }
}
