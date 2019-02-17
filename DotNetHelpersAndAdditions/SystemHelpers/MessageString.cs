using System;
using System.Globalization;
using System.Text;

namespace DotNetHelpersAndAdditions.SystemHelpers
{
    public class MessageString : IDisposable
    {
        #region Protected Fields

        protected StringBuilder _messageBuilder = new StringBuilder();

        #endregion Protected Fields

        #region Private Fields

        private bool _disposedValue = false;

        #endregion Private Fields

        #region Public Constructors

        public MessageString()
        {
        }

        public MessageString(int capacity)
        {
            _messageBuilder.Capacity = capacity;
        }

        public MessageString(string value)
        {
            _messageBuilder.Append(value);
        }

        #endregion Public Constructors

        #region Public Properties

        public int Length {
            get { return _messageBuilder.Length; }
            set { _messageBuilder.Length = value; }
        }

        public int MaxCapacity => _messageBuilder.MaxCapacity;

        #endregion Public Properties

        #region Public Methods

        public static MessageString Add(MessageString left, MessageString right)
        {
            MessageString ms = new MessageString(left.Length + right.Length);
            ms.Append(left.ToString());
            ms.Append(right.ToString());
            return ms;
        }

        public static implicit operator string(MessageString ms) => ms.ToString();

        public static MessageString operator +(MessageString ms1, MessageString ms2)
        {
            return Add(ms1, ms2);
        }

        public MessageString Append<T>(T value) where T : IConvertible
        {
            _messageBuilder.Append(value);
            return this;
        }

        public MessageString Append(string value) => Append<string>(value);

        public MessageString Append(MessageString ms) => Append(ms.ToString());

        public MessageString AppendFormat(string format, params object[] args)
        {
            _messageBuilder.AppendFormat(CultureInfo.InvariantCulture, format, args);
            return this;
        }

        public MessageString AppendLine()
        {
            _messageBuilder.AppendLine();
            return this;
        }

        public MessageString AppendLine(string value)
        {
            _messageBuilder.AppendLine(value);
            return this;
        }

        public MessageString AppendLine(MessageString ms)
        {
            _messageBuilder.AppendLine(ms.ToString());
            return this;
        }

        public MessageString AppendLine<T>(T value) where T : IConvertible
        {
            Append(value);
            AppendLine();
            return this;
        }

        public MessageString Clear()
        {
            _messageBuilder.Clear();
            return this;
        }

        public void Dispose()
        {
            _dispose(true);
        }

        public int EnsureCapacity(int capacity) => _messageBuilder.EnsureCapacity(capacity);

        public bool Equals(MessageString ms) => Equals(ms.ToString());

        public bool Equals(StringBuilder sb) => _messageBuilder.Equals(sb);

        public bool Equals(string value) => Equals(new StringBuilder(value));

        public MessageString Insert<T>(int index, T value)
        {
            _messageBuilder.Insert(index, value);
            return this;
        }

        public MessageString Remove(int startIndex, int length)
        {
            _messageBuilder.Remove(startIndex, length);
            return this;
        }

        public MessageString Replace(char oldChar, char newChar)
        {
            _messageBuilder.Replace(oldChar, newChar);
            return this;
        }

        public MessageString Replace(string oldValue, string newValue)
        {
            _messageBuilder.Replace(oldValue, newValue);
            return this;
        }

        public MessageString Replace(char oldChar, char newChar, int startIndex, int count)
        {
            _messageBuilder.Replace(oldChar, newChar, startIndex, count);
            return this;
        }

        public MessageString Replace(
            string oldValue, string newValue, int startIndex, int count)
        {
            _messageBuilder.Replace(oldValue, newValue, startIndex, count);
            return this;
        }

        public override string ToString() => _messageBuilder.ToString();

        public string ToString(int startIndex, int length)
            => _messageBuilder.ToString(startIndex, length);

        #endregion Public Methods

        #region Protected Methods

        protected void _Dispose()
        {
            _messageBuilder.Clear();
            _messageBuilder = null;
        }

        #endregion Protected Methods

        #region Private Methods

        private void _dispose(bool diposing)
        {
            if (_disposedValue) { return; }
            if (diposing) { _Dispose(); }
            _disposedValue = true;
        }

        #endregion Private Methods
    }
}