using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Caching;

namespace LabInstanceHeatmap.Caching
{
    public class WebCache : ICache
    {

        public object Get(string key)
        {
            return HttpRuntime.Cache[key];
        }

        public object Remove(string key)
        {
            return HttpRuntime.Cache.Remove(key);
        }

        public void Insert(string key, object value, string[] dependencyKeys, DateTime absoluteExpiration, TimeSpan slidingExpiration)
        {
            var dependency = dependencyKeys != null && dependencyKeys.Length > 0 ? new CacheDependency(null, dependencyKeys) : null;
            HttpRuntime.Cache.Insert(key, value, dependency, absoluteExpiration, slidingExpiration);
        }

        public IDictionaryEnumerator GetEnumerator()
        {
            return HttpRuntime.Cache.GetEnumerator();
        }
    }
}