[![](https://img.shields.io/nuget/v/soenneker.extensions.type.array.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.extensions.type.array/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.extensions.type.array/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.extensions.type.array/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.extensions.type.array.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.extensions.type.array/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.extensions.type.array/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.extensions.type.array/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Extensions.Type.Array
A collection of helpful Type array extension methods.

## Installation

```bash
dotnet add package Soenneker.Extensions.Type.Array
```

## Quick start

```csharp
using Soenneker.Extensions.Type.Array;

// Given an existing System.Type[]? named types:
var result = types.ToHashKey();
```

## Common operations

- `ToHashKey()` - Computes a hash code that uniquely represents the sequence and identity of the specified array of types. Returns an integer hash code representing the input type array. Returns 0 if `types` is `null` or empty.
