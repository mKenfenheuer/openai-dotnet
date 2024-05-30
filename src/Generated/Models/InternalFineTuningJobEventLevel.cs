// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace OpenAI.FineTuning
{
    internal readonly partial struct InternalFineTuningJobEventLevel : IEquatable<InternalFineTuningJobEventLevel>
    {
        private readonly string _value;

        public InternalFineTuningJobEventLevel(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InfoValue = "info";
        private const string WarnValue = "warn";
        private const string ErrorValue = "error";

        public static InternalFineTuningJobEventLevel Info { get; } = new InternalFineTuningJobEventLevel(InfoValue);
        public static InternalFineTuningJobEventLevel Warn { get; } = new InternalFineTuningJobEventLevel(WarnValue);
        public static InternalFineTuningJobEventLevel Error { get; } = new InternalFineTuningJobEventLevel(ErrorValue);
        public static bool operator ==(InternalFineTuningJobEventLevel left, InternalFineTuningJobEventLevel right) => left.Equals(right);
        public static bool operator !=(InternalFineTuningJobEventLevel left, InternalFineTuningJobEventLevel right) => !left.Equals(right);
        public static implicit operator InternalFineTuningJobEventLevel(string value) => new InternalFineTuningJobEventLevel(value);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InternalFineTuningJobEventLevel other && Equals(other);
        public bool Equals(InternalFineTuningJobEventLevel other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        public override string ToString() => _value;
    }
}
