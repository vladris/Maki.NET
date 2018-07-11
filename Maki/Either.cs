using System;
using System.Collections.Generic;
using System.Text;

namespace Maki
{
    /// <summary>
    /// Represents a 2-type discriminate union with Left and Right components.
    /// </summary>
    /// <typeparam name="TLeft">Left type.</typeparam>
    /// <typeparam name="TRight">Right type.</typeparam>
    public sealed class Either<TLeft, TRight>
    {
        private Variant<TLeft, TRight> variant;

        /// <summary>
        /// True if Left is inhabited.
        /// </summary>
        public bool IsLeft { get => variant.Index == 0; }

        /// <summary>
        /// True if Right is inhabited.
        /// </summary>
        public bool IsRight { get => variant.Index == 1; }

        /// <summary>
        /// Gets or sets the Left component.
        /// </summary>
        /// <exception cref="InvalidCastException">Thrown on get if the inhabiting object is Right.</exception>
        public TLeft Left
        {
            get
            {
                return IsLeft ? variant.Get<TLeft>() : throw new InvalidCastException();
            }
            set
            {
                variant = Variant<TLeft, TRight>.Make1(value);
            }
        }

        /// <summary>
        /// Gets or sets the Right component.
        /// </summary>
        /// <exception cref="InvalidCastException">Thrown on get if the inhabiting object is Left.</exception>
        public TRight Right
        {
            get
            {
                return IsRight ? variant.Get<TRight>() : throw new InvalidCastException();
            }
            set
            {
                variant = Variant<TLeft, TRight>.Make2(value);
            }
        }

        private Either(Variant<TLeft, TRight> variant) => this.variant = variant;

        /// <summary>
        /// Creates a new instance of Either from an item of type <typeparamref name="TLeft"/>.
        /// </summary>
        /// <param name="left">Item of type <typeparamref name="TLeft"/></param>
        public Either(TLeft left) 
            : this(Variant<TLeft, TRight>.Make1(left))
        { }

        /// <summary>
        /// Creates a new instance of Either from an item of type <typeparamref name="TRight"/>
        /// </summary>
        /// <param name="right">Item of type <typeparamref name="TRight"/></param>
        public Either(TRight right)
            : this(Variant<TLeft, TRight>.Make2(right))
        { }

        /// <summary>
        /// Determines whether the specified object is equal to the current object.
        /// </summary>
        /// <param name="obj">The object to compare with the current object.</param>
        /// <returns>True if the objects are equal.</returns>
        public override bool Equals(object obj)
        {
            return variant.Equals(obj);
        }

        /// <summary>
        /// Returns the hash code for this instance.
        /// </summary>
        /// <returns>Hash code.</returns>
        public override int GetHashCode()
        {
            return variant.GetHashCode();
        }

        /// <summary>
        /// Implicit cast from <typeparamref name="TLeft"/> item to Either. Creates a new Either.
        /// </summary>
        /// <param name="item">Item to place in Either.</param>
        public static implicit operator Either<TLeft, TRight>(TLeft item) => new Either<TLeft, TRight>(item);

        /// <summary>
        /// Implicit cast from <typeparamref name="TRight"/> item to Either. Creates a new Either.
        /// </summary>
        /// <param name="item">Item to place in Either.</param>
        public static implicit operator Either<TLeft, TRight>(TRight item) => new Either<TLeft, TRight>(item);

        /// <summary>
        /// Explicit cast from Either to <typeparamref name="TLeft"/>.
        /// </summary>
        /// <param name="either">Either object to cast.</param>
        /// <exception cref="InvalidCastException">Thrown when the inhabiting object of the either is Right.</exception>
        public static explicit operator TLeft(Either<TLeft, TRight> either) => either.Left;

        /// <summary>
        /// Explicit cast from Either to <typeparamref name="TRight"/>.
        /// </summary>
        /// <param name="either">Either object to cast.</param>
        /// <exception cref="InvalidCastException">Thrown when the inhabiting object of the either is Left.</exception>
        public static explicit operator TRight(Either<TLeft, TRight> either) => either.Right;

        /// <summary>
        /// Creates a new Either explicitly placing the item in the Left component.
        /// </summary>
        /// <param name="item">Item to place in the Either.</param>
        /// <returns>Either containing the item.</returns>
        /// <remarks>Use this method when both <typeparamref name="TLeft"/> and <typeparamref name="TRight"/> are the same.</remarks>
        public static Either<TLeft, TRight> MakeLeft(TLeft item) => new Either<TLeft, TRight>(Variant<TLeft, TRight>.Make1(item));

        /// <summary>
        /// Creates a new Either explicitly placing the item in the Right component.
        /// </summary>
        /// <param name="item">Item to place in the Either.</param>
        /// <returns>Either containing the item.</returns>
        /// <remarks>Use this method when both <typeparamref name="TLeft"/> and <typeparamref name="TRight"/> are the same.</remarks>
        public static Either<TLeft, TRight> MakeRight(TRight item) => new Either<TLeft, TRight>(Variant<TLeft, TRight>.Make2(item));
    }
}
