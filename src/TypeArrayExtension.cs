using System;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;

namespace Soenneker.Extensions.Type.Array;

/// <summary>
/// A collection of helpful Type array extension methods
/// </summary>
public static class TypeArrayExtension
{
    /// <summary>
    /// Generates a key as an integer based on the provided array of <see cref="System.Type"/>.
    /// </summary>
    /// <param name="types">An array of <see cref="System.Type"/>. Can be null or empty.</param>
    /// <returns>
    /// An integer representing the hash code of the provided types.
    /// Returns 0 if the array is null or empty.
    /// </returns>
    [Pure]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int ToHashKey(this System.Type[]? types)
    {
        if (types is null)
            return 0;

        int length = types.Length;

        if (length == 0)
            return 0;

        var hash = new HashCode();

        for (var i = 0; i < length; i++)
        {
            System.Type type = types[i];
            hash.Add(type);
        }

        return hash.ToHashCode();
    }
}