using System;
using System.Collections;

namespace LabInstanceHeatmap.Caching
{
    public interface ICache
    {
        object Get(string key);
        object Remove(string key);
        void Insert(string key, object value, string[] dependencies, DateTime absoluteExpiration, TimeSpan slidingExpiration);
        IDictionaryEnumerator GetEnumerator();
    }
}