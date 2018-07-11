namespace Maki
{
    /// <summary>
    /// Provides static utilities for Maybe.
    /// </summary>
    public static class Maybe
    {
        /// <summary>
        /// Represents an empty Maybe.
        /// </summary>
        public static Unit Nothing = Unit.Value;

        /// <summary>
        /// Creates a Maybe containing the given item.
        /// </summary>
        /// <typeparam name="T">Item type.</typeparam>
        /// <param name="item">Item to place in the Maybe.</param>
        /// <returns>A new Maybe containing an item of <typeparamref name="T"/>.</returns>
        public static Maybe<T> Just<T>(T item) => new Maybe<T>(item);
    }

    /// <summary>
    /// Represents an optional item of type <typeparamref name="T"/>.
    /// </summary>
    /// <typeparam name="T">Contained item type.</typeparam>
    public sealed class Maybe<T>
    {
        private Variant<T, Unit> item;

        /// <summary>
        /// True if the optional holds an item.
        /// </summary>
        public bool HasValue => item.Index == 0;

        /// <summary>
        /// Represtens an empty Maybe of the given type <typeparamref name="T"/>.
        /// </summary>
        public static Maybe<T> Nothing => new Maybe<T>();

        /// <summary>
        /// Creates an empty Maybe.
        /// </summary>
        public Maybe() => item = Maybe.Nothing;

        /// <summary>
        /// Creates a Maybe holding the given item.
        /// </summary>
        /// <param name="item">Item to place into the Maybe.</param>
        public Maybe(T item) => this.item = item;

        /// <summary>
        /// Gets the item held by this Maybe.
        /// </summary>
        /// <returns>Item held by this Maybe.</returns>
        /// <exception cref="InvalidCastException">Thrown when Maybe does not hold an item.</exception>
        public T Get() => (T)item;

        /// <summary>
        /// Creates a new empty Maybe.
        /// </summary>
        /// <param name="unit">Unit type, can be Maybe.Nothing.</param>
        public static implicit operator Maybe<T>(Unit unit) => new Maybe<T>();

        /// <summary>
        /// Implicitly casts from the given item to a Maybe holding the item.
        /// </summary>
        /// <param name="item">Item to cast from.</param>
        public static implicit operator Maybe<T>(T item) => new Maybe<T>(item);


        /// <summary>
        /// Explicitly casts from the given Maybe to the held item type.
        /// </summary>
        /// <param name="maybe">Maybe to cast from.</param>
        public static explicit operator T(Maybe<T> maybe) => maybe.item.Get<T>();

        /// <summary>
        /// Determines whether the specified object is equal to the current object.
        /// </summary>
        /// <param name="obj">The object to compare with the current object.</param>
        /// <returns>True if the objects are equal.</returns>
        public override bool Equals(object obj) => HasValue ? obj.Equals(Get()) : obj.Equals(Unit.Value);
    }
}
