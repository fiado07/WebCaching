using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebCaching.Contracts
{
   public  interface ICache
    {

        void RemoveCache(string key);

        void AddCache(string key, object data);

        T GetCachedData<T>(string key);

    }
}
