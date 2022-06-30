using Bt.core.Utils;


namespace System.Collections.Generic
{
    public static class BtCollectionExtensions
    {
		public static bool IsNullOrEmpty<T>(this ICollection<T> source)
		{
			return source == null || source.Count <= 0;
		}

		public static bool AddIfNotContains<T>(this ICollection<T> source, T item)
		{
			Check.NotNull(source, "source");
			if (source.Contains(item))
			{
				return false;
			}
			source.Add(item);
			return true;
		}

		public static IEnumerable<T> AddIfNotContains<T>(this ICollection<T> source, IEnumerable<T> items)
		{
			Check.NotNull(source, "source");
			List<T> list = new List<T>();
			foreach (T item in items)
			{
				if (!source.Contains(item))
				{
					source.Add(item);
					list.Add(item);
				}
			}
			return list;
		}

		public static bool AddIfNotContains<T>(this ICollection<T> source, Func<T, bool> predicate, Func<T> itemFactory)
		{
			Check.NotNull(source, "source");
			Check.NotNull(predicate, "predicate");
			Check.NotNull(itemFactory, "itemFactory");
			if (source.Any(predicate))
			{
				return false;
			}
			source.Add(itemFactory());
			return true;
		}

		public static IList<T> RemoveAll<T>(this ICollection<T> source, Func<T, bool> predicate)
		{
			List<T> list = source.Where(predicate).ToList();
			foreach (T item in list)
			{
				source.Remove(item);
			}
			return list;
		}
	}
}
