using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace OpenAI.Embeddings;

[CodeGenModel("CreateEmbeddingResponse")]
[CodeGenSuppress("Data")]
[CodeGenSuppress(nameof(EmbeddingCollection))]
[CodeGenSuppress(nameof(EmbeddingCollection), typeof(IReadOnlyList<Embedding>), typeof(string), typeof(InternalCreateEmbeddingResponseObject), typeof(EmbeddingTokenUsage))]
public partial class EmbeddingCollection : ReadOnlyCollection<Embedding>
{
    // CUSTOM: Made private. This property does not add value in the context of a strongly-typed class.
    /// <summary> The object type, which is always "list". </summary>
    [CodeGenMember("Object")]
    private InternalCreateEmbeddingResponseObject Object { get; } = InternalCreateEmbeddingResponseObject.List;

    // CUSTOM: Recovered this field. See https://github.com/Azure/autorest.csharp/issues/4636.
    /// <summary>
    /// Keeps track of any properties unknown to the library.
    /// <para>
    /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
    /// </para>
    /// <para>
    /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
    /// </para>
    /// <para>
    /// Examples:
    /// <list type="bullet">
    /// <item>
    /// <term>BinaryData.FromObjectAsJson("foo")</term>
    /// <description>Creates a payload of "foo".</description>
    /// </item>
    /// <item>
    /// <term>BinaryData.FromString("\"foo\"")</term>
    /// <description>Creates a payload of "foo".</description>
    /// </item>
    /// <item>
    /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
    /// <description>Creates a payload of { "key": "value" }.</description>
    /// </item>
    /// <item>
    /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
    /// <description>Creates a payload of { "key": "value" }.</description>
    /// </item>
    /// </list>
    /// </para>
    /// </summary>
    private IDictionary<string, BinaryData> _serializedAdditionalRawData;

    // CUSTOM: Set the inherited Items property via the base constructor in favor of the suppressed Data property.
    /// <summary> Initializes a new instance of <see cref="EmbeddingCollection"/>. </summary>
    /// <param name="data"> The list of embeddings generated by the model. </param>
    /// <param name="model"> The name of the model used to generate the embedding. </param>
    /// <param name="usage"> The usage information for the request. </param>
    /// <exception cref="ArgumentNullException"> <paramref name="data"/>, <paramref name="model"/> or <paramref name="usage"/> is null. </exception>
    internal EmbeddingCollection(IEnumerable<Embedding> data, string model, EmbeddingTokenUsage usage)
        : base([.. data])
    {
        Argument.AssertNotNull(data, nameof(data));
        Argument.AssertNotNull(model, nameof(model));
        Argument.AssertNotNull(usage, nameof(usage));

        Model = model;
        Usage = usage;
    }

    // CUSTOM: Set the inherited Items property via the base constructor in favor of the suppressed Data property.
    /// <summary> Initializes a new instance of <see cref="EmbeddingCollection"/>. </summary>
    /// <param name="data"> The list of embeddings generated by the model. </param>
    /// <param name="model"> The name of the model used to generate the embedding. </param>
    /// <param name="object"> The object type, which is always "list". </param>
    /// <param name="usage"> The usage information for the request. </param>
    /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
    internal EmbeddingCollection(IReadOnlyList<Embedding> data, string model, InternalCreateEmbeddingResponseObject @object, EmbeddingTokenUsage usage, IDictionary<string, BinaryData> serializedAdditionalRawData)
        : base([.. data])
    {
        Model = model;
        Object = @object;
        Usage = usage;
        _serializedAdditionalRawData = serializedAdditionalRawData;
    }

    // CUSTOM: Set the inherited Items property via the base constructor in favor of the suppressed Data property.
    /// <summary> Initializes a new instance of <see cref="EmbeddingCollection"/> for deserialization. </summary>
    internal EmbeddingCollection()
        : base([])
    {
    }
}