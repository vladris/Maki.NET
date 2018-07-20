using System;

namespace Maki
{
    /// <summary>
    /// Provides static utilities for Optional.
    /// </summary>
    public static class Optional
    {
        /// <summary>
        /// Represents an empty Optional.
        /// </summary>
        public static Unit Nothing = Unit.Value;

        /// <summary>
        /// Creates an Optional containing the given item.
        /// </summary>
        /// <typeparam name="T">Item type.</typeparam>
        /// <param name="item">Item to place in the Optional.</param>
        /// <returns>A new Optional containing an item of <typeparamref name="T"/>.</returns>
        public static Optional<T> Make<T>(T item) => new Optional<T>(item);
    }

    /// <summary>
    /// Represents an optional item of type <typeparamref name="T"/>.
    /// </summary>
    /// <typeparam name="T">Contained item type.</typeparam>
    public sealed class Optional<T>
    {
        private Variant<T, Unit> item;

        /// <summary>
        /// True if the optional holds an item.
        /// </summary>
        public bool HasValue => item.Index == 0;

        /// <summary>
        /// Represtens an empty Optional of the given type <typeparamref name="T"/>.
        /// </summary>
        public static Optional<T> Nothing => new Optional<T>();

        /// <summary>
        /// Creates an empty Optional.
        /// </summary>
        public Optional() => item = Optional.Nothing;

        /// <summary>
        /// Creates an Optional holding the given item.
        /// </summary>
        /// <param name="item">Item to place into the Optional.</param>
        public Optional(T item) => this.item = item;

        /// <summary>
        /// Gets the item held by this Optional.
        /// </summary>
        /// <returns>Item held by this Optional.</returns>
        /// <exception cref="InvalidCastException">Thrown when the Optional does not hold an item.</exception>
        public T Get() => (T)item;

        /// <summary>
        /// Creates a new empty Optional.
        /// </summary>
        /// <param name="unit">Unit type, can be Optional.Nothing.</param>
        public static implicit operator Optional<T>(Unit unit) => new Optional<T>();

        /// <summary>
        /// Implicitly casts from the given item to an Optional holding the item.
        /// </summary>
        /// <param name="item">Item to cast from.</param>
        public static implicit operator Optional<T>(T item) => new Optional<T>(item);


        /// <summary>
        /// Explicitly casts from the given Optional to the held item type.
        /// </summary>
        /// <param name="optional">Optional to cast from.</param>
        public static explicit operator T(Optional<T> optional) => optional.item.Get<T>();

        /// <summary>
        /// Determines whether the specified object is equal to the current object.
        /// </summary>
        /// <param name="obj">The object to compare with the current object.</param>
        /// <returns>True if the objects are equal.</returns>
        public override bool Equals(object obj)
        {
            if (obj == null) return false;

            if (!(obj is Optional<T>)) return false;

            var other = (Optional<T>)obj;

            if (!HasValue) return !other.HasValue;

            return other.HasValue && item.Equals(other.item);
        }

        /// <summary>
        /// Returns the hash code for this instance.
        /// </summary>
        /// <returns>Hash code.</returns>
        public override int GetHashCode()
        {
            if (!HasValue) return base.GetHashCode();

            return item.GetHashCode();
        }
    }
}
