

using System.Globalization;

namespace System
{
    public static class BtObjectExtensions
    {
		public static T As<T>(this object obj) where T : class
		{
			return (T)obj;
		}

		public static T To<T>(this object obj) where T : struct
		{
			return (T)Convert.ChangeType(obj, typeof(T), CultureInfo.InvariantCulture);
		}

		public static bool IsIn<T>(this T item, params T[] list)
		{
			return list.Contains(item);
		}
	}
}
