// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace OpenAI.Files
{
    internal readonly partial struct InternalListFilesResponseObject : IEquatable<InternalListFilesResponseObject>
    {
        private readonly string _value;

        public InternalListFilesResponseObject(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ListValue = "list";

        public static InternalListFilesResponseObject List { get; } = new InternalListFilesResponseObject(ListValue);
        public static bool operator ==(InternalListFilesResponseObject left, InternalListFilesResponseObject right) => left.Equals(right);
        public static bool operator !=(InternalListFilesResponseObject left, InternalListFilesResponseObject right) => !left.Equals(right);
        public static implicit operator InternalListFilesResponseObject(string value) => new InternalListFilesResponseObject(value);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InternalListFilesResponseObject other && Equals(other);
        public bool Equals(InternalListFilesResponseObject other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        public override string ToString() => _value;
    }
}
