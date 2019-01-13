using System.Web.Mvc;
using EPiServer.Web.Mvc;
using EpiserverPROG17.Models.Blocks;

namespace EpiserverPROG17.Controllers
{
    public class ImageLeftBlockController : BlockController<ImageLeftBlock>
    {
        public override ActionResult Index(ImageLeftBlock currentBlock)
        {
            return PartialView(currentBlock);
        }
    }
}
