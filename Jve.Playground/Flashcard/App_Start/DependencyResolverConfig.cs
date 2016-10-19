using SimpleInjector.Integration.WebApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using Flashcard.Core.DataAccess;
using SimpleInjector;

namespace Flashcard
{
    public static class DependencyResolverConfig
    {
        public static void Configure(HttpConfiguration config)
        {
            var container = new Container();

            container.Register<IFlashcardService, FlashcardDummyService>(Lifestyle.Singleton);

            container.Verify();
            config.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(container);
        }
    }
}