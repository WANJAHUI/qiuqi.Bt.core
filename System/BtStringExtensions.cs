using Bt.core.Utils;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;


namespace System
{
    public static class BtStringExtensions
    {
		public static string EnsureEndsWith(this string str, char c, StringComparison comparisonType = StringComparison.Ordinal)
		{
			Check.NotNull<string>(str, "str");
			if (str.EndsWith(c.ToString(), comparisonType))
			{
				return str;
			}
			return str + c;
		}

		public static string EnsureStartsWith(this string str, char c, StringComparison comparisonType = StringComparison.Ordinal)
		{
			Check.NotNull<string>(str, "str");
			if (str.StartsWith(c.ToString(), comparisonType))
			{
				return str;
			}
			return c + str;
		}

		public static bool IsNullOrEmpty(this string str)
		{
			return string.IsNullOrEmpty(str);
		}

		public static bool IsNullOrWhiteSpace(this string str)
		{
			return string.IsNullOrWhiteSpace(str);
		}

		public static string Left(this string str, int len)
		{
			Check.NotNull<string>(str, "str");
			if (str.Length < len)
			{
				throw new ArgumentException("len argument can not be bigger than given string's length!");
			}
			return str.Substring(0, len);
		}

		public static string NormalizeLineEndings(this string str)
		{
			return str.Replace("\r\n", "\n").Replace("\r", "\n").Replace("\n", Environment.NewLine);
		}

		public static int NthIndexOf(this string str, char c, int n)
		{
			Check.NotNull<string>(str, "str");
			int num = 0;
			for (int i = 0; i < str.Length; i++)
			{
				if (str[i] == c && ++num == n)
				{
					return i;
				}
			}
			return -1;
		}

		public static string RemovePostFix(this string str, params string[] postFixes)
		{
			return str.RemovePostFix(StringComparison.Ordinal, postFixes);
		}

		public static string RemovePostFix(this string str, StringComparison comparisonType, params string[] postFixes)
		{
			if (str.IsNullOrEmpty())
			{
				return null;
			}
			if (postFixes.IsNullOrEmpty())
			{
				return str;
			}
			foreach (string text in postFixes)
			{
				if (str.EndsWith(text, comparisonType))
				{
					return str.Left(str.Length - text.Length);
				}
			}
			return str;
		}

		public static string RemovePreFix(this string str, params string[] preFixes)
		{
			return str.RemovePreFix(StringComparison.Ordinal, preFixes);
		}

		public static string RemovePreFix(this string str, StringComparison comparisonType, params string[] preFixes)
		{
			if (str.IsNullOrEmpty())
			{
				return null;
			}
			if (preFixes.IsNullOrEmpty())
			{
				return str;
			}
			foreach (string text in preFixes)
			{
				if (str.StartsWith(text, comparisonType))
				{
					return str.Right(str.Length - text.Length);
				}
			}
			return str;
		}

		public static string ReplaceFirst(this string str, string search, string replace, StringComparison comparisonType = StringComparison.Ordinal)
		{
			Check.NotNull<string>(str, "str");
			int num = str.IndexOf(search, comparisonType);
			if (num < 0)
			{
				return str;
			}
			return str.Substring(0, num) + replace + str.Substring(num + search.Length);
		}

		public static string Right(this string str, int len)
		{
			Check.NotNull<string>(str, "str");
			if (str.Length < len)
			{
				throw new ArgumentException("len argument can not be bigger than given string's length!");
			}
			return str.Substring(str.Length - len, len);
		}

		public static string[] Split(this string str, string separator)
		{
			return str.Split(new string[1] { separator }, StringSplitOptions.None);
		}

		public static string[] Split(this string str, string separator, StringSplitOptions options)
		{
			return str.Split(new string[1] { separator }, options);
		}

		public static string[] SplitToLines(this string str)
		{
			return str.Split(Environment.NewLine);
		}

		public static string[] SplitToLines(this string str, StringSplitOptions options)
		{
			return str.Split(Environment.NewLine, options);
		}

