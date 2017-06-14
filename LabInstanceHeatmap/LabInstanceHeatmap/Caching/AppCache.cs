using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Caching;

namespace LabInstanceHeatmap.Caching
{
    public class AppCache : IAppCache
    {
        private readonly ICache _cache;
        private readonly LabListRepository _labListRepository;
        private const string LabCacheKey = "LabCoordinates";

        public AppCache(LabListRepository labListRepository, ICache cache)
        {
            _labListRepository = labListRepository;
            _cache = cache;
        }

        public List<LabInstanceCacheModel> GetPoints()
        {
            var cacheKeyName = LabCacheKey;
            var points = _cache.Get(cacheKeyName) as List<LabInstanceCacheModel>;

            if (points == null)
            {
                points = _labListRepository.GetLabPoints();
                if (points != null)
                {
                    _cache.Insert(cacheKeyName, points, null, AbsoluteExpiration, Cache.NoSlidingExpiration);
                }
            }
            return points;
        }

        public DateTime AbsoluteExpiration => DateTime.Now.AddHours(Int32.Parse(ConfigurationManager.AppSettings["CacheExpiration"]));
    }

    public class LabListRepository
    {
        private readonly LabOnDemand _db = new LabOnDemand();
        private List<LabInstanceCacheModel> _labList = new List<LabInstanceCacheModel>();

        public List<LabInstanceCacheModel> GetLabPoints()
        {
            var theDate = DateTime.UtcNow.AddHours(-24);
            _labList = _db.LabInstances.Where(x => x.StartTime >= theDate && x.Latitude.HasValue && x.Longitude.HasValue).Select(x => new LabInstanceCacheModel
            {
                Latitude = x.Latitude,
                Longitude = x.Longitude
            }).ToList();

            return _labList;
        }
    }

    public interface IAppCache
    {
        List<LabInstanceCacheModel> GetPoints();
    }
}