using System.Web.Mvc;
using EPiServer.Web.Mvc;
using EpiserverPROG17.Models.Blocks;

namespace EpiserverPROG17.Controllers
{
    public class FooterBlockController : BlockController<FooterBlock>
    {
        public override ActionResult Index(FooterBlock currentBlock)
        {
            return PartialView(currentBlock);
        }
    }
}
