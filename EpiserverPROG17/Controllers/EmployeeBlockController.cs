using System.Web.Mvc;
using EPiServer.Web.Mvc;
using EpiserverPROG17.Models.Blocks;

namespace EpiserverPROG17.Controllers
{
    public class EmployeeBlockController : BlockController<EmployeeBlock>
    {
        public override ActionResult Index(EmployeeBlock currentBlock)
        {
            return PartialView(currentBlock);
        }
    }
}
