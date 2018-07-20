using System;
using System.Collections.Generic;
using System.Text;

namespace Maki
{
    /// <summary>
    /// Provides static utilities for NotNull.
    /// </summary>
    public static class NotNull
    {
        /// <summary>
        /// Creates a new NotNull from the given object.
        /// </summary>
        /// <typeparam name="T">Item type.</typeparam>
        /// <param name="item">Object to store.</param>
        /// <exception cref="ArgumentNullException">Thrown if the argument is null.</exception>
        public static NotNull<T> Make<T>(T item) => new NotNull<T>(item);

        /// <summary>
        /// Creates an Optional from the given object which is either Nothing if the
        /// object is null or NotNull if the object is not null.
        /// </summary>
        /// <typeparam name="T">Item type.</typeparam>
        /// <param name="item">Object to store.</param>
        /// <returns>NotNull if object is not null, Nothing otherwise.</returns>
        public static Optional<NotNull<T>> MakeOptional<T>(T item) => NotNull<T>.MakeOptional(item);
    }

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

        /// <summary>
        /// Creates an Optional from the given object which is either Nothing if the
        /// object is null or NotNull if the object is not null.
        /// </summary>
        /// <param name="value">Object to store.</param>
        /// <returns>NotNull if object is not null, Nothing otherwise.</returns>
        public static Optional<NotNull<T>> MakeOptional(T value) 
            => value == null ? Optional.Nothing : Optional.Make(new NotNull<T>(value));


        /// <summary>
        /// Determines whether the specified object is equal to the current object.
        /// </summary>
        /// <param name="obj">The object to compare with the current object.</param>
        /// <returns>True if the objects are equal.</returns>
        public override bool Equals(object obj) => obj?.Equals(Item) ?? false;

        /// <summary>
        /// Returns the hash code for this instance.
        /// </summary>
        /// <returns>Hash code.</returns>
        public override int GetHashCode() => Item.GetHashCode();
    }
}
