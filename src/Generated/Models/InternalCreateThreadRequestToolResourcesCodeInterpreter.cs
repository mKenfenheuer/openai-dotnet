// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Assistants
{
    internal partial class InternalCreateThreadRequestToolResourcesCodeInterpreter
    {
        internal IDictionary<string, BinaryData> _serializedAdditionalRawData;

        public InternalCreateThreadRequestToolResourcesCodeInterpreter()
        {
            FileIds = new ChangeTrackingList<string>();
        }

        internal InternalCreateThreadRequestToolResourcesCodeInterpreter(IList<string> fileIds, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            FileIds = fileIds;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        public IList<string> FileIds { get; }
    }
}
