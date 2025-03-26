using System.Text.Json.Serialization;
using Soenneker.Attributes.Validation.Guid.Nullable;

namespace Soenneker.Requests.Entity;

/// <summary>
/// A record request type for Entity objects
/// </summary>
public record EntityRequest
{
    [JsonPropertyName("id")]
    [NullableGuidValidation]
    public string? Id { get; set; }
}