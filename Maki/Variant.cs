using Maki.Details;
using System;
using System.Diagnostics;

namespace Maki
{
    /// <summary>
    /// Represents a 2-type discriminate union.
    /// </summary>
    /// <typeparam name="T1">Represents the variant's first type.</typeparam>
    /// <typeparam name="T2">Represents the variant's second type.</typeparam>
    public sealed class Variant<T1, T2>
    {
        private readonly IVariantHolder variant;

        /// <summary>
        /// Gets the 0-based index of the type inhabiting the variant.
        /// </summary>
        public int Index => variant.Index;

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
        /// <exception cref="InvalidCastException">Thrown if the item inhabiting the variant is not of type <typenameref type="T"/></exception>
        public T Get<T>() => Is<T>() ? ((VariantHolder<T>)variant).Item : throw new InvalidCastException();

        private Variant(IVariantHolder item) => variant = item;

        /// <summary>
        /// Creates a new Variant instance from an item of type <typeparamref name="T1"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T1"/>.</param>
        public Variant(T1 item) => variant = VariantHolder<T1>.T1(item);

        /// <summary>
        /// Creates a new Variant instance from an item of type <typeparamref name="T2"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T2"/>.</param>
        public Variant(T2 item) => variant = VariantHolder<T2>.T2(item);

        /// <summary>
        /// Determines whether the specified object is equal to the current object.
        /// </summary>
        /// <param name="obj">The object to compare with the current object.</param>
        /// <returns>True if the objects are equal.</returns>
        public override bool Equals(object obj)
        {
            if (obj == null) return false;

            if (!(obj is Variant<T1, T2>)) return base.Equals(obj);

            var other = (Variant<T1, T2>)obj;

            switch (Index)
            {
            case 0:
                return other.Is<T1>() && ((VariantHolder<T1>)variant).Item.Equals(((VariantHolder<T1>)other.variant).Item);
            case 1:
                return other.Is<T2>() && ((VariantHolder<T2>)variant).Item.Equals(((VariantHolder<T2>)other.variant).Item);
            }

            Debug.Fail("Not reached");
            return false; 
        }

        /// <summary>
        /// Creates a new Variant explicitly placing the item as the first type
        /// (<typeparamref name="T1"/>).
        /// </summary>
        /// <param name="item">Item to place in the variant.</param>
        /// <returns>New Variant instance.</returns>
        /// <remarks>Use this method when the variant contains multiple instances of the same type. This
        /// allows explicit placing of the item.</remarks>
        public static Variant<T1, T2> Make1(T1 item) => new Variant<T1, T2>(VariantHolder<T1>.T1(item));

        /// <summary>
        /// Implicitly casts from <typeparamref name="T1"/> to variant. Creates a new Variant
        /// inhabited by the given item.
        /// </summary>
        /// <param name="item">Item to store in the variant.</param>
        public static implicit operator Variant<T1, T2>(T1 item) => new Variant<T1, T2>(item);

        /// <summary>
        /// Explicitly casts from variant to <typeparamref name="T1"/>.
        /// </summary>
        /// <param name="variant">Variant to cast to <typeparamref name="T1"/>.</param>
        /// <exception cref="System.InvalidCastException">Thrown if the item inhabiting the variant is not of type <typenameref type="T1"/></exception>
        public static explicit operator T1(Variant<T1, T2> variant) => ((VariantHolder<T1>)variant.variant).Item;

        /// <summary>
        /// Creates a new Variant explicitly placing the item as the second type
        /// (<typeparamref name="T2"/>).
        /// </summary>
        /// <param name="item">Item to place in the variant.</param>
        /// <returns>New Variant instance.</returns>
        /// <remarks>Use this method when the variant contains multiple instances of the same type. This
        /// allows explicit placing of the item.</remarks>
        public static Variant<T1, T2> Make2(T2 item) => new Variant<T1, T2>(VariantHolder<T2>.T2(item));

        /// <summary>
        /// Implicitly casts from <typeparamref name="T2"/> to variant. Creates a new Variant
        /// inhabited by the given item.
        /// </summary>
        /// <param name="item">Item to store in the variant.</param>
        public static implicit operator Variant<T1, T2>(T2 item) => new Variant<T1, T2>(item);

        /// <summary>
        /// Explicitly casts from variant to <typeparamref name="T2"/>.
        /// </summary>
        /// <param name="variant">Variant to cast to <typeparamref name="T2"/>.</param>
        /// <exception cref="System.InvalidCastException">Thrown if the item inhabiting the variant is not of type <typenameref type="T2"/></exception>
        public static explicit operator T2(Variant<T1, T2> variant) => ((VariantHolder<T2>)variant.variant).Item;

    }
    /// <summary>
    /// Represents a 3-type discriminate union.
    /// </summary>
    /// <typeparam name="T1">Represents the variant's first type.</typeparam>
    /// <typeparam name="T2">Represents the variant's second type.</typeparam>
    /// <typeparam name="T3">Represents the variant's third type.</typeparam>
    public sealed class Variant<T1, T2, T3>
    {
        private readonly IVariantHolder variant;

        /// <summary>
        /// Gets the 0-based index of the type inhabiting the variant.
        /// </summary>
        public int Index => variant.Index;

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
        /// <exception cref="InvalidCastException">Thrown if the item inhabiting the variant is not of type <typenameref type="T"/></exception>
        public T Get<T>() => Is<T>() ? ((VariantHolder<T>)variant).Item : throw new InvalidCastException();

        private Variant(IVariantHolder item) => variant = item;

        /// <summary>
        /// Creates a new Variant instance from an item of type <typeparamref name="T1"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T1"/>.</param>
        public Variant(T1 item) => variant = VariantHolder<T1>.T1(item);

        /// <summary>
        /// Creates a new Variant instance from an item of type <typeparamref name="T2"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T2"/>.</param>
        public Variant(T2 item) => variant = VariantHolder<T2>.T2(item);

        /// <summary>
        /// Creates a new Variant instance from an item of type <typeparamref name="T3"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T3"/>.</param>
        public Variant(T3 item) => variant = VariantHolder<T3>.T3(item);

        /// <summary>
        /// Determines whether the specified object is equal to the current object.
        /// </summary>
        /// <param name="obj">The object to compare with the current object.</param>
        /// <returns>True if the objects are equal.</returns>
        public override bool Equals(object obj)
        {
            if (obj == null) return false;

            if (!(obj is Variant<T1, T2, T3>)) return base.Equals(obj);

            var other = (Variant<T1, T2, T3>)obj;

            switch (Index)
            {
            case 0:
                return other.Is<T1>() && ((VariantHolder<T1>)variant).Item.Equals(((VariantHolder<T1>)other.variant).Item);
            case 1:
                return other.Is<T2>() && ((VariantHolder<T2>)variant).Item.Equals(((VariantHolder<T2>)other.variant).Item);
            case 2:
                return other.Is<T3>() && ((VariantHolder<T3>)variant).Item.Equals(((VariantHolder<T3>)other.variant).Item);
            }

            Debug.Fail("Not reached");
            return false; 
        }

        /// <summary>
        /// Creates a new Variant explicitly placing the item as the first type
        /// (<typeparamref name="T1"/>).
        /// </summary>
        /// <param name="item">Item to place in the variant.</param>
        /// <returns>New Variant instance.</returns>
        /// <remarks>Use this method when the variant contains multiple instances of the same type. This
        /// allows explicit placing of the item.</remarks>
        public static Variant<T1, T2, T3> Make1(T1 item) => new Variant<T1, T2, T3>(VariantHolder<T1>.T1(item));

        /// <summary>
        /// Implicitly casts from <typeparamref name="T1"/> to variant. Creates a new Variant
        /// inhabited by the given item.
        /// </summary>
        /// <param name="item">Item to store in the variant.</param>
        public static implicit operator Variant<T1, T2, T3>(T1 item) => new Variant<T1, T2, T3>(item);

        /// <summary>
        /// Explicitly casts from variant to <typeparamref name="T1"/>.
        /// </summary>
        /// <param name="variant">Variant to cast to <typeparamref name="T1"/>.</param>
        /// <exception cref="System.InvalidCastException">Thrown if the item inhabiting the variant is not of type <typenameref type="T1"/></exception>
        public static explicit operator T1(Variant<T1, T2, T3> variant) => ((VariantHolder<T1>)variant.variant).Item;

        /// <summary>
        /// Creates a new Variant explicitly placing the item as the second type
        /// (<typeparamref name="T2"/>).
        /// </summary>
        /// <param name="item">Item to place in the variant.</param>
        /// <returns>New Variant instance.</returns>
        /// <remarks>Use this method when the variant contains multiple instances of the same type. This
        /// allows explicit placing of the item.</remarks>
        public static Variant<T1, T2, T3> Make2(T2 item) => new Variant<T1, T2, T3>(VariantHolder<T2>.T2(item));

