using System;
using System.Collections.Generic;
using System.Text;

namespace Maki
{
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
