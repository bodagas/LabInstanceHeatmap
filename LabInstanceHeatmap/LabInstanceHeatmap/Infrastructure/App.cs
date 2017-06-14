using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LabInstanceHeatmap.Caching;

namespace LabInstanceHeatmap.Infrastructure
{
    public static class App
    {
        public static IAppCache Cache { get; set; }
    }
}