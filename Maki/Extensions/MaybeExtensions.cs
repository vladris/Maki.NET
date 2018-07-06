using System;

namespace Maki
{
    /// <summary>
    /// Extensions for Maybe
    /// </summary>
    public static class MaybeExtensions
    {
        /// <summary>
        /// Binds the given function to the Maybe.
        /// </summary>
        /// <typeparam name="T">Maybe optional type.</typeparam>
        /// <typeparam name="U">Function return Maybe type.</typeparam>
        /// <param name="maybe">This instance.</param>
        /// <param name="func">Function to bind.</param>
        /// <returns>Maybe containing the result of the function or Nothing.</returns>
        public static Maybe<U> Bind<T, U>(this Maybe<T> maybe, Func<T, Maybe<U>> func)
            => maybe.HasValue ? func(maybe.Get()) : Maybe.Nothing;

        /// <summary>
        /// Mapsthe given function to the Maybe.
        /// </summary>
        /// <typeparam name="T">Maybe optional type.</typeparam>
        /// <typeparam name="U">Function return type</typeparam>
        /// <param name="maybe">This instance.</param>
        /// <param name="func">Function to map.</param>
        /// <returns>Maybe containing the result of the functino or Nothing.</returns>
        public static Maybe<U> Map<T, U>(this Maybe<T> maybe, Func<T, U> func)
            => maybe.HasValue ? Maybe.Just(func(maybe.Get())) : Maybe.Nothing;
    }
}