        /// <summary>
        /// Implicitly casts from <typeparamref name="T2"/> to variant. Creates a new Variant
        /// inhabited by the given item.
        /// </summary>
        /// <param name="item">Item to store in the variant.</param>
        public static implicit operator Variant<T1, T2, T3>(T2 item) => new Variant<T1, T2, T3>(item);

        /// <summary>
        /// Explicitly casts from variant to <typeparamref name="T2"/>.
        /// </summary>
        /// <param name="variant">Variant to cast to <typeparamref name="T2"/>.</param>
        /// <exception cref="System.InvalidCastException">Thrown if the item inhabiting the variant is not of type <typenameref type="T2"/></exception>
        public static explicit operator T2(Variant<T1, T2, T3> variant) => ((VariantHolder<T2>)variant.variant).Item;

        /// <summary>
        /// Creates a new Variant explicitly placing the item as the third type
        /// (<typeparamref name="T3"/>).
        /// </summary>
        /// <param name="item">Item to place in the variant.</param>
        /// <returns>New Variant instance.</returns>
        /// <remarks>Use this method when the variant contains multiple instances of the same type. This
        /// allows explicit placing of the item.</remarks>
        public static Variant<T1, T2, T3> Make3(T3 item) => new Variant<T1, T2, T3>(VariantHolder<T3>.T3(item));

        /// <summary>
        /// Implicitly casts from <typeparamref name="T3"/> to variant. Creates a new Variant
        /// inhabited by the given item.
        /// </summary>
        /// <param name="item">Item to store in the variant.</param>
        public static implicit operator Variant<T1, T2, T3>(T3 item) => new Variant<T1, T2, T3>(item);

        /// <summary>
        /// Explicitly casts from variant to <typeparamref name="T3"/>.
        /// </summary>
        /// <param name="variant">Variant to cast to <typeparamref name="T3"/>.</param>
        /// <exception cref="System.InvalidCastException">Thrown if the item inhabiting the variant is not of type <typenameref type="T3"/></exception>
        public static explicit operator T3(Variant<T1, T2, T3> variant) => ((VariantHolder<T3>)variant.variant).Item;

    }
    /// <summary>
    /// Represents a 4-type discriminate union.
    /// </summary>
    /// <typeparam name="T1">Represents the variant's first type.</typeparam>
    /// <typeparam name="T2">Represents the variant's second type.</typeparam>
    /// <typeparam name="T3">Represents the variant's third type.</typeparam>
    /// <typeparam name="T4">Represents the variant's fourth type.</typeparam>
    public sealed class Variant<T1, T2, T3, T4>
    {
        private readonly IVariantHolder variant;

        /// <summary>
        /// Gets the 0-based index of the type inhabiting the variant.
        /// </summary>
        public int Index => variant.Index;

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
        /// <exception cref="InvalidCastException">Thrown if the item inhabiting the variant is not of type <typenameref type="T"/></exception>
        public T Get<T>() => Is<T>() ? ((VariantHolder<T>)variant).Item : throw new InvalidCastException();

        private Variant(IVariantHolder item) => variant = item;

        /// <summary>
        /// Creates a new Variant instance from an item of type <typeparamref name="T1"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T1"/>.</param>
        public Variant(T1 item) => variant = VariantHolder<T1>.T1(item);

        /// <summary>
        /// Creates a new Variant instance from an item of type <typeparamref name="T2"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T2"/>.</param>
        public Variant(T2 item) => variant = VariantHolder<T2>.T2(item);

        /// <summary>
        /// Creates a new Variant instance from an item of type <typeparamref name="T3"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T3"/>.</param>
        public Variant(T3 item) => variant = VariantHolder<T3>.T3(item);

        /// <summary>
        /// Creates a new Variant instance from an item of type <typeparamref name="T4"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T4"/>.</param>
        public Variant(T4 item) => variant = VariantHolder<T4>.T4(item);

        /// <summary>
        /// Determines whether the specified object is equal to the current object.
        /// </summary>
        /// <param name="obj">The object to compare with the current object.</param>
        /// <returns>True if the objects are equal.</returns>
        public override bool Equals(object obj)
        {
            if (obj == null) return false;

            if (!(obj is Variant<T1, T2, T3, T4>)) return base.Equals(obj);

            var other = (Variant<T1, T2, T3, T4>)obj;

            switch (Index)
            {
            case 0:
                return other.Is<T1>() && ((VariantHolder<T1>)variant).Item.Equals(((VariantHolder<T1>)other.variant).Item);
            case 1:
                return other.Is<T2>() && ((VariantHolder<T2>)variant).Item.Equals(((VariantHolder<T2>)other.variant).Item);
            case 2:
                return other.Is<T3>() && ((VariantHolder<T3>)variant).Item.Equals(((VariantHolder<T3>)other.variant).Item);
            case 3:
                return other.Is<T4>() && ((VariantHolder<T4>)variant).Item.Equals(((VariantHolder<T4>)other.variant).Item);
            }

            Debug.Fail("Not reached");
            return false; 
        }

        /// <summary>
        /// Creates a new Variant explicitly placing the item as the first type
        /// (<typeparamref name="T1"/>).
        /// </summary>
        /// <param name="item">Item to place in the variant.</param>
        /// <returns>New Variant instance.</returns>
        /// <remarks>Use this method when the variant contains multiple instances of the same type. This
        /// allows explicit placing of the item.</remarks>
        public static Variant<T1, T2, T3, T4> Make1(T1 item) => new Variant<T1, T2, T3, T4>(VariantHolder<T1>.T1(item));

        /// <summary>
        /// Implicitly casts from <typeparamref name="T1"/> to variant. Creates a new Variant
        /// inhabited by the given item.
        /// </summary>
        /// <param name="item">Item to store in the variant.</param>
        public static implicit operator Variant<T1, T2, T3, T4>(T1 item) => new Variant<T1, T2, T3, T4>(item);

        /// <summary>
        /// Explicitly casts from variant to <typeparamref name="T1"/>.
        /// </summary>
        /// <param name="variant">Variant to cast to <typeparamref name="T1"/>.</param>
        /// <exception cref="System.InvalidCastException">Thrown if the item inhabiting the variant is not of type <typenameref type="T1"/></exception>
        public static explicit operator T1(Variant<T1, T2, T3, T4> variant) => ((VariantHolder<T1>)variant.variant).Item;

        /// <summary>
        /// Creates a new Variant explicitly placing the item as the second type
        /// (<typeparamref name="T2"/>).
        /// </summary>
        /// <param name="item">Item to place in the variant.</param>
        /// <returns>New Variant instance.</returns>
        /// <remarks>Use this method when the variant contains multiple instances of the same type. This
        /// allows explicit placing of the item.</remarks>
        public static Variant<T1, T2, T3, T4> Make2(T2 item) => new Variant<T1, T2, T3, T4>(VariantHolder<T2>.T2(item));

        /// <summary>
        /// Implicitly casts from <typeparamref name="T2"/> to variant. Creates a new Variant
        /// inhabited by the given item.
        /// </summary>
        /// <param name="item">Item to store in the variant.</param>
        public static implicit operator Variant<T1, T2, T3, T4>(T2 item) => new Variant<T1, T2, T3, T4>(item);

        /// <summary>
        /// Explicitly casts from variant to <typeparamref name="T2"/>.
        /// </summary>
        /// <param name="variant">Variant to cast to <typeparamref name="T2"/>.</param>
        /// <exception cref="System.InvalidCastException">Thrown if the item inhabiting the variant is not of type <typenameref type="T2"/></exception>
        public static explicit operator T2(Variant<T1, T2, T3, T4> variant) => ((VariantHolder<T2>)variant.variant).Item;

        /// <summary>
        /// Creates a new Variant explicitly placing the item as the third type
        /// (<typeparamref name="T3"/>).
        /// </summary>
        /// <param name="item">Item to place in the variant.</param>
        /// <returns>New Variant instance.</returns>
        /// <remarks>Use this method when the variant contains multiple instances of the same type. This
        /// allows explicit placing of the item.</remarks>
        public static Variant<T1, T2, T3, T4> Make3(T3 item) => new Variant<T1, T2, T3, T4>(VariantHolder<T3>.T3(item));

        /// <summary>
        /// Implicitly casts from <typeparamref name="T3"/> to variant. Creates a new Variant
        /// inhabited by the given item.
        /// </summary>
        /// <param name="item">Item to store in the variant.</param>
        public static implicit operator Variant<T1, T2, T3, T4>(T3 item) => new Variant<T1, T2, T3, T4>(item);

