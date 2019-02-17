using System;
using System.Collections.Generic;
using System.Globalization;
using ParseDictionary =
    System.Collections.Concurrent.ConcurrentDictionary<System.Type, System.Func<string, object>>;

namespace DotNetHelpersAndAdditions.SystemAdditions
{
    using TryParseDictionary = System.Collections.Concurrent
        .ConcurrentDictionary<Type, _tryParseFunc<object>>;

    internal delegate bool _tryParseFunc<T>(string s, out T result);

    public static class StringAdditions
    {
        #region Private Fields

        private static readonly ParseDictionary _parseDictionary = new ParseDictionary(
            new Dictionary<Type, Func<string, object>>()
            {
                {typeof(sbyte), (x) => sbyte.Parse(x, CultureInfo.InvariantCulture) },
                {typeof(byte), (x) => byte.Parse(x, CultureInfo.InvariantCulture) },
                {typeof(short), (x) => short.Parse(x, CultureInfo.InvariantCulture) },
                {typeof(int), (x) => int.Parse(x, CultureInfo.InvariantCulture) },
                {typeof(long), (x) => long.Parse(x, CultureInfo.InvariantCulture) },
                {typeof(float), (x) => float.Parse(x, CultureInfo.InvariantCulture) },
                {typeof(double), (x) => double.Parse(x, CultureInfo.InvariantCulture) },
                {typeof(decimal), (x) => decimal.Parse(x, CultureInfo.InvariantCulture) },
                {typeof(ushort), (x) => ushort.Parse(x, CultureInfo.InvariantCulture) },
                {typeof(uint), (x) => uint.Parse(x, CultureInfo.InvariantCulture) },
                {typeof(bool), (x) => bool.Parse(x) }, {typeof(char), (x) => char.Parse(x)},
                {typeof(DateTime), (x) => DateTime.Parse(x, CultureInfo.InvariantCulture) },
                {typeof(string), (x) => x }
            });

