using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuggestiveService
{
    public static class Extensions
    {
        public static bool EqualNoCase(this string value, string secondValue)
        {
            return string.Equals(value, secondValue, StringComparison.InvariantCultureIgnoreCase);
        }

        public static bool HasKey(this ConcurrentDictionary<string, ConcurrentBag<string>> value, string key)
        {
            return value.ContainsKey(key.ToLowerInvariant());
        }

        public static ConcurrentBag<string> GetVal(this ConcurrentDictionary<string, ConcurrentBag<string>> value, string key)
        {
            return value[key.ToLowerInvariant()];
        }

        public static void AddVal(this ConcurrentDictionary<string, ConcurrentBag<string>> value, string key, string val)
        {
            value[key.ToLowerInvariant()].Add(val.ToLowerInvariant());
        }

        public static void AddData(this ConcurrentDictionary<string, ConcurrentBag<string>> value, string key, ConcurrentBag<string> val)
        {
            var lowVal = val.Select(v => v.ToLowerInvariant());

            value.TryAdd(key.ToLowerInvariant(), new ConcurrentBag<string>(lowVal));
        }
    }
}
