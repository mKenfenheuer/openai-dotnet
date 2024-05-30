// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace OpenAI.Assistants
{
    internal readonly partial struct InternalRunObjectObject : IEquatable<InternalRunObjectObject>
    {
        private readonly string _value;

        public InternalRunObjectObject(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ThreadRunValue = "thread.run";

        public static InternalRunObjectObject ThreadRun { get; } = new InternalRunObjectObject(ThreadRunValue);
        public static bool operator ==(InternalRunObjectObject left, InternalRunObjectObject right) => left.Equals(right);
        public static bool operator !=(InternalRunObjectObject left, InternalRunObjectObject right) => !left.Equals(right);
        public static implicit operator InternalRunObjectObject(string value) => new InternalRunObjectObject(value);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InternalRunObjectObject other && Equals(other);
        public bool Equals(InternalRunObjectObject other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        public override string ToString() => _value;
    }
}