		public static string ToCamelCase(this string str, bool useCurrentCulture = false)
		{
			if (string.IsNullOrWhiteSpace(str))
			{
				return str;
			}
			if (str.Length == 1)
			{
				return useCurrentCulture ? str.ToLower() : str.ToLowerInvariant();
			}
			return (useCurrentCulture ? char.ToLower(str[0]) : char.ToLowerInvariant(str[0])) + str.Substring(1);
		}

		public static string ToSentenceCase(this string str, bool useCurrentCulture = false)
		{
			if (string.IsNullOrWhiteSpace(str))
			{
				return str;
			}
			return useCurrentCulture ? Regex.Replace(str, "[a-z][A-Z]", (Match m) => m.Value[0] + " " + char.ToLower(m.Value[1])) : Regex.Replace(str, "[a-z][A-Z]", (Match m) => m.Value[0] + " " + char.ToLowerInvariant(m.Value[1]));
		}

		public static string ToKebabCase(this string str, bool useCurrentCulture = false)
		{
			if (string.IsNullOrWhiteSpace(str))
			{
				return str;
			}
			str = str.ToCamelCase();
			return useCurrentCulture ? Regex.Replace(str, "[a-z][A-Z]", (Match m) => m.Value[0] + "-" + char.ToLower(m.Value[1])) : Regex.Replace(str, "[a-z][A-Z]", (Match m) => m.Value[0] + "-" + char.ToLowerInvariant(m.Value[1]));
		}

		public static T ToEnum<T>(this string value) where T : struct
		{
			Check.NotNull<string>(value, "value");
			return (T)Enum.Parse(typeof(T), value);
		}

		public static T ToEnum<T>(this string value, bool ignoreCase) where T : struct
		{
			Check.NotNull<string>(value, "value");
			return (T)Enum.Parse(typeof(T), value, ignoreCase);
		}

		public static string ToMd5(this string str)
		{
			using MD5 mD = MD5.Create();
			byte[] bytes = Encoding.UTF8.GetBytes(str);
			byte[] array = mD.ComputeHash(bytes);
			StringBuilder stringBuilder = new StringBuilder();
			byte[] array2 = array;
			foreach (byte b in array2)
			{
				stringBuilder.Append(b.ToString("X2"));
			}
			return stringBuilder.ToString();
		}

		public static string ToPascalCase(this string str, bool useCurrentCulture = false)
		{
			if (string.IsNullOrWhiteSpace(str))
			{
				return str;
			}
			if (str.Length == 1)
			{
				return useCurrentCulture ? str.ToUpper() : str.ToUpperInvariant();
			}
			return (useCurrentCulture ? char.ToUpper(str[0]) : char.ToUpperInvariant(str[0])) + str.Substring(1);
		}

		public static string Truncate(this string str, int maxLength)
		{
			if (str == null)
			{
				return null;
			}
			if (str.Length <= maxLength)
			{
				return str;
			}
			return str.Left(maxLength);
		}

		public static string TruncateFromBeginning(this string str, int maxLength)
		{
			if (str == null)
			{
				return null;
			}
			if (str.Length <= maxLength)
			{
				return str;
			}
			return str.Right(maxLength);
		}

		public static string TruncateWithPostfix(this string str, int maxLength)
		{
			return str.TruncateWithPostfix(maxLength, "...");
		}

		public static string TruncateWithPostfix(this string str, int maxLength, string postfix)
		{
			if (str == null)
			{
				return null;
			}
			if (str == string.Empty || maxLength == 0)
			{
				return string.Empty;
			}
			if (str.Length <= maxLength)
			{
				return str;
			}
			if (maxLength <= postfix.Length)
			{
				return postfix.Left(maxLength);
			}
			return str.Left(maxLength - postfix.Length) + postfix;
		}

		public static byte[] GetBytes(this string str)
		{
			return str.GetBytes(Encoding.UTF8);
		}

		public static byte[] GetBytes(this string str, Encoding encoding)
		{
			Check.NotNull<string>(str, "str");
			Check.NotNull(encoding, "encoding");
			return encoding.GetBytes(str);
		}
	}
}