        /// <summary>
        /// Explicitly casts from variant to <typeparamref name="T3"/>.
        /// </summary>
        /// <param name="variant">Variant to cast to <typeparamref name="T3"/>.</param>
        /// <exception cref="System.InvalidCastException">Thrown if the item inhabiting the variant is not of type <typenameref type="T3"/></exception>
        public static explicit operator T3(Variant<T1, T2, T3, T4> variant) => ((VariantHolder<T3>)variant.variant).Item;

        /// <summary>
        /// Creates a new Variant explicitly placing the item as the fourth type
        /// (<typeparamref name="T4"/>).
        /// </summary>
        /// <param name="item">Item to place in the variant.</param>
        /// <returns>New Variant instance.</returns>
        /// <remarks>Use this method when the variant contains multiple instances of the same type. This
        /// allows explicit placing of the item.</remarks>
        public static Variant<T1, T2, T3, T4> Make4(T4 item) => new Variant<T1, T2, T3, T4>(VariantHolder<T4>.T4(item));

        /// <summary>
        /// Implicitly casts from <typeparamref name="T4"/> to variant. Creates a new Variant
        /// inhabited by the given item.
        /// </summary>
        /// <param name="item">Item to store in the variant.</param>
        public static implicit operator Variant<T1, T2, T3, T4>(T4 item) => new Variant<T1, T2, T3, T4>(item);

        /// <summary>
        /// Explicitly casts from variant to <typeparamref name="T4"/>.
        /// </summary>
        /// <param name="variant">Variant to cast to <typeparamref name="T4"/>.</param>
        /// <exception cref="System.InvalidCastException">Thrown if the item inhabiting the variant is not of type <typenameref type="T4"/></exception>
        public static explicit operator T4(Variant<T1, T2, T3, T4> variant) => ((VariantHolder<T4>)variant.variant).Item;

    }
    /// <summary>
    /// Represents a 5-type discriminate union.
    /// </summary>
    /// <typeparam name="T1">Represents the variant's first type.</typeparam>
    /// <typeparam name="T2">Represents the variant's second type.</typeparam>
    /// <typeparam name="T3">Represents the variant's third type.</typeparam>
    /// <typeparam name="T4">Represents the variant's fourth type.</typeparam>
    /// <typeparam name="T5">Represents the variant's fifth type.</typeparam>
    public sealed class Variant<T1, T2, T3, T4, T5>
    {
        private readonly IVariantHolder variant;

        /// <summary>
        /// Gets the 0-based index of the type inhabiting the variant.
        /// </summary>
        public int Index => variant.Index;

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
        /// <exception cref="InvalidCastException">Thrown if the item inhabiting the variant is not of type <typenameref type="T"/></exception>
        public T Get<T>() => Is<T>() ? ((VariantHolder<T>)variant).Item : throw new InvalidCastException();

        private Variant(IVariantHolder item) => variant = item;

        /// <summary>
        /// Creates a new Variant instance from an item of type <typeparamref name="T1"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T1"/>.</param>
        public Variant(T1 item) => variant = VariantHolder<T1>.T1(item);

        /// <summary>
        /// Creates a new Variant instance from an item of type <typeparamref name="T2"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T2"/>.</param>
        public Variant(T2 item) => variant = VariantHolder<T2>.T2(item);

        /// <summary>
        /// Creates a new Variant instance from an item of type <typeparamref name="T3"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T3"/>.</param>
        public Variant(T3 item) => variant = VariantHolder<T3>.T3(item);

        /// <summary>
        /// Creates a new Variant instance from an item of type <typeparamref name="T4"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T4"/>.</param>
        public Variant(T4 item) => variant = VariantHolder<T4>.T4(item);

        /// <summary>
        /// Creates a new Variant instance from an item of type <typeparamref name="T5"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T5"/>.</param>
        public Variant(T5 item) => variant = VariantHolder<T5>.T5(item);

        /// <summary>
        /// Determines whether the specified object is equal to the current object.
        /// </summary>
        /// <param name="obj">The object to compare with the current object.</param>
        /// <returns>True if the objects are equal.</returns>
        public override bool Equals(object obj)
        {
            if (obj == null) return false;

            if (!(obj is Variant<T1, T2, T3, T4, T5>)) return base.Equals(obj);

            var other = (Variant<T1, T2, T3, T4, T5>)obj;

            switch (Index)
            {
            case 0:
                return other.Is<T1>() && ((VariantHolder<T1>)variant).Item.Equals(((VariantHolder<T1>)other.variant).Item);
            case 1:
                return other.Is<T2>() && ((VariantHolder<T2>)variant).Item.Equals(((VariantHolder<T2>)other.variant).Item);
            case 2:
                return other.Is<T3>() && ((VariantHolder<T3>)variant).Item.Equals(((VariantHolder<T3>)other.variant).Item);
            case 3:
                return other.Is<T4>() && ((VariantHolder<T4>)variant).Item.Equals(((VariantHolder<T4>)other.variant).Item);
            case 4:
                return other.Is<T5>() && ((VariantHolder<T5>)variant).Item.Equals(((VariantHolder<T5>)other.variant).Item);
            }

            Debug.Fail("Not reached");
            return false; 
        }

        /// <summary>
        /// Creates a new Variant explicitly placing the item as the first type
        /// (<typeparamref name="T1"/>).
        /// </summary>
        /// <param name="item">Item to place in the variant.</param>
        /// <returns>New Variant instance.</returns>
        /// <remarks>Use this method when the variant contains multiple instances of the same type. This
        /// allows explicit placing of the item.</remarks>
        public static Variant<T1, T2, T3, T4, T5> Make1(T1 item) => new Variant<T1, T2, T3, T4, T5>(VariantHolder<T1>.T1(item));

        /// <summary>
        /// Implicitly casts from <typeparamref name="T1"/> to variant. Creates a new Variant
        /// inhabited by the given item.
        /// </summary>
        /// <param name="item">Item to store in the variant.</param>
        public static implicit operator Variant<T1, T2, T3, T4, T5>(T1 item) => new Variant<T1, T2, T3, T4, T5>(item);

        /// <summary>
        /// Explicitly casts from variant to <typeparamref name="T1"/>.
        /// </summary>
        /// <param name="variant">Variant to cast to <typeparamref name="T1"/>.</param>
        /// <exception cref="System.InvalidCastException">Thrown if the item inhabiting the variant is not of type <typenameref type="T1"/></exception>
        public static explicit operator T1(Variant<T1, T2, T3, T4, T5> variant) => ((VariantHolder<T1>)variant.variant).Item;

        /// <summary>
        /// Creates a new Variant explicitly placing the item as the second type
        /// (<typeparamref name="T2"/>).
        /// </summary>
        /// <param name="item">Item to place in the variant.</param>
        /// <returns>New Variant instance.</returns>
        /// <remarks>Use this method when the variant contains multiple instances of the same type. This
        /// allows explicit placing of the item.</remarks>
        public static Variant<T1, T2, T3, T4, T5> Make2(T2 item) => new Variant<T1, T2, T3, T4, T5>(VariantHolder<T2>.T2(item));

        /// <summary>
        /// Implicitly casts from <typeparamref name="T2"/> to variant. Creates a new Variant
        /// inhabited by the given item.
        /// </summary>
        /// <param name="item">Item to store in the variant.</param>
        public static implicit operator Variant<T1, T2, T3, T4, T5>(T2 item) => new Variant<T1, T2, T3, T4, T5>(item);

        /// <summary>
        /// Explicitly casts from variant to <typeparamref name="T2"/>.
        /// </summary>
        /// <param name="variant">Variant to cast to <typeparamref name="T2"/>.</param>
        /// <exception cref="System.InvalidCastException">Thrown if the item inhabiting the variant is not of type <typenameref type="T2"/></exception>
        public static explicit operator T2(Variant<T1, T2, T3, T4, T5> variant) => ((VariantHolder<T2>)variant.variant).Item;

        /// <summary>
        /// Creates a new Variant explicitly placing the item as the third type
        /// (<typeparamref name="T3"/>).
        /// </summary>
        /// <param name="item">Item to place in the variant.</param>
        /// <returns>New Variant instance.</returns>
        /// <remarks>Use this method when the variant contains multiple instances of the same type. This
        /// allows explicit placing of the item.</remarks>
        public static Variant<T1, T2, T3, T4, T5> Make3(T3 item) => new Variant<T1, T2, T3, T4, T5>(VariantHolder<T3>.T3(item));

        /// <summary>
        /// Implicitly casts from <typeparamref name="T3"/> to variant. Creates a new Variant
        /// inhabited by the given item.
        /// </summary>
        /// <param name="item">Item to store in the variant.</param>
        public static implicit operator Variant<T1, T2, T3, T4, T5>(T3 item) => new Variant<T1, T2, T3, T4, T5>(item);

