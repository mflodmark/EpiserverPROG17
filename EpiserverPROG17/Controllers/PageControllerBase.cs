using EPiServer;
using EPiServer.Core;
using EPiServer.Filters;
using EPiServer.Web.Mvc;
using EpiserverPROG17.Business.ExtensionMethods;
using EpiserverPROG17.Models.Pages;
using EpiserverPROG17.Models.ViewModels;
using System.Linq;

namespace EpiserverPROG17.Controllers
{
    public abstract class PageControllerBase<T> : PageController<T> where T : SitePageData
    {
        protected readonly IContentLoader loader;

        public PageControllerBase(IContentLoader loader) { this.loader = loader; }

        protected IPageViewModel<TPage> CreatePageViewModel<TPage>(TPage currentPage) where TPage : SitePageData
        {
            var viewmodel = PageViewModel.Create(currentPage);

            viewmodel.StartPage = loader.Get<StartPage>(ContentReference.StartPage);

            viewmodel.MenuPages = FilterForVisitor.Filter(loader.GetChildren<SitePageData>(ContentReference.StartPage)).Cast<SitePageData>().Where(page => page.VisibleInMenu);

            viewmodel.Section = currentPage.ContentLink.GetSection();

            return viewmodel;
        }
    }
}