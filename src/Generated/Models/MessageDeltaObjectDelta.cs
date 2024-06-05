// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Assistants
{
    internal partial class MessageDeltaObjectDelta
    {
        internal IDictionary<string, BinaryData> _serializedAdditionalRawData;

        internal MessageDeltaObjectDelta()
        {
            Content = new ChangeTrackingList<MessageDeltaContent>();
        }

        internal MessageDeltaObjectDelta(MessageRole role, IReadOnlyList<MessageDeltaContent> content, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Role = role;
            Content = content;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }
        public IReadOnlyList<MessageDeltaContent> Content { get; }
    }
}