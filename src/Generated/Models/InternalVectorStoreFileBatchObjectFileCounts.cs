// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.VectorStores
{
    internal partial class InternalVectorStoreFileBatchObjectFileCounts
    {
        internal IDictionary<string, BinaryData> _serializedAdditionalRawData;

        internal InternalVectorStoreFileBatchObjectFileCounts(int inProgress, int completed, int failed, int cancelled, int total)
        {
            InProgress = inProgress;
            Completed = completed;
            Failed = failed;
            Cancelled = cancelled;
            Total = total;
        }

        internal InternalVectorStoreFileBatchObjectFileCounts(int inProgress, int completed, int failed, int cancelled, int total, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            InProgress = inProgress;
            Completed = completed;
            Failed = failed;
            Cancelled = cancelled;
            Total = total;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        internal InternalVectorStoreFileBatchObjectFileCounts()
        {
        }

        public int InProgress { get; }
        public int Completed { get; }
        public int Failed { get; }
        public int Cancelled { get; }
        public int Total { get; }
    }
}
