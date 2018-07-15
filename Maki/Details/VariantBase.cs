using System;
using System.Collections.Generic;
using System.Text;

namespace Maki.Details
{
    /// <summary>
    /// Used internally to implement Variant types.
    /// </summary>
    public abstract class VariantBase
    {
        private readonly IVariantHolder variant;

        /// <summary>
        /// Gets the 0-based index of the type inhabiting the variant.
        /// </summary>
        public byte Index { get; private set; }

        /// <summary>
        /// Returns a value that indicates whether the variant is inhabited by an item of type <typeparamref name="T"/>.
        /// </summary>
        /// <typeparam name="T">Should be one of the variant's supplied types.</typeparam>
        /// <returns>True if the variant is inhabited by an item of type <typenameref type="T"/>, false otherwise.</returns>
        public bool Is<T>() => variant.Is<T>();

        /// <summary>
        /// Gets the item inhabiting the variant as a <typeparamref name="T"/>.
        /// </summary>
        /// <typeparam name="T">Should be one of the variant's supplied types.</typeparam>
        /// <returns>Item inhabiting the variant as the given type <tpyenameref name="T"/>.</returns>
        /// <exception cref="InvalidCastException">Thrown if the item inhabiting the variant is not of type <typenameref type="T"/></exception>
        public T Get<T>() => ((VariantHolder<T>)variant).Item;

        /// <summary>
        /// Gets the item inhabiting the variant as an object.
        /// </summary>
        /// <returns>Item inhabiting the variant as an object.</returns>
        public object Get() => variant.Get();

        internal VariantBase(IVariantHolder item, byte index)
        {
            variant = item;
            Index = index;
        }
    }
}
