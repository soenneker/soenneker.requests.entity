[![](https://img.shields.io/nuget/v/soenneker.requests.entity.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.requests.entity/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.requests.entity/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.requests.entity/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.requests.entity.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.requests.entity/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.requests.entity/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.requests.entity/actions/workflows/codeql.yml)

# Soenneker.Requests.Entity

Provides the optional resource identifier shared by create-or-update API request models.

## Install

```bash
dotnet add package Soenneker.Requests.Entity
```

## What you get

- `EntityRequest` — Provides the optional resource identifier shared by create-or-update API request models.

## API at a glance

| API | What it does | Result / important behavior |
| --- | --- | --- |
| `EntityRequest.Id` | Stable unique identifier of an existing resource to update; omit it when the API assigns an identifier during creation. | Stable unique identifier of an existing resource to update; omit it when the API assigns an identifier during creation. |