        private static readonly TryParseDictionary _tryParseList = new TryParseDictionary(
                new Dictionary<Type, _tryParseFunc<object>>()
                {
                    {
                        typeof(sbyte),
                        delegate (string s, out object outObj)
                        {
                            outObj = default(sbyte);
                            if (sbyte.TryParse(s, out sbyte result)) { outObj = result; return true; }
                            return false;
                        }
                    },
                    {
                        typeof(byte),
                        delegate (string s, out object outObj)
                        {
                            outObj = default(byte);
                            if (byte.TryParse(s, out byte result)) { outObj = result; return true; }
                            return false;
                        }
                    },
                    {
                        typeof(short),
                        delegate (string s, out object outObj)
                        {
                            outObj = default(short);
                            if (short.TryParse(s, out short result)) { outObj = result; return true; }
                            return false;
                        }
                    },
                    {
                        typeof(int),
                        delegate (string s, out object outObj)
                        {
                            outObj = default(int);
                            if (int.TryParse(s, out int result)) { outObj = result; return true; }
                            return false;
                        }
                    },
                    {
                        typeof(long),
                        delegate (string s, out object outObj)
                        {
                            outObj = default(long);
                            if (long.TryParse(s, out long result)) { outObj = result; return true; }
                            return false;
                        }
                    },
                    {
                        typeof(float),
                        delegate (string s, out object outObj)
                        {
                            outObj = default(float);
                            if (float.TryParse(s, out float result)) { outObj = result; return true; }
                            return false;
                        }
                    },
                    {
                        typeof(double),
                        delegate (string s, out object outObj)
                        {
                            outObj = default(double);
                            if (double.TryParse(s, out double result)) { outObj = result; return true; }
                            return false;
                        }
                    },
                    {
                        typeof(decimal),
                        delegate (string s, out object outObj)
                        {
                            outObj = default(decimal);
                            if (decimal.TryParse(s, out decimal result)) { outObj = result; return true; }
                            return false;
                        }
                    },
                    {
                        typeof(ushort),
                        delegate (string s, out object outObj)
                        {
                            outObj = default(ushort);
                            if (ushort.TryParse(s, out ushort result)) { outObj = result; return true; }
                            return false;
                        }
                    },
                    {
                        typeof(uint),
                        delegate (string s, out object outObj)
                        {
                            outObj = default(uint);
                            if (uint.TryParse(s, out uint result)) { outObj = result; return true; }
                            return false;
                        }
                    },
                    {
                        typeof(ulong),
                        delegate (string s, out object outObj)
                        {
                            outObj = default(ulong);
                            if (ulong.TryParse(s, out ulong result)) { outObj = result; return true; }
                            return false;
                        }
                    },
                    {
                        typeof(bool),
                        delegate (string s, out object outObj)
                        {
                            outObj = default(bool);
                            if (bool.TryParse(s, out bool result)) { outObj = result; return true; }
                            return false;
                        }
                    },
                    {
                        typeof(char),
                        delegate (string s, out object outObj)
                        {
                            outObj = default(char);
                            if (char.TryParse(s, out char result)) { outObj = result; return true; }
                            return false;
                        }
                    },
                    {
                        typeof(DateTime),
                        delegate (string s, out object outObj)
                        {
                            outObj = default(DateTime);
                            if (DateTime.TryParse(s, out DateTime result)) { outObj = result; return true; }
                            return false;
                        }
                    },
                    {
                        typeof(sbyte?),
                        delegate (string s, out object outObj)
                        {
                            outObj = default(sbyte?);
                            if (sbyte.TryParse(s, out sbyte result)) { outObj = result; return true; }
                            return false;
                        }
                    },
                    {
                        typeof(byte?),
                        delegate (string s, out object outObj)
                        {
                            outObj = default(byte?);
                            if (byte.TryParse(s, out byte result)) { outObj = result; return true; }
                            return false;
                        }
                    },
                    {
                        typeof(short?),
                        delegate (string s, out object outObj)
                        {
                            outObj = default(short?);
                            if (short.TryParse(s, out short result)) { outObj = result; return true; }
                            return false;
                        }
                    },
                    {
                        typeof(int?),
                        delegate (string s, out object outObj)
                        {
                            outObj = default(int?);
                            if (int.TryParse(s, out int result)) { outObj = result; return true; }
                            return false;
                        }
                    },
                    {
                        typeof(long?),
                        delegate (string s, out object outObj)
                        {
                            outObj = default(long?);
                            if (long.TryParse(s, out long result)) { outObj = result; return true; }
                            return false;
                        }
                    },
                    {
                        typeof(float?),
                        delegate (string s, out object outObj)
                        {
                            outObj = default(float?);
                            if (float.TryParse(s, out float result)) { outObj = result; return true; }
                            return false;
                        }
                    },
                    {
                        typeof(double?),
                        delegate (string s, out object outObj)
                        {
                            outObj = default(double?);
                            if (double.TryParse(s, out double result)) { outObj = result; return true; }
                            return false;
                        }
                    },
                    {
                        typeof(decimal?),
                        delegate (string s, out object outObj)
                        {
                            outObj = default(decimal?);
                            if (decimal.TryParse(s, out decimal result)) { outObj = result; return true; }
                            return false;
                        }
                    },
                    {
                        typeof(ushort?),
                        delegate (string s, out object outObj)
                        {
                            outObj = default(ushort?);
                            if (ushort.TryParse(s, out ushort result)) { outObj = result; return true; }
                            return false;
                        }
                    },
                    {
                        typeof(uint?),
                        delegate (string s, out object outObj)
                        {
                            outObj = default(uint?);
                            if (uint.TryParse(s, out uint result)) { outObj = result; return true; }
                            return false;
                        }
                    },
                    {
                        typeof(ulong?),
                        delegate (string s, out object outObj)
                        {
                            outObj = default(ulong?);
                            if (ulong.TryParse(s, out ulong result)) { outObj = result; return true; }
                            return false;
                        }
                    },
                    {
                        typeof(bool?),
                        delegate (string s, out object outObj)
                        {
                            outObj = default(bool?);
                            if (bool.TryParse(s, out bool result)) { outObj = result; return true; }
                            return false;
                        }
                    },
                    {
                        typeof(char?),
                        delegate (string s, out object outObj)
                        {
                            outObj = default(char?);
                            if (char.TryParse(s, out char result)) { outObj = result; return true; }
                            return false;
                        }
                    },
                    {
                        typeof(DateTime?),
                        delegate (string s, out object outObj)
                        {
                            outObj = default(DateTime?);
                            if (DateTime.TryParse(s, out DateTime result)) { outObj = result; return true; }
                            return false;
                        }
                    },
                    {
                        typeof(string),
                        delegate (string s, out object outObj)
                        {
                            if (s.DaIsNone()) { outObj = default(string); return false; }
                            s = s.Trim();
                            outObj = s;
                            return true;
                        }
                    }
                });

        #endregion Private Fields

