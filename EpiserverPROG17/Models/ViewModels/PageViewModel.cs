﻿using EPiServer.Core;
using EpiserverPROG17.Models.Pages;
using System.Collections.Generic;

namespace EpiserverPROG17.Models.ViewModels
{
    public class PageViewModel<T> : IPageViewModel<T> where T : SitePageData
    {
        public T CurrentPage { get; set; }
        public StartPage StartPage { get; set; }
        public IEnumerable<SitePageData> MenuPages { get; set; }
        public IContent Section { get; set; }

        public PageViewModel(T currentPage) { CurrentPage = currentPage; }
    }

    public static class PageViewModel
    {
        public static PageViewModel<T> Create<T>(T currentPage)
            where T : SitePageData
        { return new PageViewModel<T>(currentPage); }
    }
}