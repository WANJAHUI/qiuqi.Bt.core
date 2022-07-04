using System.Collections.Concurrent;

namespace System.Collections.Generic
{
    public static class BtDictionaryExtensions
    {

        internal static bool TryGetValue<T>(this IDictionary<string, object> dictionary, string key, out T value)
        {
            if (dictionary.TryGetValue(key, out var value2) && value2 is T)
            {
                value = (T)value2;
                return true;
            }

            value = default(T);
            return false;
        }

        public static TValue GetOrDefault<TKey, TValue>(this Dictionary<TKey, TValue> dictionary, TKey key)
        {
            TValue value;
            return dictionary.TryGetValue(key, out value) ? value : default(TValue);
        }

        public static TValue GetOrDefault<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key)
        {
            TValue value;
            return dictionary.TryGetValue(key, out value) ? value : default(TValue);
        }

        public static TValue GetOrDefault<TKey, TValue>(this IReadOnlyDictionary<TKey, TValue> dictionary, TKey key)
        {
            TValue value;
            return dictionary.TryGetValue(key, out value) ? value : default(TValue);
        }

        public static TValue GetOrDefault<TKey, TValue>(this ConcurrentDictionary<TKey, TValue> dictionary, TKey key)
        {
            TValue value;
            return dictionary.TryGetValue(key, out value) ? value : default(TValue);
        }

        public static TValue GetOrAdd<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, Func<TKey, TValue> factory)
        {
            if (dictionary.TryGetValue(key, out var value))
            {
                return value;
            }

            return dictionary[key] = factory(key);
        }

        public static TValue GetOrAdd<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, Func<TValue> factory)
        {
            return dictionary.GetOrAdd(key, (TKey k) => factory());
        }
        public static TValue GetOrAdd<TKey, TValue>(this ConcurrentDictionary<TKey, TValue> dictionary, TKey key, Func<TValue> factory)
        {
            return dictionary.GetOrAdd(key, delegate
            {
                return factory();
            });
        }
        }
}