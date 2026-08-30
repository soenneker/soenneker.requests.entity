[![](https://img.shields.io/nuget/v/soenneker.requests.entity.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.requests.entity/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.requests.entity/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.requests.entity/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.requests.entity.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.requests.entity/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.requests.entity/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.requests.entity/actions/workflows/codeql.yml)

# Soenneker.Requests.Entity

A reusable request record for APIs where the same payload represents either a new or existing entity.

## Installation

```bash
dotnet add package Soenneker.Requests.Entity
```

## Usage

Derive an application request from `EntityRequest` to add an optional JSON `id` property:

```csharp
using System.ComponentModel.DataAnnotations;
using Soenneker.Requests.Entity;

public record SaveWidgetRequest : EntityRequest
{
    [Required]
    public string Name { get; init; } = null!;
}
```

Omit `Id` when creating an entity:

```csharp
var create = new SaveWidgetRequest
{
    Name = "Primary widget"
};
```

Supply the existing identifier when updating one:

```csharp
var update = new SaveWidgetRequest
{
    Id = "75f11404-9c6f-4b33-b16c-d3ffea59f8f4",
    Name = "Renamed widget"
};
```

`Id` is a nullable string so it maps cleanly to request JSON. It carries `NullableGuidValidation`, which accepts an omitted value but requires a valid GUID when a value is present. Run your normal ASP.NET Core or data-annotation validation pipeline before using the request; JSON deserialization by itself does not execute validation attributes.