        #region Public Methods

        public static bool DaContains(this string fullText, string value)
            => fullText.DaIndexOf(value) > -1;

        public static string DaCut(this string value, int length) => value.DaSubstring(0, length);

        public static T DaDbIn<T>(this string text, T defaultValue = default(T))
        {
            if (text.DaIsNone()) { return defaultValue; }
            text = text.Trim();
            text.DaTryParse(out T result, defaultValue);
            return result;
        }

        public static bool DaEquals(this string text, string textToCompare)
            => text.Equals(textToCompare, StringComparison.InvariantCultureIgnoreCase);

        public static string DaFormat(this string format, params object[] args)
            => string.Format(CultureInfo.InvariantCulture, format, args);

        public static byte[] DaGetBytes(this string str)
        {
            byte[] bytes = new byte[str.Length * sizeof(char)];
            Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }

        public static bool DaHasAllEquals(this string text, params string[] textArgs)
        {
            for (int index = 0; index < textArgs.Length; index++)
            {
                if (text.DaEquals(textArgs[index]) == false) { return false; }
            }
            return true;
        }

        public static bool DaHasEquals(this string text, params string[] textArgs)
        {
            for (int index = 0; index < textArgs.Length; index++)
            {
                if (text.DaEquals(textArgs[index])) { return true; }
            }
            return false;
        }

        public static bool DaHasNoEquals(this string text, params string[] textArgs)
            => text.DaHasEquals(textArgs) == false;

        public static bool DaHasNotAllEquals(this string text, params string[] textArgs)
        {
            for (int index = 0; index < textArgs.Length; index++)
            {
                if (text.DaEquals(textArgs[index])) { return false; }
            }
            return true;
        }

        /// <summary>
        /// Reports the zero-based index of the first occurrence of the specified string
        /// in the current System.String object using StringComparison.InvariantCultureIgnoreCase.
        /// A parameter specifies the type of search to use for the specified string.
        /// </summary>
        /// <param name="fullText">
        /// The string to search inside.
        /// </param>
        /// <param name="value">
        /// The string to seek.
        /// </param>
        /// <returns>
        /// The index position of the value parameter if that string is found, or -1 if it
        /// is not. If value is System.String.Empty, the return value is 0.
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// fullText or value is null.
        /// </exception>
        public static int DaIndexOf(this string fullText, string value)
            => fullText.IndexOf(value, StringComparison.InvariantCultureIgnoreCase);

        /// <summary>
        /// Smaller Size name and usage from "string.IsNullOrWhiteSpace(text)" Indicates whether a
        /// specified string is null, empty, or consists only of white-space characters.
        /// </summary>
        /// <param name="text">The string to test</param>
        /// <returns>
        /// true if the value parameter is null or System.String.Empty, or if value consists
        /// exclusively of white-space characters.
        /// </returns>
        public static bool DaIsNone(this string text) => string.IsNullOrWhiteSpace(text);

        /// <summary>
        /// Smaller Size name and usage from "!string.IsNullOrWhiteSpace(text)" Indicates whether a
        /// specified string is not null, not empty, or not consists only of white-space characters.
        /// </summary>
        /// <param name="text">The string to test</param>
        /// <returns>
        /// true if the value parameter is not null or not System.String.Empty, or if value not consists
        /// exclusively of white-space characters.
        /// </returns>
        public static bool DaIsNotNone(this string text) => text.DaIsNone() == false;

        public static bool DaNotEquals(this string text, string textToCompare)
            => text.DaEquals(textToCompare) == false;

        public static T DaParse<T>(this string text)
        {
            Type type = typeof(T);
            if (_parseDictionary.ContainsKey(type)) { return (T)_parseDictionary[type](text); }
            throw new ArgumentException($"Parsing method to type ({type.Name}) does not exist");
        }

        public static string DaSubstring(this string value, int startIndex, int length)
        {
            if (value.DaIsNone()) { return null; }
            if (value.Length <= length) { return value; }
            return value.Substring(startIndex, length);
        }

        public static bool DaTryParse<T>(this string text, out T result, T defaultValue = default(T))
        {
            Type type = typeof(T);
            if (_tryParseList.ContainsKey(type) == false)
            {
                try { result = text.DaConvert(defaultValue); return true; }
                catch (Exception) { result = defaultValue; return false; }
            }

            if (_tryParseList[type](text, out object objValue)) { result = (T)objValue; return true; }
            result = defaultValue;
            return false;
        }

        #endregion Public Methods
    }
}