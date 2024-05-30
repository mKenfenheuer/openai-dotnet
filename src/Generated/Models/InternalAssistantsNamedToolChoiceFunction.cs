// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Assistants
{
    internal partial class InternalAssistantsNamedToolChoiceFunction
    {
        internal IDictionary<string, BinaryData> _serializedAdditionalRawData;

        public InternalAssistantsNamedToolChoiceFunction(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
        }

        internal InternalAssistantsNamedToolChoiceFunction(string name, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        internal InternalAssistantsNamedToolChoiceFunction()
        {
        }

        public string Name { get; set; }
    }
}
