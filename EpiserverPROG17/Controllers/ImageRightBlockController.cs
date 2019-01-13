using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Web;
using EPiServer.Web.Mvc;
using EpiserverPROG17.Models.Blocks;

namespace EpiserverPROG17.Controllers
{
    public class ImageRightBlockController : BlockController<ImageRightBlock>
    {
        public override ActionResult Index(ImageRightBlock currentBlock)
        {
            return PartialView(currentBlock);
        }
    }
}
