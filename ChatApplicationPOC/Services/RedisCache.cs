using StackExchange.Redis;
using System;
using System.Threading.Tasks;
namespace WetherReport.Services
{
    public class RedisCache
    {
        private readonly ConnectionMultiplexer _redis;
        private readonly IDatabase _db;

        public RedisCache(string configuration)
        {
            _redis = ConnectionMultiplexer.Connect(configuration);
            _db = _redis.GetDatabase();
        }

        public async Task SetCacheValueAsync(string key, string value)
        {
            await _db.StringSetAsync(key, value);
            Console.WriteLine($"Cached '{key}' with value '{value}'.");
        }

        public async Task<string> GetCacheValueAsync(string key)
        {
            var value = await _db.StringGetAsync(key);
            Console.WriteLine($"Retrieved '{key}' with value '{value}'.");
            return value;
        }
    }
}
