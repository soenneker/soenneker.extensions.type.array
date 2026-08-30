[![](https://img.shields.io/nuget/v/soenneker.extensions.type.array.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.extensions.type.array/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.extensions.type.array/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.extensions.type.array/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.extensions.type.array.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.extensions.type.array/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.extensions.type.array/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.extensions.type.array/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Extensions.Type.Array
Compute an order-sensitive, process-local hash for a `Type[]` signature.

## Installation

```bash
dotnet add package Soenneker.Extensions.Type.Array
```

## Usage

```csharp
using Soenneker.Extensions.Type.Array;

Type[] signature = [typeof(string), typeof(int), typeof(CancellationToken)];
int hash = signature.ToHashKey();
```

The same runtime `Type` objects in the same order produce the same hash within a process. A null or empty array returns `0`; changing the order generally changes the result.

The hash uses runtime object identity. It is not stable across processes or application runs, is not cryptographic, and is not guaranteed unique. Do not persist it as a type identifier or use it as the sole equality check for a cache key; retain and compare the original type sequence when collisions matter.
