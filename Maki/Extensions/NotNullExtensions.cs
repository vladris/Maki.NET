using System;

namespace Maki
{
    /// <summary>
    /// Extensions for NotNull
    /// </summary>
    public static class NotNullExtensions
    {
        /// <summary>
        /// Binds the given function to the NotNull.
        /// </summary>
        /// <typeparam name="T">NotNull type.</typeparam>
        /// <typeparam name="U">Function return NotNull type.</typeparam>
        /// <param name="notNull">This instance.</param>
        /// <param name="func">Function to bind.</param>
        /// <returns>NotNull containing the result of the function.</returns>
        public static NotNull<U> Bind<T, U>(this NotNull<T> notNull, Func<T, NotNull<U>> func)
            => func(notNull);

        /// <summary>
        /// Mapsthe given function to the NotNull.
        /// </summary>
        /// <typeparam name="T">NotNull type.</typeparam>
        /// <typeparam name="U">Function return type</typeparam>
        /// <param name="notNull">This instance.</param>
        /// <param name="func">Function to map.</param>
        /// <returns>NotNull containing the result of the function.</returns>
        /// <exception cref="ArgumentNullException">Thrown if the function returns null.</exception>
        public static NotNull<U> Map<T, U>(this NotNull<T> notNull, Func<T, U> func)
            => NotNull.Make(func(notNull));
    }
}
