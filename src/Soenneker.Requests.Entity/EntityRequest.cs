using System.Text.Json.Serialization;
using Soenneker.Attributes.PublicOpenApiObject;
using Soenneker.Attributes.Validation.Guid.Nullable;

namespace Soenneker.Requests.Entity;

/// <summary>
/// A record request type for Entity objects
/// </summary>
[PublicOpenApiObject]
public record EntityRequest
{
    /// <summary>
    /// The unique identifier for the entity, when updating an existing entity.
    /// </summary>
    [JsonPropertyName("id")]
    [NullableGuidValidation]
    public string? Id { get; set; }
}