        /// <summary>
        /// Explicitly casts from variant to <typeparamref name="T3"/>.
        /// </summary>
        /// <param name="variant">Variant to cast to <typeparamref name="T3"/>.</param>
        /// <exception cref="System.InvalidCastException">Thrown if the item inhabiting the variant is not of type <typenameref type="T3"/></exception>
        public static explicit operator T3(Variant<T1, T2, T3, T4, T5> variant) => ((VariantHolder<T3>)variant.variant).Item;

        /// <summary>
        /// Creates a new Variant explicitly placing the item as the fourth type
        /// (<typeparamref name="T4"/>).
        /// </summary>
        /// <param name="item">Item to place in the variant.</param>
        /// <returns>New Variant instance.</returns>
        /// <remarks>Use this method when the variant contains multiple instances of the same type. This
        /// allows explicit placing of the item.</remarks>
        public static Variant<T1, T2, T3, T4, T5> Make4(T4 item) => new Variant<T1, T2, T3, T4, T5>(VariantHolder<T4>.T4(item));

        /// <summary>
        /// Implicitly casts from <typeparamref name="T4"/> to variant. Creates a new Variant
        /// inhabited by the given item.
        /// </summary>
        /// <param name="item">Item to store in the variant.</param>
        public static implicit operator Variant<T1, T2, T3, T4, T5>(T4 item) => new Variant<T1, T2, T3, T4, T5>(item);

        /// <summary>
        /// Explicitly casts from variant to <typeparamref name="T4"/>.
        /// </summary>
        /// <param name="variant">Variant to cast to <typeparamref name="T4"/>.</param>
        /// <exception cref="System.InvalidCastException">Thrown if the item inhabiting the variant is not of type <typenameref type="T4"/></exception>
        public static explicit operator T4(Variant<T1, T2, T3, T4, T5> variant) => ((VariantHolder<T4>)variant.variant).Item;

        /// <summary>
        /// Creates a new Variant explicitly placing the item as the fifth type
        /// (<typeparamref name="T5"/>).
        /// </summary>
        /// <param name="item">Item to place in the variant.</param>
        /// <returns>New Variant instance.</returns>
        /// <remarks>Use this method when the variant contains multiple instances of the same type. This
        /// allows explicit placing of the item.</remarks>
        public static Variant<T1, T2, T3, T4, T5> Make5(T5 item) => new Variant<T1, T2, T3, T4, T5>(VariantHolder<T5>.T5(item));

        /// <summary>
        /// Implicitly casts from <typeparamref name="T5"/> to variant. Creates a new Variant
        /// inhabited by the given item.
        /// </summary>
        /// <param name="item">Item to store in the variant.</param>
        public static implicit operator Variant<T1, T2, T3, T4, T5>(T5 item) => new Variant<T1, T2, T3, T4, T5>(item);

        /// <summary>
        /// Explicitly casts from variant to <typeparamref name="T5"/>.
        /// </summary>
        /// <param name="variant">Variant to cast to <typeparamref name="T5"/>.</param>
        /// <exception cref="System.InvalidCastException">Thrown if the item inhabiting the variant is not of type <typenameref type="T5"/></exception>
        public static explicit operator T5(Variant<T1, T2, T3, T4, T5> variant) => ((VariantHolder<T5>)variant.variant).Item;

    }
    /// <summary>
    /// Represents a 6-type discriminate union.
    /// </summary>
    /// <typeparam name="T1">Represents the variant's first type.</typeparam>
    /// <typeparam name="T2">Represents the variant's second type.</typeparam>
    /// <typeparam name="T3">Represents the variant's third type.</typeparam>
    /// <typeparam name="T4">Represents the variant's fourth type.</typeparam>
    /// <typeparam name="T5">Represents the variant's fifth type.</typeparam>
    /// <typeparam name="T6">Represents the variant's sixth type.</typeparam>
    public sealed class Variant<T1, T2, T3, T4, T5, T6>
    {
        private readonly IVariantHolder variant;

        /// <summary>
        /// Gets the 0-based index of the type inhabiting the variant.
        /// </summary>
        public int Index => variant.Index;

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
        /// <exception cref="InvalidCastException">Thrown if the item inhabiting the variant is not of type <typenameref type="T"/></exception>
        public T Get<T>() => Is<T>() ? ((VariantHolder<T>)variant).Item : throw new InvalidCastException();

        private Variant(IVariantHolder item) => variant = item;

        /// <summary>
        /// Creates a new Variant instance from an item of type <typeparamref name="T1"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T1"/>.</param>
        public Variant(T1 item) => variant = VariantHolder<T1>.T1(item);

        /// <summary>
        /// Creates a new Variant instance from an item of type <typeparamref name="T2"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T2"/>.</param>
        public Variant(T2 item) => variant = VariantHolder<T2>.T2(item);

        /// <summary>
        /// Creates a new Variant instance from an item of type <typeparamref name="T3"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T3"/>.</param>
        public Variant(T3 item) => variant = VariantHolder<T3>.T3(item);

        /// <summary>
        /// Creates a new Variant instance from an item of type <typeparamref name="T4"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T4"/>.</param>
        public Variant(T4 item) => variant = VariantHolder<T4>.T4(item);

        /// <summary>
        /// Creates a new Variant instance from an item of type <typeparamref name="T5"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T5"/>.</param>
        public Variant(T5 item) => variant = VariantHolder<T5>.T5(item);

        /// <summary>
        /// Creates a new Variant instance from an item of type <typeparamref name="T6"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T6"/>.</param>
        public Variant(T6 item) => variant = VariantHolder<T6>.T6(item);

        /// <summary>
        /// Determines whether the specified object is equal to the current object.
        /// </summary>
        /// <param name="obj">The object to compare with the current object.</param>
        /// <returns>True if the objects are equal.</returns>
        public override bool Equals(object obj)
        {
            if (obj == null) return false;

            if (!(obj is Variant<T1, T2, T3, T4, T5, T6>)) return base.Equals(obj);

            var other = (Variant<T1, T2, T3, T4, T5, T6>)obj;

            switch (Index)
            {
            case 0:
                return other.Is<T1>() && ((VariantHolder<T1>)variant).Item.Equals(((VariantHolder<T1>)other.variant).Item);
            case 1:
                return other.Is<T2>() && ((VariantHolder<T2>)variant).Item.Equals(((VariantHolder<T2>)other.variant).Item);
            case 2:
                return other.Is<T3>() && ((VariantHolder<T3>)variant).Item.Equals(((VariantHolder<T3>)other.variant).Item);
            case 3:
                return other.Is<T4>() && ((VariantHolder<T4>)variant).Item.Equals(((VariantHolder<T4>)other.variant).Item);
            case 4:
                return other.Is<T5>() && ((VariantHolder<T5>)variant).Item.Equals(((VariantHolder<T5>)other.variant).Item);
            case 5:
                return other.Is<T6>() && ((VariantHolder<T6>)variant).Item.Equals(((VariantHolder<T6>)other.variant).Item);
            }

            Debug.Fail("Not reached");
            return false; 
        }

        /// <summary>
        /// Creates a new Variant explicitly placing the item as the first type
        /// (<typeparamref name="T1"/>).
        /// </summary>
        /// <param name="item">Item to place in the variant.</param>
        /// <returns>New Variant instance.</returns>
        /// <remarks>Use this method when the variant contains multiple instances of the same type. This
        /// allows explicit placing of the item.</remarks>
        public static Variant<T1, T2, T3, T4, T5, T6> Make1(T1 item) => new Variant<T1, T2, T3, T4, T5, T6>(VariantHolder<T1>.T1(item));

        /// <summary>
        /// Implicitly casts from <typeparamref name="T1"/> to variant. Creates a new Variant
        /// inhabited by the given item.
        /// </summary>
        /// <param name="item">Item to store in the variant.</param>
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6>(T1 item) => new Variant<T1, T2, T3, T4, T5, T6>(item);

        /// <summary>
        /// Explicitly casts from variant to <typeparamref name="T1"/>.
        /// </summary>
        /// <param name="variant">Variant to cast to <typeparamref name="T1"/>.</param>
        /// <exception cref="System.InvalidCastException">Thrown if the item inhabiting the variant is not of type <typenameref type="T1"/></exception>
        public static explicit operator T1(Variant<T1, T2, T3, T4, T5, T6> variant) => ((VariantHolder<T1>)variant.variant).Item;

        /// <summary>
        /// Creates a new Variant explicitly placing the item as the second type
        /// (<typeparamref name="T2"/>).
        /// </summary>
        /// <param name="item">Item to place in the variant.</param>
        /// <returns>New Variant instance.</returns>
        /// <remarks>Use this method when the variant contains multiple instances of the same type. This
        /// allows explicit placing of the item.</remarks>
        public static Variant<T1, T2, T3, T4, T5, T6> Make2(T2 item) => new Variant<T1, T2, T3, T4, T5, T6>(VariantHolder<T2>.T2(item));

