using System.Text.Json.Serialization;
using Soenneker.Attributes.PublicOpenApiObject;
using Soenneker.Attributes.Validation.Guid.Nullable;

namespace Soenneker.Requests.Entity;

/// <summary>
/// Provides the optional resource identifier shared by create-or-update API request models.
/// </summary>
[PublicOpenApiObject]
public record EntityRequest
{
    /// <summary>
    /// Stable unique identifier of an existing resource to update; omit it when the API assigns an identifier during creation.
    /// </summary>
    [JsonPropertyName("id")]
    [NullableGuidValidation]
    public string? Id { get; set; }
}
