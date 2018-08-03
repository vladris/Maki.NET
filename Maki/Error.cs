using System;

namespace Maki
{    
     /// <summary>
     /// Provides static utilities for Error.
     /// </summary>
    public static class Error
    {
        /// <summary>
        /// Creates a new Error containing an exception.
        /// </summary>
        /// <typeparam name="T">Error type.</typeparam>
        /// <param name="e">Exception to hold in the new Error.</param>
        /// <returns>Error containing the given exception.</returns>
        public static Error<T> MakeException<T>(Exception e)
            => Error<T>.MakeException(e);

        /// <summary>
        /// Creates a new Error containing a value.
        /// </summary>
        /// <typeparam name="T">Error type.</typeparam>
        /// <param name="item">Item to hold in the new Error.</param>
        /// <returns>Error containing the given item.</returns>
        public static Error<T> MakeValue<T>(T item)
            => Error<T>.MakeValue(item);

        /// <summary>
        /// Creates an Error containing the result of calling the given function.
        /// </summary>
        /// <typeparam name="T">Error type.</typeparam>
        /// <param name="func">Function to call.</param>
        /// <returns>Error containing either the result of the function or an exception.</returns>
        public static Error<T> Make<T>(Func<T> func)
        {
            try
            {
                return func();
            }
            catch (Exception e)
            {
                return e;
            }
        }
    }

    /// <summary>
    /// Error holds either a value of type <typeparamref name="T"/> or an exception.
    /// </summary>
    /// <typeparam name="T">Type of value.</typeparam>
    public class Error<T>
    {
        private Either<Exception, T> either;

        /// <summary>
        /// True if Error contains an exception.
        /// </summary>
        public bool IsError => either.IsLeft;

        /// <summary>
        /// True if Error contains a value.
        /// </summary>
        public bool HasValue => either.IsRight;

        private Error(Either<Exception, T> either) => this.either = either;

        /// <summary>
        /// Creates a new Error from the given exception.
        /// </summary>
        /// <param name="e">Exception to initialize Error with.</param>
        public Error(Exception e)
            : this(Either<Exception, T>.MakeLeft(e))
        { }

        /// <summary>
        /// Creates a new Error from the given item.
        /// </summary>
        /// <param name="item">Item to initialize the error with.</param>
        public Error(T item)
            : this(Either<Exception, T>.MakeRight(item))
        { }

        /// <summary>
        /// Gets the value inhabiting the Error.
        /// </summary>
        /// <returns>Value inhabiting the Error.</returns>
        /// <exception cref="InvalidCastException">Thrown if the Error contains an exception.</exception>
        public T Get() => either.GetRight();

        /// <summary>
        /// Gets the exception inhabiting the Error.
        /// </summary>
        /// <returns>Exception inhabiting the Error.</returns>
        /// <exception cref="InvalidCastException">Thrown if the Error contains an exception.</exception>
        public Exception Exception() => either.GetLeft();

        /// <summary>
        /// Creates a new Error containing an exception.
        /// </summary>
        /// <param name="e">Exception to hold in the new Error.</param>
        /// <returns>Error containing the given exception.</returns>
        public static Error<T> MakeException(Exception e)
            => new Error<T>(Either<Exception, T>.MakeLeft(e));

        /// <summary>
        /// Creates a new Error containing a value.
        /// </summary>
        /// <param name="item">Item to hold in the new Error.</param>
        /// <returns>Error containing the given item.</returns>
        public static Error<T> MakeValue(T item)
            => new Error<T>(Either<Exception, T>.MakeRight(item));
        
        /// <summary>
        /// Implicit cast from Exception to Error.
        /// </summary>
        /// <param name="e">Exception to cast from.</param>
        public static implicit operator Error<T>(Exception e) => new Error<T>(Either<Exception, T>.MakeLeft(e));

        /// <summary>
        /// Explicit cast from Error to Exception.
        /// </summary>
        /// <param name="error">Error to cast from.</param>
        /// <exception cref="InvalidCastException">Thrown if the Error doesn't contain an exception.</exception>
        public static explicit operator Exception(Error<T> error) => error.either.GetLeft();

        /// <summary>
        /// Implicit cast from type <typeparamref name="T"/> to Error.
        /// </summary>
        /// <param name="item">Item to cast from.</param>
        public static implicit operator Error<T>(T item) => new Error<T>(Either<Exception, T>.MakeRight(item));

        /// <summary>
        /// Explicit cast from Error to type <typeparamref name="T"/>.
        /// </summary>
        /// <param name="error">Error to cast from.</param>
        /// <exception cref="InvalidCastException">Thrown if the Error doesn't contain a value.</exception>
        public static explicit operator T(Error<T> error) => error.either.GetRight();
    }
}