        /// <summary>
        /// Implicitly casts from <typeparamref name="T2"/> to variant. Creates a new Variant
        /// inhabited by the given item.
        /// </summary>
        /// <param name="item">Item to store in the variant.</param>
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6>(T2 item) => new Variant<T1, T2, T3, T4, T5, T6>(item);

        /// <summary>
        /// Explicitly casts from variant to <typeparamref name="T2"/>.
        /// </summary>
        /// <param name="variant">Variant to cast to <typeparamref name="T2"/>.</param>
        /// <exception cref="System.InvalidCastException">Thrown if the item inhabiting the variant is not of type <typenameref type="T2"/></exception>
        public static explicit operator T2(Variant<T1, T2, T3, T4, T5, T6> variant) => ((VariantHolder<T2>)variant.variant).Item;

        /// <summary>
        /// Creates a new Variant explicitly placing the item as the third type
        /// (<typeparamref name="T3"/>).
        /// </summary>
        /// <param name="item">Item to place in the variant.</param>
        /// <returns>New Variant instance.</returns>
        /// <remarks>Use this method when the variant contains multiple instances of the same type. This
        /// allows explicit placing of the item.</remarks>
        public static Variant<T1, T2, T3, T4, T5, T6> Make3(T3 item) => new Variant<T1, T2, T3, T4, T5, T6>(VariantHolder<T3>.T3(item));

        /// <summary>
        /// Implicitly casts from <typeparamref name="T3"/> to variant. Creates a new Variant
        /// inhabited by the given item.
        /// </summary>
        /// <param name="item">Item to store in the variant.</param>
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6>(T3 item) => new Variant<T1, T2, T3, T4, T5, T6>(item);

        /// <summary>
        /// Explicitly casts from variant to <typeparamref name="T3"/>.
        /// </summary>
        /// <param name="variant">Variant to cast to <typeparamref name="T3"/>.</param>
        /// <exception cref="System.InvalidCastException">Thrown if the item inhabiting the variant is not of type <typenameref type="T3"/></exception>
        public static explicit operator T3(Variant<T1, T2, T3, T4, T5, T6> variant) => ((VariantHolder<T3>)variant.variant).Item;

        /// <summary>
        /// Creates a new Variant explicitly placing the item as the fourth type
        /// (<typeparamref name="T4"/>).
        /// </summary>
        /// <param name="item">Item to place in the variant.</param>
        /// <returns>New Variant instance.</returns>
        /// <remarks>Use this method when the variant contains multiple instances of the same type. This
        /// allows explicit placing of the item.</remarks>
        public static Variant<T1, T2, T3, T4, T5, T6> Make4(T4 item) => new Variant<T1, T2, T3, T4, T5, T6>(VariantHolder<T4>.T4(item));

        /// <summary>
        /// Implicitly casts from <typeparamref name="T4"/> to variant. Creates a new Variant
        /// inhabited by the given item.
        /// </summary>
        /// <param name="item">Item to store in the variant.</param>
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6>(T4 item) => new Variant<T1, T2, T3, T4, T5, T6>(item);

        /// <summary>
        /// Explicitly casts from variant to <typeparamref name="T4"/>.
        /// </summary>
        /// <param name="variant">Variant to cast to <typeparamref name="T4"/>.</param>
        /// <exception cref="System.InvalidCastException">Thrown if the item inhabiting the variant is not of type <typenameref type="T4"/></exception>
        public static explicit operator T4(Variant<T1, T2, T3, T4, T5, T6> variant) => ((VariantHolder<T4>)variant.variant).Item;

        /// <summary>
        /// Creates a new Variant explicitly placing the item as the fifth type
        /// (<typeparamref name="T5"/>).
        /// </summary>
        /// <param name="item">Item to place in the variant.</param>
        /// <returns>New Variant instance.</returns>
        /// <remarks>Use this method when the variant contains multiple instances of the same type. This
        /// allows explicit placing of the item.</remarks>
        public static Variant<T1, T2, T3, T4, T5, T6> Make5(T5 item) => new Variant<T1, T2, T3, T4, T5, T6>(VariantHolder<T5>.T5(item));

        /// <summary>
        /// Implicitly casts from <typeparamref name="T5"/> to variant. Creates a new Variant
        /// inhabited by the given item.
        /// </summary>
        /// <param name="item">Item to store in the variant.</param>
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6>(T5 item) => new Variant<T1, T2, T3, T4, T5, T6>(item);

        /// <summary>
        /// Explicitly casts from variant to <typeparamref name="T5"/>.
        /// </summary>
        /// <param name="variant">Variant to cast to <typeparamref name="T5"/>.</param>
        /// <exception cref="System.InvalidCastException">Thrown if the item inhabiting the variant is not of type <typenameref type="T5"/></exception>
        public static explicit operator T5(Variant<T1, T2, T3, T4, T5, T6> variant) => ((VariantHolder<T5>)variant.variant).Item;

        /// <summary>
        /// Creates a new Variant explicitly placing the item as the sixth type
        /// (<typeparamref name="T6"/>).
        /// </summary>
        /// <param name="item">Item to place in the variant.</param>
        /// <returns>New Variant instance.</returns>
        /// <remarks>Use this method when the variant contains multiple instances of the same type. This
        /// allows explicit placing of the item.</remarks>
        public static Variant<T1, T2, T3, T4, T5, T6> Make6(T6 item) => new Variant<T1, T2, T3, T4, T5, T6>(VariantHolder<T6>.T6(item));

        /// <summary>
        /// Implicitly casts from <typeparamref name="T6"/> to variant. Creates a new Variant
        /// inhabited by the given item.
        /// </summary>
        /// <param name="item">Item to store in the variant.</param>
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6>(T6 item) => new Variant<T1, T2, T3, T4, T5, T6>(item);

        /// <summary>
        /// Explicitly casts from variant to <typeparamref name="T6"/>.
        /// </summary>
        /// <param name="variant">Variant to cast to <typeparamref name="T6"/>.</param>
        /// <exception cref="System.InvalidCastException">Thrown if the item inhabiting the variant is not of type <typenameref type="T6"/></exception>
        public static explicit operator T6(Variant<T1, T2, T3, T4, T5, T6> variant) => ((VariantHolder<T6>)variant.variant).Item;

    }
    /// <summary>
    /// Represents a 7-type discriminate union.
    /// </summary>
    /// <typeparam name="T1">Represents the variant's first type.</typeparam>
    /// <typeparam name="T2">Represents the variant's second type.</typeparam>
    /// <typeparam name="T3">Represents the variant's third type.</typeparam>
    /// <typeparam name="T4">Represents the variant's fourth type.</typeparam>
    /// <typeparam name="T5">Represents the variant's fifth type.</typeparam>
    /// <typeparam name="T6">Represents the variant's sixth type.</typeparam>
    /// <typeparam name="T7">Represents the variant's seventh type.</typeparam>
    public sealed class Variant<T1, T2, T3, T4, T5, T6, T7>
    {
        private readonly IVariantHolder variant;

        /// <summary>
        /// Gets the 0-based index of the type inhabiting the variant.
        /// </summary>
        public int Index => variant.Index;

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
        /// <exception cref="InvalidCastException">Thrown if the item inhabiting the variant is not of type <typenameref type="T"/></exception>
        public T Get<T>() => Is<T>() ? ((VariantHolder<T>)variant).Item : throw new InvalidCastException();

        private Variant(IVariantHolder item) => variant = item;

        /// <summary>
        /// Creates a new Variant instance from an item of type <typeparamref name="T1"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T1"/>.</param>
        public Variant(T1 item) => variant = VariantHolder<T1>.T1(item);

        /// <summary>
        /// Creates a new Variant instance from an item of type <typeparamref name="T2"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T2"/>.</param>
        public Variant(T2 item) => variant = VariantHolder<T2>.T2(item);

        /// <summary>
        /// Creates a new Variant instance from an item of type <typeparamref name="T3"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T3"/>.</param>
        public Variant(T3 item) => variant = VariantHolder<T3>.T3(item);

        /// <summary>
        /// Creates a new Variant instance from an item of type <typeparamref name="T4"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T4"/>.</param>
        public Variant(T4 item) => variant = VariantHolder<T4>.T4(item);

        /// <summary>
        /// Creates a new Variant instance from an item of type <typeparamref name="T5"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T5"/>.</param>
        public Variant(T5 item) => variant = VariantHolder<T5>.T5(item);

        /// <summary>
        /// Creates a new Variant instance from an item of type <typeparamref name="T6"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T6"/>.</param>
        public Variant(T6 item) => variant = VariantHolder<T6>.T6(item);

        /// <summary>
        /// Creates a new Variant instance from an item of type <typeparamref name="T7"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T7"/>.</param>
        public Variant(T7 item) => variant = VariantHolder<T7>.T7(item);

