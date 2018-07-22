using System;
using System.Collections.Generic;
using System.Text;

namespace Maki.Extensions
{
    /// <summary>
    /// Extensions for Error.
    /// </summary>
    public static class ErrorExtensions
    {
        /// <summary>
        /// Binds the given function to the Error.
        /// </summary>
        /// <typeparam name="T">Error type.</typeparam>
        /// <typeparam name="U">Function return Error type.</typeparam>
        /// <param name="error">This instance.</param>
        /// <param name="func">Function to bind.</param>
        /// <returns>Error containing the result of the function or an exception.</returns>
        public static Error<U> Bind<T, U>(this Error<T> error, Func<T, Error<U>> func)
        {
            if (!error.HasValue) return error.Exception();

            try
            {
                return func(error.Get());
            }
            catch (Exception e)
            {
                return e;
            }
        }

        /// <summary>
        /// Maps the given function to the Error.
        /// </summary>
        /// <typeparam name="T">Error type.</typeparam>
        /// <typeparam name="U">Function return type</typeparam>
        /// <param name="error">This instance.</param>
        /// <param name="func">Function to map.</param>
        /// <returns>Error containing the result of the function or an exception.</returns>
        public static Error<U> Map<T, U>(this Error<T> error, Func<T, U> func)
        {
            if (!error.HasValue) return error.Exception();

            return Error.Make(() => func(error.Get()));
        }
    }
}
