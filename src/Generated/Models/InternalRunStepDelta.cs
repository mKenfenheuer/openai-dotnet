// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Assistants
{
    internal partial class InternalRunStepDelta
    {
        internal IDictionary<string, BinaryData> _serializedAdditionalRawData;

        internal InternalRunStepDelta(string id, InternalRunStepDeltaObjectDelta delta)
        {
            Argument.AssertNotNull(id, nameof(id));
            Argument.AssertNotNull(delta, nameof(delta));

            Id = id;
            Delta = delta;
        }

        internal InternalRunStepDelta(string id, object @object, InternalRunStepDeltaObjectDelta delta, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            Object = @object;
            Delta = delta;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        internal InternalRunStepDelta()
        {
        }

        public string Id { get; }

        public InternalRunStepDeltaObjectDelta Delta { get; }
    }
}
