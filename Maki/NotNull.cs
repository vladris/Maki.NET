using System;
using System.Collections.Generic;
using System.Text;

namespace Maki
{
    /// <summary>
    /// Represents an object that cannot be null.
    /// </summary>
    /// <typeparam name="T">Type of object.</typeparam>
    public struct NotNull<T>
    {
        /// <summary>
        /// Gets the object.
        /// </summary>
        public T Item { get; }

        /// <summary>
        /// Creates a new NotNull from the given object.
        /// </summary>
        /// <param name="item">Object to store.</param>
        /// <exception cref="ArgumentNullException">Thrown if the argument is null.</exception>
        public NotNull(T item)
        {
            if (item == null)
            {
                throw new ArgumentNullException();
            }

            Item = item;
        }

        /// <summary>
        /// Implicit conversion to contained type.
        /// </summary>
        /// <param name="notNull">NotNull instance.</param>
        public static implicit operator T(NotNull<T> notNull) => notNull.Item;

        /// <summary>
        /// Creates a new NotNull from the given object.
        /// </summary>
        /// <param name="item">Object to store.</param>
        public static implicit operator NotNull<T>(T item) => new NotNull<T>(item);
    }
}
