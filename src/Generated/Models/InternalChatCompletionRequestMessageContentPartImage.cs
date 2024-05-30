// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Chat
{
    internal partial class InternalChatCompletionRequestMessageContentPartImage
    {
        internal IDictionary<string, BinaryData> _serializedAdditionalRawData;

        public InternalChatCompletionRequestMessageContentPartImage(InternalChatCompletionRequestMessageContentPartImageImageUrl imageUrl)
        {
            Argument.AssertNotNull(imageUrl, nameof(imageUrl));

            ImageUrl = imageUrl;
        }

        internal InternalChatCompletionRequestMessageContentPartImage(InternalChatCompletionRequestMessageContentPartImageType type, InternalChatCompletionRequestMessageContentPartImageImageUrl imageUrl, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Type = type;
            ImageUrl = imageUrl;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        internal InternalChatCompletionRequestMessageContentPartImage()
        {
        }

        public InternalChatCompletionRequestMessageContentPartImageType Type { get; } = InternalChatCompletionRequestMessageContentPartImageType.ImageUrl;

        public InternalChatCompletionRequestMessageContentPartImageImageUrl ImageUrl { get; }
    }
}
