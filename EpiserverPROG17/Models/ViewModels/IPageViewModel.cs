using EPiServer.Core;
using EpiserverPROG17.Models.Pages;
using System.Collections.Generic;

namespace EpiserverPROG17.Models.ViewModels
{
    public interface IPageViewModel<out T> where T : SitePageData
    {
        T CurrentPage { get; }
        StartPage StartPage { get; }
        IEnumerable<SitePageData> MenuPages { get; }
        IContent Section { get; }
    }
}