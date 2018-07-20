using System;

namespace Maki
{
    /// <summary>
    /// Extensions for Optional
    /// </summary>
    public static class OptionalExtensions
    {
        /// <summary>
        /// Binds the given function to the Optional.
        /// </summary>
        /// <typeparam name="T">Optional type.</typeparam>
        /// <typeparam name="U">Function return Optional type.</typeparam>
        /// <param name="optional">This instance.</param>
        /// <param name="func">Function to bind.</param>
        /// <returns>Optional containing the result of the function or Nothing.</returns>
        public static Optional<U> Bind<T, U>(this Optional<T> optional, Func<T, Optional<U>> func)
            => optional.HasValue ? func(optional.Get()) : Optional.Nothing;

        /// <summary>
        /// Maps the given function to the Optional.
        /// </summary>
        /// <typeparam name="T">Optional optional type.</typeparam>
        /// <typeparam name="U">Function return type</typeparam>
        /// <param name="optional">This instance.</param>
        /// <param name="func">Function to map.</param>
        /// <returns>Optional containing the result of the function or Nothing.</returns>
        public static Optional<U> Map<T, U>(this Optional<T> optional, Func<T, U> func)
            => optional.HasValue ? Optional.Just(func(optional.Get())) : Optional.Nothing;
    }
}
