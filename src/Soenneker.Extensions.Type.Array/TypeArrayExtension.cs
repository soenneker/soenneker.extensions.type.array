using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using Soenneker.Extensions.Spans.Readonly.Types;

namespace Soenneker.Extensions.Type.Array;

/// <summary>
/// A collection of helpful Type array extension methods
/// </summary>
public static class TypeArrayExtension
{
    /// <summary>
    /// Computes a hash code that uniquely represents the sequence and identity of the specified array of types.
    /// </summary>
    /// <remarks>The hash code is based on the reference identity of each type in the array, not their
    /// structural equality. This method is useful for scenarios where the uniqueness of a type sequence is required,
    /// such as caching or dictionary keys.</remarks>
    /// <param name="types">An array of <see cref="System.Type"/> objects to include in the hash calculation. Can be <see langword="null"/>
    /// or empty.</param>
    /// <returns>An integer hash code representing the input type array. Returns 0 if <paramref name="types"/> is <see
    /// langword="null"/> or empty.</returns>
    [Pure]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int ToHashKey(this System.Type[]? types)
    {
        if (types is null)
            return 0;

        return ((System.ReadOnlySpan<System.Type>)types).ToHashKey();
    }
}