        /// <summary>
        /// Determines whether the specified object is equal to the current object.
        /// </summary>
        /// <param name="obj">The object to compare with the current object.</param>
        /// <returns>True if the objects are equal.</returns>
        public override bool Equals(object obj)
        {
            if (obj == null) return false;

            if (!(obj is Variant<T1, T2, T3, T4, T5, T6, T7>)) return base.Equals(obj);

            var other = (Variant<T1, T2, T3, T4, T5, T6, T7>)obj;

            switch (Index)
            {
            case 0:
                return other.Is<T1>() && ((VariantHolder<T1>)variant).Item.Equals(((VariantHolder<T1>)other.variant).Item);
            case 1:
                return other.Is<T2>() && ((VariantHolder<T2>)variant).Item.Equals(((VariantHolder<T2>)other.variant).Item);
            case 2:
                return other.Is<T3>() && ((VariantHolder<T3>)variant).Item.Equals(((VariantHolder<T3>)other.variant).Item);
            case 3:
                return other.Is<T4>() && ((VariantHolder<T4>)variant).Item.Equals(((VariantHolder<T4>)other.variant).Item);
            case 4:
                return other.Is<T5>() && ((VariantHolder<T5>)variant).Item.Equals(((VariantHolder<T5>)other.variant).Item);
            case 5:
                return other.Is<T6>() && ((VariantHolder<T6>)variant).Item.Equals(((VariantHolder<T6>)other.variant).Item);
            case 6:
                return other.Is<T7>() && ((VariantHolder<T7>)variant).Item.Equals(((VariantHolder<T7>)other.variant).Item);
            }

            Debug.Fail("Not reached");
            return false; 
        }

        /// <summary>
        /// Creates a new Variant explicitly placing the item as the first type
        /// (<typeparamref name="T1"/>).
        /// </summary>
        /// <param name="item">Item to place in the variant.</param>
        /// <returns>New Variant instance.</returns>
        /// <remarks>Use this method when the variant contains multiple instances of the same type. This
        /// allows explicit placing of the item.</remarks>
        public static Variant<T1, T2, T3, T4, T5, T6, T7> Make1(T1 item) => new Variant<T1, T2, T3, T4, T5, T6, T7>(VariantHolder<T1>.T1(item));

        /// <summary>
        /// Implicitly casts from <typeparamref name="T1"/> to variant. Creates a new Variant
        /// inhabited by the given item.
        /// </summary>
        /// <param name="item">Item to store in the variant.</param>
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7>(T1 item) => new Variant<T1, T2, T3, T4, T5, T6, T7>(item);

        /// <summary>
        /// Explicitly casts from variant to <typeparamref name="T1"/>.
        /// </summary>
        /// <param name="variant">Variant to cast to <typeparamref name="T1"/>.</param>
        /// <exception cref="System.InvalidCastException">Thrown if the item inhabiting the variant is not of type <typenameref type="T1"/></exception>
        public static explicit operator T1(Variant<T1, T2, T3, T4, T5, T6, T7> variant) => ((VariantHolder<T1>)variant.variant).Item;

        /// <summary>
        /// Creates a new Variant explicitly placing the item as the second type
        /// (<typeparamref name="T2"/>).
        /// </summary>
        /// <param name="item">Item to place in the variant.</param>
        /// <returns>New Variant instance.</returns>
        /// <remarks>Use this method when the variant contains multiple instances of the same type. This
        /// allows explicit placing of the item.</remarks>
        public static Variant<T1, T2, T3, T4, T5, T6, T7> Make2(T2 item) => new Variant<T1, T2, T3, T4, T5, T6, T7>(VariantHolder<T2>.T2(item));

        /// <summary>
        /// Implicitly casts from <typeparamref name="T2"/> to variant. Creates a new Variant
        /// inhabited by the given item.
        /// </summary>
        /// <param name="item">Item to store in the variant.</param>
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7>(T2 item) => new Variant<T1, T2, T3, T4, T5, T6, T7>(item);

        /// <summary>
        /// Explicitly casts from variant to <typeparamref name="T2"/>.
        /// </summary>
        /// <param name="variant">Variant to cast to <typeparamref name="T2"/>.</param>
        /// <exception cref="System.InvalidCastException">Thrown if the item inhabiting the variant is not of type <typenameref type="T2"/></exception>
        public static explicit operator T2(Variant<T1, T2, T3, T4, T5, T6, T7> variant) => ((VariantHolder<T2>)variant.variant).Item;

        /// <summary>
        /// Creates a new Variant explicitly placing the item as the third type
        /// (<typeparamref name="T3"/>).
        /// </summary>
        /// <param name="item">Item to place in the variant.</param>
        /// <returns>New Variant instance.</returns>
        /// <remarks>Use this method when the variant contains multiple instances of the same type. This
        /// allows explicit placing of the item.</remarks>
        public static Variant<T1, T2, T3, T4, T5, T6, T7> Make3(T3 item) => new Variant<T1, T2, T3, T4, T5, T6, T7>(VariantHolder<T3>.T3(item));

        /// <summary>
        /// Implicitly casts from <typeparamref name="T3"/> to variant. Creates a new Variant
        /// inhabited by the given item.
        /// </summary>
        /// <param name="item">Item to store in the variant.</param>
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7>(T3 item) => new Variant<T1, T2, T3, T4, T5, T6, T7>(item);

        /// <summary>
        /// Explicitly casts from variant to <typeparamref name="T3"/>.
        /// </summary>
        /// <param name="variant">Variant to cast to <typeparamref name="T3"/>.</param>
        /// <exception cref="System.InvalidCastException">Thrown if the item inhabiting the variant is not of type <typenameref type="T3"/></exception>
        public static explicit operator T3(Variant<T1, T2, T3, T4, T5, T6, T7> variant) => ((VariantHolder<T3>)variant.variant).Item;

        /// <summary>
        /// Creates a new Variant explicitly placing the item as the fourth type
        /// (<typeparamref name="T4"/>).
        /// </summary>
        /// <param name="item">Item to place in the variant.</param>
        /// <returns>New Variant instance.</returns>
        /// <remarks>Use this method when the variant contains multiple instances of the same type. This
        /// allows explicit placing of the item.</remarks>
        public static Variant<T1, T2, T3, T4, T5, T6, T7> Make4(T4 item) => new Variant<T1, T2, T3, T4, T5, T6, T7>(VariantHolder<T4>.T4(item));

        /// <summary>
        /// Implicitly casts from <typeparamref name="T4"/> to variant. Creates a new Variant
        /// inhabited by the given item.
        /// </summary>
        /// <param name="item">Item to store in the variant.</param>
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7>(T4 item) => new Variant<T1, T2, T3, T4, T5, T6, T7>(item);

        /// <summary>
        /// Explicitly casts from variant to <typeparamref name="T4"/>.
        /// </summary>
        /// <param name="variant">Variant to cast to <typeparamref name="T4"/>.</param>
        /// <exception cref="System.InvalidCastException">Thrown if the item inhabiting the variant is not of type <typenameref type="T4"/></exception>
        public static explicit operator T4(Variant<T1, T2, T3, T4, T5, T6, T7> variant) => ((VariantHolder<T4>)variant.variant).Item;

        /// <summary>
        /// Creates a new Variant explicitly placing the item as the fifth type
        /// (<typeparamref name="T5"/>).
        /// </summary>
        /// <param name="item">Item to place in the variant.</param>
        /// <returns>New Variant instance.</returns>
        /// <remarks>Use this method when the variant contains multiple instances of the same type. This
        /// allows explicit placing of the item.</remarks>
        public static Variant<T1, T2, T3, T4, T5, T6, T7> Make5(T5 item) => new Variant<T1, T2, T3, T4, T5, T6, T7>(VariantHolder<T5>.T5(item));

        /// <summary>
        /// Implicitly casts from <typeparamref name="T5"/> to variant. Creates a new Variant
        /// inhabited by the given item.
        /// </summary>
        /// <param name="item">Item to store in the variant.</param>
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7>(T5 item) => new Variant<T1, T2, T3, T4, T5, T6, T7>(item);

        /// <summary>
        /// Explicitly casts from variant to <typeparamref name="T5"/>.
        /// </summary>
        /// <param name="variant">Variant to cast to <typeparamref name="T5"/>.</param>
        /// <exception cref="System.InvalidCastException">Thrown if the item inhabiting the variant is not of type <typenameref type="T5"/></exception>
        public static explicit operator T5(Variant<T1, T2, T3, T4, T5, T6, T7> variant) => ((VariantHolder<T5>)variant.variant).Item;

