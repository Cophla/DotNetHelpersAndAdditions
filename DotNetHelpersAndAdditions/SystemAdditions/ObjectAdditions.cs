using System;
using System.Collections.Generic;
using System.Globalization;
using ConvertDictionary =
    System.Collections.Concurrent.ConcurrentDictionary<System.Type, System.Func<object, object>>;

namespace DotNetHelpersAndAdditions.SystemAdditions
{
    public static class ObjectAdditions
    {
        #region Private Fields

        private static readonly ConvertDictionary _convertDictionary = new ConvertDictionary(
            new Dictionary<Type, Func<object, object>>() {
                {typeof(sbyte), (x) => Convert.ToSByte(x, CultureInfo.InvariantCulture)},
                {typeof(byte), (x) => Convert.ToByte(x, CultureInfo.InvariantCulture) },
                {typeof(short), (x) => Convert.ToInt16(x, CultureInfo.InvariantCulture) },
                {typeof(int), (x) => Convert.ToInt32(x, CultureInfo.InvariantCulture) },
                {typeof(long), (x) => Convert.ToInt64(x, CultureInfo.InvariantCulture) },
                {typeof(float), (x) => Convert.ToSingle(x, CultureInfo.InvariantCulture) },
                {typeof(double), (x) => Convert.ToDouble(x, CultureInfo.InvariantCulture) },
                {typeof(decimal), (x) => Convert.ToDecimal(x, CultureInfo.InvariantCulture) },
                {typeof(ushort), (x) => Convert.ToUInt16(x, CultureInfo.InvariantCulture) },
                {typeof(uint), (x) => Convert.ToUInt32(x, CultureInfo.InvariantCulture) },
                {typeof(ulong), (x) => Convert.ToUInt64(x, CultureInfo.InvariantCulture) },
                {typeof(string), (x) => Convert.ToString(x, CultureInfo.InvariantCulture) },
                {typeof(bool), (x) => Convert.ToBoolean(x, CultureInfo.InvariantCulture) },
                {typeof(char), (x) => Convert.ToChar(x, CultureInfo.InvariantCulture) },
                {typeof(DateTime), (x) => Convert.ToDateTime(x, CultureInfo.InvariantCulture) },
                {typeof(sbyte?), (x) => _toNullable<sbyte?>(x) },
                {typeof(byte?), (x) => _toNullable<byte?>(x) },
                {typeof(short?), (x) => _toNullable<short?>(x) },
                {typeof(int?), (x) => _toNullable<int?>(x) },
                {typeof(long?), (x) => _toNullable<long?>(x) },
                {typeof(float?), (x) => _toNullable<float?>(x) },
                {typeof(double?), (x) => _toNullable<double?>(x) },
                {typeof(decimal?), (x) => _toNullable<decimal?>(x) },
                {typeof(ushort?), (x) => _toNullable<ushort?>(x) },
                {typeof(uint?), (x) => _toNullable<uint?>(x) },
                {typeof(ulong?), (x) => _toNullable<ulong?>(x) },
                { typeof(bool?), (x) => _toNullable<bool?>(x)},
                {typeof(char?), (x) => _toNullable<char?>(x) },
                {typeof(DateTime?), (x) => _toNullable<DateTime?>(x) }
            }
        );

        #endregion Private Fields

        #region Public Methods

        public static object DaChangeType(this object objV, Type type)
            => Convert.ChangeType(objV, type, CultureInfo.InvariantCulture);

        public static T DaConvert<T>(this object objV, T defaultValue = default(T))
        {
            if (objV.DaIsNone()) { return defaultValue; }
            Type type = typeof(T);
            if (_convertDictionary.ContainsKey(type)) { return (T)_convertDictionary[type](objV); }
            IConvertible testConvertible;
            if ((testConvertible = objV as IConvertible) == null)
            {
                if (objV.GetType().IsInstanceOfType(type)) { return (T)objV; }
                return defaultValue;
            }
            return _toNullable(objV, () => (T)objV.DaChangeType(type));
        }

        public static T DaDbOut<T>(this object objV, T defaultValue = default(T))
        {
            if (objV.DaIsNone()) { return defaultValue; }
            if (objV is string testText)
            {
                if (testText.DaIsNone()) { return defaultValue; }
                testText.DaTryParse(out T result, defaultValue);
                return result;
            }
            return objV.DaConvert<T>();
        }

        /// <summary>
        /// Provides equality check for generic objects with case insensitive equality for strings
        /// </summary>
        /// <typeparam name="T">Generic Type</typeparam>
        /// <param name="obj"></param>
        /// <param name="objToCompare"></param>
        /// <returns></returns>
        public static bool DaEquals<T>(this T obj, T objToCompare)
        {
            if (((object)obj) is string text) { return text.DaEquals(objToCompare as string); }

            return obj.Equals(objToCompare);
        }

        public static bool DaHasAllEquals<T>(this T obj, params T[] objArgs)
        {
            for (int index = 0; index < objArgs.Length; index++)
            {
                if (obj.DaEquals(objArgs[index]) == false) { return false; }
            }
            return true;
        }

        public static bool DaHasEquals<T>(this T objV, params T[] objArgs)
        {
            for (int index = 0; index < objArgs.Length; index++)
            {
                if (objV.DaEquals(objArgs[index])) { return true; }
            }
            return false;
        }

        public static bool DaHasNoEquals<T>(this T objV, params T[] objArgs)
            => objV.DaHasEquals(objArgs) == false;

        public static bool DaHasNotAllEquals<T>(this T objV, params T[] objArgs)
        {
            for (int index = 0; index < objArgs.Length; index++)
            {
                if (objV.DaEquals(objArgs[index])) { return false; }
            }
            return true;
        }

        public static bool DaIsNone(this object obj)
        {
            if (obj is string text) { return text.DaIsNone(); }

            if (obj == null) { return true; }

            if (Convert.IsDBNull(obj)) { return true; }

            return false;
        }

        public static bool DaNotEquals<T>(this T obj, T objToCompare)
            => obj.DaEquals(objToCompare) == false;

        #endregion Public Methods

        #region Private Methods

        private static T _toNullable<T>(object value, T defaultValue = default(T))
            => _toNullable(value, () => default(T));

        private static T _toNullable<T>(object value, Func<T> defaultFunc)
        {
            Type nullableType = Nullable.GetUnderlyingType(typeof(T));
            if (nullableType == null) { return defaultFunc(); }
            return (T)value.DaChangeType(nullableType);
        }

        #endregion Private Methods
    }
}