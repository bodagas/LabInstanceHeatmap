using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LabInstanceHeatmap.Caching;

namespace LabInstanceHeatmap.Infrastructure
{
    public static class AppConfiguration
    {
        public static void Configure()
        {
            App.Cache = new AppCache(new LabListRepository(), new WebCache());
        }
    }
}