        /// <summary>
        /// Creates a new Variant explicitly placing the item as the sixth type
        /// (<typeparamref name="T6"/>).
        /// </summary>
        /// <param name="item">Item to place in the variant.</param>
        /// <returns>New Variant instance.</returns>
        /// <remarks>Use this method when the variant contains multiple instances of the same type. This
        /// allows explicit placing of the item.</remarks>
        public static Variant<T1, T2, T3, T4, T5, T6, T7> Make6(T6 item) => new Variant<T1, T2, T3, T4, T5, T6, T7>(VariantHolder<T6>.T6(item));

        /// <summary>
        /// Implicitly casts from <typeparamref name="T6"/> to variant. Creates a new Variant
        /// inhabited by the given item.
        /// </summary>
        /// <param name="item">Item to store in the variant.</param>
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7>(T6 item) => new Variant<T1, T2, T3, T4, T5, T6, T7>(item);

        /// <summary>
        /// Explicitly casts from variant to <typeparamref name="T6"/>.
        /// </summary>
        /// <param name="variant">Variant to cast to <typeparamref name="T6"/>.</param>
        /// <exception cref="System.InvalidCastException">Thrown if the item inhabiting the variant is not of type <typenameref type="T6"/></exception>
        public static explicit operator T6(Variant<T1, T2, T3, T4, T5, T6, T7> variant) => ((VariantHolder<T6>)variant.variant).Item;

        /// <summary>
        /// Creates a new Variant explicitly placing the item as the seventh type
        /// (<typeparamref name="T7"/>).
        /// </summary>
        /// <param name="item">Item to place in the variant.</param>
        /// <returns>New Variant instance.</returns>
        /// <remarks>Use this method when the variant contains multiple instances of the same type. This
        /// allows explicit placing of the item.</remarks>
        public static Variant<T1, T2, T3, T4, T5, T6, T7> Make7(T7 item) => new Variant<T1, T2, T3, T4, T5, T6, T7>(VariantHolder<T7>.T7(item));

        /// <summary>
        /// Implicitly casts from <typeparamref name="T7"/> to variant. Creates a new Variant
        /// inhabited by the given item.
        /// </summary>
        /// <param name="item">Item to store in the variant.</param>
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7>(T7 item) => new Variant<T1, T2, T3, T4, T5, T6, T7>(item);

        /// <summary>
        /// Explicitly casts from variant to <typeparamref name="T7"/>.
        /// </summary>
        /// <param name="variant">Variant to cast to <typeparamref name="T7"/>.</param>
        /// <exception cref="System.InvalidCastException">Thrown if the item inhabiting the variant is not of type <typenameref type="T7"/></exception>
        public static explicit operator T7(Variant<T1, T2, T3, T4, T5, T6, T7> variant) => ((VariantHolder<T7>)variant.variant).Item;

    }
    /// <summary>
    /// Represents a 8-type discriminate union.
    /// </summary>
    /// <typeparam name="T1">Represents the variant's first type.</typeparam>
    /// <typeparam name="T2">Represents the variant's second type.</typeparam>
    /// <typeparam name="T3">Represents the variant's third type.</typeparam>
    /// <typeparam name="T4">Represents the variant's fourth type.</typeparam>
    /// <typeparam name="T5">Represents the variant's fifth type.</typeparam>
    /// <typeparam name="T6">Represents the variant's sixth type.</typeparam>
    /// <typeparam name="T7">Represents the variant's seventh type.</typeparam>
    /// <typeparam name="T8">Represents the variant's eighth type.</typeparam>
    public sealed class Variant<T1, T2, T3, T4, T5, T6, T7, T8>
    {
        private readonly IVariantHolder variant;

        /// <summary>
        /// Gets the 0-based index of the type inhabiting the variant.
        /// </summary>
        public int Index => variant.Index;

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
        /// <exception cref="InvalidCastException">Thrown if the item inhabiting the variant is not of type <typenameref type="T"/></exception>
        public T Get<T>() => Is<T>() ? ((VariantHolder<T>)variant).Item : throw new InvalidCastException();

        private Variant(IVariantHolder item) => variant = item;

        /// <summary>
        /// Creates a new Variant instance from an item of type <typeparamref name="T1"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T1"/>.</param>
        public Variant(T1 item) => variant = VariantHolder<T1>.T1(item);

        /// <summary>
        /// Creates a new Variant instance from an item of type <typeparamref name="T2"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T2"/>.</param>
        public Variant(T2 item) => variant = VariantHolder<T2>.T2(item);

        /// <summary>
        /// Creates a new Variant instance from an item of type <typeparamref name="T3"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T3"/>.</param>
        public Variant(T3 item) => variant = VariantHolder<T3>.T3(item);

        /// <summary>
        /// Creates a new Variant instance from an item of type <typeparamref name="T4"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T4"/>.</param>
        public Variant(T4 item) => variant = VariantHolder<T4>.T4(item);

        /// <summary>
        /// Creates a new Variant instance from an item of type <typeparamref name="T5"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T5"/>.</param>
        public Variant(T5 item) => variant = VariantHolder<T5>.T5(item);

        /// <summary>
        /// Creates a new Variant instance from an item of type <typeparamref name="T6"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T6"/>.</param>
        public Variant(T6 item) => variant = VariantHolder<T6>.T6(item);

        /// <summary>
        /// Creates a new Variant instance from an item of type <typeparamref name="T7"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T7"/>.</param>
        public Variant(T7 item) => variant = VariantHolder<T7>.T7(item);

        /// <summary>
        /// Creates a new Variant instance from an item of type <typeparamref name="T8"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T8"/>.</param>
        public Variant(T8 item) => variant = VariantHolder<T8>.T8(item);

        /// <summary>
        /// Determines whether the specified object is equal to the current object.
        /// </summary>
        /// <param name="obj">The object to compare with the current object.</param>
        /// <returns>True if the objects are equal.</returns>
        public override bool Equals(object obj)
        {
            if (obj == null) return false;

            if (!(obj is Variant<T1, T2, T3, T4, T5, T6, T7, T8>)) return base.Equals(obj);

            var other = (Variant<T1, T2, T3, T4, T5, T6, T7, T8>)obj;

            switch (Index)
            {
            case 0:
                return other.Is<T1>() && ((VariantHolder<T1>)variant).Item.Equals(((VariantHolder<T1>)other.variant).Item);
            case 1:
                return other.Is<T2>() && ((VariantHolder<T2>)variant).Item.Equals(((VariantHolder<T2>)other.variant).Item);
            case 2:
                return other.Is<T3>() && ((VariantHolder<T3>)variant).Item.Equals(((VariantHolder<T3>)other.variant).Item);
            case 3:
                return other.Is<T4>() && ((VariantHolder<T4>)variant).Item.Equals(((VariantHolder<T4>)other.variant).Item);
            case 4:
                return other.Is<T5>() && ((VariantHolder<T5>)variant).Item.Equals(((VariantHolder<T5>)other.variant).Item);
            case 5:
                return other.Is<T6>() && ((VariantHolder<T6>)variant).Item.Equals(((VariantHolder<T6>)other.variant).Item);
            case 6:
                return other.Is<T7>() && ((VariantHolder<T7>)variant).Item.Equals(((VariantHolder<T7>)other.variant).Item);
            case 7:
                return other.Is<T8>() && ((VariantHolder<T8>)variant).Item.Equals(((VariantHolder<T8>)other.variant).Item);
            }

            Debug.Fail("Not reached");
            return false; 
        }

        /// <summary>
        /// Creates a new Variant explicitly placing the item as the first type
        /// (<typeparamref name="T1"/>).
        /// </summary>
        /// <param name="item">Item to place in the variant.</param>
        /// <returns>New Variant instance.</returns>
        /// <remarks>Use this method when the variant contains multiple instances of the same type. This
        /// allows explicit placing of the item.</remarks>
        public static Variant<T1, T2, T3, T4, T5, T6, T7, T8> Make1(T1 item) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8>(VariantHolder<T1>.T1(item));

        /// <summary>
        /// Implicitly casts from <typeparamref name="T1"/> to variant. Creates a new Variant
        /// inhabited by the given item.
        /// </summary>
        /// <param name="item">Item to store in the variant.</param>
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8>(T1 item) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8>(item);

        /// <summary>
        /// Explicitly casts from variant to <typeparamref name="T1"/>.
        /// </summary>
        /// <param name="variant">Variant to cast to <typeparamref name="T1"/>.</param>
        /// <exception cref="System.InvalidCastException">Thrown if the item inhabiting the variant is not of type <typenameref type="T1"/></exception>
        public static explicit operator T1(Variant<T1, T2, T3, T4, T5, T6, T7, T8> variant) => ((VariantHolder<T1>)variant.variant).Item;

