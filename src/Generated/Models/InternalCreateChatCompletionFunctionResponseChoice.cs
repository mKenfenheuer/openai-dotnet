// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Chat
{
    internal partial class InternalCreateChatCompletionFunctionResponseChoice
    {
        internal IDictionary<string, BinaryData> _serializedAdditionalRawData;

        internal InternalCreateChatCompletionFunctionResponseChoice(string finishReason, int index, InternalChatCompletionResponseMessage message)
        {
            Argument.AssertNotNull(finishReason, nameof(finishReason));
            Argument.AssertNotNull(message, nameof(message));

            FinishReason = finishReason;
            Index = index;
            Message = message;
        }

        internal InternalCreateChatCompletionFunctionResponseChoice(string finishReason, int index, InternalChatCompletionResponseMessage message, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            FinishReason = finishReason;
            Index = index;
            Message = message;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        internal InternalCreateChatCompletionFunctionResponseChoice()
        {
        }

        public string FinishReason { get; }
        public int Index { get; }
        public InternalChatCompletionResponseMessage Message { get; }
    }
}
