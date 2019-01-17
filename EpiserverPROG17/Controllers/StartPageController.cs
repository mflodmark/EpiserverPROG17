using EPiServer;
using EpiserverPROG17.Models.Pages;
using System.Web.Mvc;

namespace EpiserverPROG17.Controllers
{
    public class StartPageController : PageControllerBase<StartPage>
    {

        public StartPageController(IContentLoader loader) : base(loader)
        {

        }

        public ActionResult Index(StartPage currentPage)
        {
            /* Implementation of action. You can create your own view model class that you pass to the view or
             * you can pass the page type for simpler templates */

            return View(CreatePageViewModel(currentPage));
        }
    }
}