        /// <summary>
        /// Creates a new Variant explicitly placing the item as the second type
        /// (<typeparamref name="T2"/>).
        /// </summary>
        /// <param name="item">Item to place in the variant.</param>
        /// <returns>New Variant instance.</returns>
        /// <remarks>Use this method when the variant contains multiple instances of the same type. This
        /// allows explicit placing of the item.</remarks>
        public static Variant<T1, T2, T3, T4, T5, T6, T7, T8> Make2(T2 item) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8>(VariantHolder<T2>.T2(item));

        /// <summary>
        /// Implicitly casts from <typeparamref name="T2"/> to variant. Creates a new Variant
        /// inhabited by the given item.
        /// </summary>
        /// <param name="item">Item to store in the variant.</param>
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8>(T2 item) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8>(item);

        /// <summary>
        /// Explicitly casts from variant to <typeparamref name="T2"/>.
        /// </summary>
        /// <param name="variant">Variant to cast to <typeparamref name="T2"/>.</param>
        /// <exception cref="System.InvalidCastException">Thrown if the item inhabiting the variant is not of type <typenameref type="T2"/></exception>
        public static explicit operator T2(Variant<T1, T2, T3, T4, T5, T6, T7, T8> variant) => ((VariantHolder<T2>)variant.variant).Item;

        /// <summary>
        /// Creates a new Variant explicitly placing the item as the third type
        /// (<typeparamref name="T3"/>).
        /// </summary>
        /// <param name="item">Item to place in the variant.</param>
        /// <returns>New Variant instance.</returns>
        /// <remarks>Use this method when the variant contains multiple instances of the same type. This
        /// allows explicit placing of the item.</remarks>
        public static Variant<T1, T2, T3, T4, T5, T6, T7, T8> Make3(T3 item) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8>(VariantHolder<T3>.T3(item));

        /// <summary>
        /// Implicitly casts from <typeparamref name="T3"/> to variant. Creates a new Variant
        /// inhabited by the given item.
        /// </summary>
        /// <param name="item">Item to store in the variant.</param>
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8>(T3 item) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8>(item);

        /// <summary>
        /// Explicitly casts from variant to <typeparamref name="T3"/>.
        /// </summary>
        /// <param name="variant">Variant to cast to <typeparamref name="T3"/>.</param>
        /// <exception cref="System.InvalidCastException">Thrown if the item inhabiting the variant is not of type <typenameref type="T3"/></exception>
        public static explicit operator T3(Variant<T1, T2, T3, T4, T5, T6, T7, T8> variant) => ((VariantHolder<T3>)variant.variant).Item;

        /// <summary>
        /// Creates a new Variant explicitly placing the item as the fourth type
        /// (<typeparamref name="T4"/>).
        /// </summary>
        /// <param name="item">Item to place in the variant.</param>
        /// <returns>New Variant instance.</returns>
        /// <remarks>Use this method when the variant contains multiple instances of the same type. This
        /// allows explicit placing of the item.</remarks>
        public static Variant<T1, T2, T3, T4, T5, T6, T7, T8> Make4(T4 item) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8>(VariantHolder<T4>.T4(item));

        /// <summary>
        /// Implicitly casts from <typeparamref name="T4"/> to variant. Creates a new Variant
        /// inhabited by the given item.
        /// </summary>
        /// <param name="item">Item to store in the variant.</param>
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8>(T4 item) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8>(item);

        /// <summary>
        /// Explicitly casts from variant to <typeparamref name="T4"/>.
        /// </summary>
        /// <param name="variant">Variant to cast to <typeparamref name="T4"/>.</param>
        /// <exception cref="System.InvalidCastException">Thrown if the item inhabiting the variant is not of type <typenameref type="T4"/></exception>
        public static explicit operator T4(Variant<T1, T2, T3, T4, T5, T6, T7, T8> variant) => ((VariantHolder<T4>)variant.variant).Item;

        /// <summary>
        /// Creates a new Variant explicitly placing the item as the fifth type
        /// (<typeparamref name="T5"/>).
        /// </summary>
        /// <param name="item">Item to place in the variant.</param>
        /// <returns>New Variant instance.</returns>
        /// <remarks>Use this method when the variant contains multiple instances of the same type. This
        /// allows explicit placing of the item.</remarks>
        public static Variant<T1, T2, T3, T4, T5, T6, T7, T8> Make5(T5 item) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8>(VariantHolder<T5>.T5(item));

        /// <summary>
        /// Implicitly casts from <typeparamref name="T5"/> to variant. Creates a new Variant
        /// inhabited by the given item.
        /// </summary>
        /// <param name="item">Item to store in the variant.</param>
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8>(T5 item) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8>(item);

        /// <summary>
        /// Explicitly casts from variant to <typeparamref name="T5"/>.
        /// </summary>
        /// <param name="variant">Variant to cast to <typeparamref name="T5"/>.</param>
        /// <exception cref="System.InvalidCastException">Thrown if the item inhabiting the variant is not of type <typenameref type="T5"/></exception>
        public static explicit operator T5(Variant<T1, T2, T3, T4, T5, T6, T7, T8> variant) => ((VariantHolder<T5>)variant.variant).Item;

        /// <summary>
        /// Creates a new Variant explicitly placing the item as the sixth type
        /// (<typeparamref name="T6"/>).
        /// </summary>
        /// <param name="item">Item to place in the variant.</param>
        /// <returns>New Variant instance.</returns>
        /// <remarks>Use this method when the variant contains multiple instances of the same type. This
        /// allows explicit placing of the item.</remarks>
        public static Variant<T1, T2, T3, T4, T5, T6, T7, T8> Make6(T6 item) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8>(VariantHolder<T6>.T6(item));

        /// <summary>
        /// Implicitly casts from <typeparamref name="T6"/> to variant. Creates a new Variant
        /// inhabited by the given item.
        /// </summary>
        /// <param name="item">Item to store in the variant.</param>
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8>(T6 item) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8>(item);

        /// <summary>
        /// Explicitly casts from variant to <typeparamref name="T6"/>.
        /// </summary>
        /// <param name="variant">Variant to cast to <typeparamref name="T6"/>.</param>
        /// <exception cref="System.InvalidCastException">Thrown if the item inhabiting the variant is not of type <typenameref type="T6"/></exception>
        public static explicit operator T6(Variant<T1, T2, T3, T4, T5, T6, T7, T8> variant) => ((VariantHolder<T6>)variant.variant).Item;

        /// <summary>
        /// Creates a new Variant explicitly placing the item as the seventh type
        /// (<typeparamref name="T7"/>).
        /// </summary>
        /// <param name="item">Item to place in the variant.</param>
        /// <returns>New Variant instance.</returns>
        /// <remarks>Use this method when the variant contains multiple instances of the same type. This
        /// allows explicit placing of the item.</remarks>
        public static Variant<T1, T2, T3, T4, T5, T6, T7, T8> Make7(T7 item) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8>(VariantHolder<T7>.T7(item));

        /// <summary>
        /// Implicitly casts from <typeparamref name="T7"/> to variant. Creates a new Variant
        /// inhabited by the given item.
        /// </summary>
        /// <param name="item">Item to store in the variant.</param>
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8>(T7 item) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8>(item);

        /// <summary>
        /// Explicitly casts from variant to <typeparamref name="T7"/>.
        /// </summary>
        /// <param name="variant">Variant to cast to <typeparamref name="T7"/>.</param>
        /// <exception cref="System.InvalidCastException">Thrown if the item inhabiting the variant is not of type <typenameref type="T7"/></exception>
        public static explicit operator T7(Variant<T1, T2, T3, T4, T5, T6, T7, T8> variant) => ((VariantHolder<T7>)variant.variant).Item;

        /// <summary>
        /// Creates a new Variant explicitly placing the item as the eighth type
        /// (<typeparamref name="T8"/>).
        /// </summary>
        /// <param name="item">Item to place in the variant.</param>
        /// <returns>New Variant instance.</returns>
        /// <remarks>Use this method when the variant contains multiple instances of the same type. This
        /// allows explicit placing of the item.</remarks>
        public static Variant<T1, T2, T3, T4, T5, T6, T7, T8> Make8(T8 item) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8>(VariantHolder<T8>.T8(item));

        /// <summary>
        /// Implicitly casts from <typeparamref name="T8"/> to variant. Creates a new Variant
        /// inhabited by the given item.
        /// </summary>
        /// <param name="item">Item to store in the variant.</param>
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8>(T8 item) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8>(item);

        /// <summary>
        /// Explicitly casts from variant to <typeparamref name="T8"/>.
        /// </summary>
        /// <param name="variant">Variant to cast to <typeparamref name="T8"/>.</param>
        /// <exception cref="System.InvalidCastException">Thrown if the item inhabiting the variant is not of type <typenameref type="T8"/></exception>
        public static explicit operator T8(Variant<T1, T2, T3, T4, T5, T6, T7, T8> variant) => ((VariantHolder<T8>)variant.variant).Item;

    }
}