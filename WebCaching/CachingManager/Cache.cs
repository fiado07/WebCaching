using System;
using System.Web;
using WebCaching.Contracts;

namespace WebCaching.CachingManager
{
    public class Cache : ICache
    {

        private static readonly Lazy<Cache> lazyCache = new Lazy<Cache>(() => new Cache());

        public static Cache Caching { get { return lazyCache.Value; } }


        private Cache()
        {
                
        }

        public void AddCache(string key, object data)
        {

            HttpContext.Current.Cache.Insert(key, data);

        }

        public T GetCachedData<T>(string key)
        {

          T data = (T)HttpContext.Current.Cache.Get(key) ;

            if (data == null)
                data = default(T);

            return data;  

        }

        public void RemoveCache(string key)
        {
            HttpContext.Current.Cache.Remove(key);
        }
    }
}
