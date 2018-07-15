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
    public sealed class Variant<T1, T2> : VariantBase
    {
        private Variant(IVariantHolder item)
            : base(item)
        {}

        /// <summary>
        /// Creates a new Variant instance from an item of type <typeparamref name="T1"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T1"/>.</param>
        public Variant(T1 item)
            : base(VariantHolder<T1>.T1(item))
        {}

        /// <summary>
        /// Creates a new Variant instance from an item of type <typeparamref name="T2"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T2"/>.</param>
        public Variant(T2 item)
            : base(VariantHolder<T2>.T2(item))
        {}

        /// <summary>
        /// Determines whether the specified object is equal to the current object.
        /// </summary>
        /// <param name="obj">The object to compare with the current object.</param>
        /// <returns>True if the objects are equal.</returns>
        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Variant<T1, T2>)) return false;

            var other = (Variant<T1, T2>)obj;

            switch (Index)
            {
            case 0:
                return other.Is<T1>() && Get<T1>().Equals(other.Get<T1>());
            case 1:
                return other.Is<T2>() && Get<T2>().Equals(other.Get<T2>());
            }

            Debug.Fail("Not reached");
            return false; 
        }

        /// <summary>
        /// Returns the hash code for this instance.
        /// </summary>
        /// <returns>Hash code.</returns>
        public override int GetHashCode()
        {
            switch (Index)
            {
            case 0: return Get<T1>().GetHashCode();
            case 1: return Get<T2>().GetHashCode();
            }

            Debug.Fail("Not reached");
            return base.GetHashCode(); 
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
        public static explicit operator T1(Variant<T1, T2> variant) => variant.Get<T1>();

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
        public static explicit operator T2(Variant<T1, T2> variant) => variant.Get<T2>();

    }
    /// <summary>
    /// Represents a 3-type discriminate union.
    /// </summary>
    /// <typeparam name="T1">Represents the variant's first type.</typeparam>
    /// <typeparam name="T2">Represents the variant's second type.</typeparam>
    /// <typeparam name="T3">Represents the variant's third type.</typeparam>
    public sealed class Variant<T1, T2, T3> : VariantBase
    {
        private Variant(IVariantHolder item)
            : base(item)
        {}

        /// <summary>
        /// Creates a new Variant instance from an item of type <typeparamref name="T1"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T1"/>.</param>
        public Variant(T1 item)
            : base(VariantHolder<T1>.T1(item))
        {}

        /// <summary>
        /// Creates a new Variant instance from an item of type <typeparamref name="T2"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T2"/>.</param>
        public Variant(T2 item)
            : base(VariantHolder<T2>.T2(item))
        {}

        /// <summary>
        /// Creates a new Variant instance from an item of type <typeparamref name="T3"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T3"/>.</param>
        public Variant(T3 item)
            : base(VariantHolder<T3>.T3(item))
        {}

        /// <summary>
        /// Determines whether the specified object is equal to the current object.
        /// </summary>
        /// <param name="obj">The object to compare with the current object.</param>
        /// <returns>True if the objects are equal.</returns>
        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Variant<T1, T2, T3>)) return false;

            var other = (Variant<T1, T2, T3>)obj;

            switch (Index)
            {
            case 0:
                return other.Is<T1>() && Get<T1>().Equals(other.Get<T1>());
            case 1:
                return other.Is<T2>() && Get<T2>().Equals(other.Get<T2>());
            case 2:
                return other.Is<T3>() && Get<T3>().Equals(other.Get<T3>());
            }

            Debug.Fail("Not reached");
            return false; 
        }

        /// <summary>
        /// Returns the hash code for this instance.
        /// </summary>
        /// <returns>Hash code.</returns>
        public override int GetHashCode()
        {
            switch (Index)
            {
            case 0: return Get<T1>().GetHashCode();
            case 1: return Get<T2>().GetHashCode();
            case 2: return Get<T3>().GetHashCode();
            }

            Debug.Fail("Not reached");
            return base.GetHashCode(); 
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
        public static explicit operator T1(Variant<T1, T2, T3> variant) => variant.Get<T1>();

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
        public static explicit operator T2(Variant<T1, T2, T3> variant) => variant.Get<T2>();

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
        public static explicit operator T3(Variant<T1, T2, T3> variant) => variant.Get<T3>();

    }
    /// <summary>
    /// Represents a 4-type discriminate union.
    /// </summary>
    /// <typeparam name="T1">Represents the variant's first type.</typeparam>
    /// <typeparam name="T2">Represents the variant's second type.</typeparam>
    /// <typeparam name="T3">Represents the variant's third type.</typeparam>
    /// <typeparam name="T4">Represents the variant's fourth type.</typeparam>
    public sealed class Variant<T1, T2, T3, T4> : VariantBase
    {
        private Variant(IVariantHolder item)
            : base(item)
        {}

        /// <summary>
        /// Creates a new Variant instance from an item of type <typeparamref name="T1"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T1"/>.</param>
        public Variant(T1 item)
            : base(VariantHolder<T1>.T1(item))
        {}

        /// <summary>
        /// Creates a new Variant instance from an item of type <typeparamref name="T2"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T2"/>.</param>
        public Variant(T2 item)
            : base(VariantHolder<T2>.T2(item))
        {}

        /// <summary>
        /// Creates a new Variant instance from an item of type <typeparamref name="T3"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T3"/>.</param>
        public Variant(T3 item)
            : base(VariantHolder<T3>.T3(item))
        {}

        /// <summary>
        /// Creates a new Variant instance from an item of type <typeparamref name="T4"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T4"/>.</param>
        public Variant(T4 item)
            : base(VariantHolder<T4>.T4(item))
        {}

        /// <summary>
        /// Determines whether the specified object is equal to the current object.
        /// </summary>
        /// <param name="obj">The object to compare with the current object.</param>
        /// <returns>True if the objects are equal.</returns>
        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Variant<T1, T2, T3, T4>)) return false;

            var other = (Variant<T1, T2, T3, T4>)obj;

            switch (Index)
            {
            case 0:
                return other.Is<T1>() && Get<T1>().Equals(other.Get<T1>());
            case 1:
                return other.Is<T2>() && Get<T2>().Equals(other.Get<T2>());
            case 2:
                return other.Is<T3>() && Get<T3>().Equals(other.Get<T3>());
            case 3:
                return other.Is<T4>() && Get<T4>().Equals(other.Get<T4>());
            }

            Debug.Fail("Not reached");
            return false; 
        }

        /// <summary>
        /// Returns the hash code for this instance.
        /// </summary>
        /// <returns>Hash code.</returns>
        public override int GetHashCode()
        {
            switch (Index)
            {
            case 0: return Get<T1>().GetHashCode();
            case 1: return Get<T2>().GetHashCode();
            case 2: return Get<T3>().GetHashCode();
            case 3: return Get<T4>().GetHashCode();
            }

            Debug.Fail("Not reached");
            return base.GetHashCode(); 
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
        public static explicit operator T1(Variant<T1, T2, T3, T4> variant) => variant.Get<T1>();

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
        public static explicit operator T2(Variant<T1, T2, T3, T4> variant) => variant.Get<T2>();

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
        public static explicit operator T3(Variant<T1, T2, T3, T4> variant) => variant.Get<T3>();

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
        public static explicit operator T4(Variant<T1, T2, T3, T4> variant) => variant.Get<T4>();

    }
    /// <summary>
    /// Represents a 5-type discriminate union.
    /// </summary>
    /// <typeparam name="T1">Represents the variant's first type.</typeparam>
    /// <typeparam name="T2">Represents the variant's second type.</typeparam>
    /// <typeparam name="T3">Represents the variant's third type.</typeparam>
    /// <typeparam name="T4">Represents the variant's fourth type.</typeparam>
    /// <typeparam name="T5">Represents the variant's fifth type.</typeparam>
    public sealed class Variant<T1, T2, T3, T4, T5> : VariantBase
    {
        private Variant(IVariantHolder item)
            : base(item)
        {}

        /// <summary>
        /// Creates a new Variant instance from an item of type <typeparamref name="T1"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T1"/>.</param>
        public Variant(T1 item)
            : base(VariantHolder<T1>.T1(item))
        {}

        /// <summary>
        /// Creates a new Variant instance from an item of type <typeparamref name="T2"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T2"/>.</param>
        public Variant(T2 item)
            : base(VariantHolder<T2>.T2(item))
        {}

        /// <summary>
        /// Creates a new Variant instance from an item of type <typeparamref name="T3"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T3"/>.</param>
        public Variant(T3 item)
            : base(VariantHolder<T3>.T3(item))
        {}

        /// <summary>
        /// Creates a new Variant instance from an item of type <typeparamref name="T4"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T4"/>.</param>
        public Variant(T4 item)
            : base(VariantHolder<T4>.T4(item))
        {}

        /// <summary>
        /// Creates a new Variant instance from an item of type <typeparamref name="T5"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T5"/>.</param>
        public Variant(T5 item)
            : base(VariantHolder<T5>.T5(item))
        {}

        /// <summary>
        /// Determines whether the specified object is equal to the current object.
        /// </summary>
        /// <param name="obj">The object to compare with the current object.</param>
        /// <returns>True if the objects are equal.</returns>
        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Variant<T1, T2, T3, T4, T5>)) return false;

            var other = (Variant<T1, T2, T3, T4, T5>)obj;

            switch (Index)
            {
            case 0:
                return other.Is<T1>() && Get<T1>().Equals(other.Get<T1>());
            case 1:
                return other.Is<T2>() && Get<T2>().Equals(other.Get<T2>());
            case 2:
                return other.Is<T3>() && Get<T3>().Equals(other.Get<T3>());
            case 3:
                return other.Is<T4>() && Get<T4>().Equals(other.Get<T4>());
            case 4:
                return other.Is<T5>() && Get<T5>().Equals(other.Get<T5>());
            }

            Debug.Fail("Not reached");
            return false; 
        }

        /// <summary>
        /// Returns the hash code for this instance.
        /// </summary>
        /// <returns>Hash code.</returns>
        public override int GetHashCode()
        {
            switch (Index)
            {
            case 0: return Get<T1>().GetHashCode();
            case 1: return Get<T2>().GetHashCode();
            case 2: return Get<T3>().GetHashCode();
            case 3: return Get<T4>().GetHashCode();
            case 4: return Get<T5>().GetHashCode();
            }

            Debug.Fail("Not reached");
            return base.GetHashCode(); 
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
        public static explicit operator T1(Variant<T1, T2, T3, T4, T5> variant) => variant.Get<T1>();

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
        public static explicit operator T2(Variant<T1, T2, T3, T4, T5> variant) => variant.Get<T2>();

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
        public static explicit operator T3(Variant<T1, T2, T3, T4, T5> variant) => variant.Get<T3>();

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
        public static explicit operator T4(Variant<T1, T2, T3, T4, T5> variant) => variant.Get<T4>();

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
        public static explicit operator T5(Variant<T1, T2, T3, T4, T5> variant) => variant.Get<T5>();

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
    public sealed class Variant<T1, T2, T3, T4, T5, T6> : VariantBase
    {
        private Variant(IVariantHolder item)
            : base(item)
        {}

        /// <summary>
        /// Creates a new Variant instance from an item of type <typeparamref name="T1"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T1"/>.</param>
        public Variant(T1 item)
            : base(VariantHolder<T1>.T1(item))
        {}

        /// <summary>
        /// Creates a new Variant instance from an item of type <typeparamref name="T2"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T2"/>.</param>
        public Variant(T2 item)
            : base(VariantHolder<T2>.T2(item))
        {}

        /// <summary>
        /// Creates a new Variant instance from an item of type <typeparamref name="T3"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T3"/>.</param>
        public Variant(T3 item)
            : base(VariantHolder<T3>.T3(item))
        {}

        /// <summary>
        /// Creates a new Variant instance from an item of type <typeparamref name="T4"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T4"/>.</param>
        public Variant(T4 item)
            : base(VariantHolder<T4>.T4(item))
        {}

        /// <summary>
        /// Creates a new Variant instance from an item of type <typeparamref name="T5"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T5"/>.</param>
        public Variant(T5 item)
            : base(VariantHolder<T5>.T5(item))
        {}

        /// <summary>
        /// Creates a new Variant instance from an item of type <typeparamref name="T6"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T6"/>.</param>
        public Variant(T6 item)
            : base(VariantHolder<T6>.T6(item))
        {}

        /// <summary>
        /// Determines whether the specified object is equal to the current object.
        /// </summary>
        /// <param name="obj">The object to compare with the current object.</param>
        /// <returns>True if the objects are equal.</returns>
        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Variant<T1, T2, T3, T4, T5, T6>)) return false;

            var other = (Variant<T1, T2, T3, T4, T5, T6>)obj;

            switch (Index)
            {
            case 0:
                return other.Is<T1>() && Get<T1>().Equals(other.Get<T1>());
            case 1:
                return other.Is<T2>() && Get<T2>().Equals(other.Get<T2>());
            case 2:
                return other.Is<T3>() && Get<T3>().Equals(other.Get<T3>());
            case 3:
                return other.Is<T4>() && Get<T4>().Equals(other.Get<T4>());
            case 4:
                return other.Is<T5>() && Get<T5>().Equals(other.Get<T5>());
            case 5:
                return other.Is<T6>() && Get<T6>().Equals(other.Get<T6>());
            }

            Debug.Fail("Not reached");
            return false; 
        }

        /// <summary>
        /// Returns the hash code for this instance.
        /// </summary>
        /// <returns>Hash code.</returns>
        public override int GetHashCode()
        {
            switch (Index)
            {
            case 0: return Get<T1>().GetHashCode();
            case 1: return Get<T2>().GetHashCode();
            case 2: return Get<T3>().GetHashCode();
            case 3: return Get<T4>().GetHashCode();
            case 4: return Get<T5>().GetHashCode();
            case 5: return Get<T6>().GetHashCode();
            }

            Debug.Fail("Not reached");
            return base.GetHashCode(); 
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
        public static explicit operator T1(Variant<T1, T2, T3, T4, T5, T6> variant) => variant.Get<T1>();

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
        public static explicit operator T2(Variant<T1, T2, T3, T4, T5, T6> variant) => variant.Get<T2>();

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
        public static explicit operator T3(Variant<T1, T2, T3, T4, T5, T6> variant) => variant.Get<T3>();

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
        public static explicit operator T4(Variant<T1, T2, T3, T4, T5, T6> variant) => variant.Get<T4>();

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
        public static explicit operator T5(Variant<T1, T2, T3, T4, T5, T6> variant) => variant.Get<T5>();

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
        public static explicit operator T6(Variant<T1, T2, T3, T4, T5, T6> variant) => variant.Get<T6>();

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
    public sealed class Variant<T1, T2, T3, T4, T5, T6, T7> : VariantBase
    {
        private Variant(IVariantHolder item)
            : base(item)
        {}

        /// <summary>
        /// Creates a new Variant instance from an item of type <typeparamref name="T1"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T1"/>.</param>
        public Variant(T1 item)
            : base(VariantHolder<T1>.T1(item))
        {}

        /// <summary>
        /// Creates a new Variant instance from an item of type <typeparamref name="T2"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T2"/>.</param>
        public Variant(T2 item)
            : base(VariantHolder<T2>.T2(item))
        {}

        /// <summary>
        /// Creates a new Variant instance from an item of type <typeparamref name="T3"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T3"/>.</param>
        public Variant(T3 item)
            : base(VariantHolder<T3>.T3(item))
        {}

        /// <summary>
        /// Creates a new Variant instance from an item of type <typeparamref name="T4"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T4"/>.</param>
        public Variant(T4 item)
            : base(VariantHolder<T4>.T4(item))
        {}

        /// <summary>
        /// Creates a new Variant instance from an item of type <typeparamref name="T5"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T5"/>.</param>
        public Variant(T5 item)
            : base(VariantHolder<T5>.T5(item))
        {}

        /// <summary>
        /// Creates a new Variant instance from an item of type <typeparamref name="T6"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T6"/>.</param>
        public Variant(T6 item)
            : base(VariantHolder<T6>.T6(item))
        {}

        /// <summary>
        /// Creates a new Variant instance from an item of type <typeparamref name="T7"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T7"/>.</param>
        public Variant(T7 item)
            : base(VariantHolder<T7>.T7(item))
        {}

        /// <summary>
        /// Determines whether the specified object is equal to the current object.
        /// </summary>
        /// <param name="obj">The object to compare with the current object.</param>
        /// <returns>True if the objects are equal.</returns>
        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Variant<T1, T2, T3, T4, T5, T6, T7>)) return false;

            var other = (Variant<T1, T2, T3, T4, T5, T6, T7>)obj;

            switch (Index)
            {
            case 0:
                return other.Is<T1>() && Get<T1>().Equals(other.Get<T1>());
            case 1:
                return other.Is<T2>() && Get<T2>().Equals(other.Get<T2>());
            case 2:
                return other.Is<T3>() && Get<T3>().Equals(other.Get<T3>());
            case 3:
                return other.Is<T4>() && Get<T4>().Equals(other.Get<T4>());
            case 4:
                return other.Is<T5>() && Get<T5>().Equals(other.Get<T5>());
            case 5:
                return other.Is<T6>() && Get<T6>().Equals(other.Get<T6>());
            case 6:
                return other.Is<T7>() && Get<T7>().Equals(other.Get<T7>());
            }

            Debug.Fail("Not reached");
            return false; 
        }

        /// <summary>
        /// Returns the hash code for this instance.
        /// </summary>
        /// <returns>Hash code.</returns>
        public override int GetHashCode()
        {
            switch (Index)
            {
            case 0: return Get<T1>().GetHashCode();
            case 1: return Get<T2>().GetHashCode();
            case 2: return Get<T3>().GetHashCode();
            case 3: return Get<T4>().GetHashCode();
            case 4: return Get<T5>().GetHashCode();
            case 5: return Get<T6>().GetHashCode();
            case 6: return Get<T7>().GetHashCode();
            }

            Debug.Fail("Not reached");
            return base.GetHashCode(); 
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
        public static explicit operator T1(Variant<T1, T2, T3, T4, T5, T6, T7> variant) => variant.Get<T1>();

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
        public static explicit operator T2(Variant<T1, T2, T3, T4, T5, T6, T7> variant) => variant.Get<T2>();

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
        public static explicit operator T3(Variant<T1, T2, T3, T4, T5, T6, T7> variant) => variant.Get<T3>();

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
        public static explicit operator T4(Variant<T1, T2, T3, T4, T5, T6, T7> variant) => variant.Get<T4>();

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
        public static explicit operator T5(Variant<T1, T2, T3, T4, T5, T6, T7> variant) => variant.Get<T5>();

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
        public static explicit operator T6(Variant<T1, T2, T3, T4, T5, T6, T7> variant) => variant.Get<T6>();

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
        public static explicit operator T7(Variant<T1, T2, T3, T4, T5, T6, T7> variant) => variant.Get<T7>();

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
    public sealed class Variant<T1, T2, T3, T4, T5, T6, T7, T8> : VariantBase
    {
        private Variant(IVariantHolder item)
            : base(item)
        {}

        /// <summary>
        /// Creates a new Variant instance from an item of type <typeparamref name="T1"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T1"/>.</param>
        public Variant(T1 item)
            : base(VariantHolder<T1>.T1(item))
        {}

        /// <summary>
        /// Creates a new Variant instance from an item of type <typeparamref name="T2"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T2"/>.</param>
        public Variant(T2 item)
            : base(VariantHolder<T2>.T2(item))
        {}

        /// <summary>
        /// Creates a new Variant instance from an item of type <typeparamref name="T3"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T3"/>.</param>
        public Variant(T3 item)
            : base(VariantHolder<T3>.T3(item))
        {}

        /// <summary>
        /// Creates a new Variant instance from an item of type <typeparamref name="T4"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T4"/>.</param>
        public Variant(T4 item)
            : base(VariantHolder<T4>.T4(item))
        {}

        /// <summary>
        /// Creates a new Variant instance from an item of type <typeparamref name="T5"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T5"/>.</param>
        public Variant(T5 item)
            : base(VariantHolder<T5>.T5(item))
        {}

        /// <summary>
        /// Creates a new Variant instance from an item of type <typeparamref name="T6"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T6"/>.</param>
        public Variant(T6 item)
            : base(VariantHolder<T6>.T6(item))
        {}

        /// <summary>
        /// Creates a new Variant instance from an item of type <typeparamref name="T7"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T7"/>.</param>
        public Variant(T7 item)
            : base(VariantHolder<T7>.T7(item))
        {}

        /// <summary>
        /// Creates a new Variant instance from an item of type <typeparamref name="T8"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T8"/>.</param>
        public Variant(T8 item)
            : base(VariantHolder<T8>.T8(item))
        {}

        /// <summary>
        /// Determines whether the specified object is equal to the current object.
        /// </summary>
        /// <param name="obj">The object to compare with the current object.</param>
        /// <returns>True if the objects are equal.</returns>
        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Variant<T1, T2, T3, T4, T5, T6, T7, T8>)) return false;

            var other = (Variant<T1, T2, T3, T4, T5, T6, T7, T8>)obj;

            switch (Index)
            {
            case 0:
                return other.Is<T1>() && Get<T1>().Equals(other.Get<T1>());
            case 1:
                return other.Is<T2>() && Get<T2>().Equals(other.Get<T2>());
            case 2:
                return other.Is<T3>() && Get<T3>().Equals(other.Get<T3>());
            case 3:
                return other.Is<T4>() && Get<T4>().Equals(other.Get<T4>());
            case 4:
                return other.Is<T5>() && Get<T5>().Equals(other.Get<T5>());
            case 5:
                return other.Is<T6>() && Get<T6>().Equals(other.Get<T6>());
            case 6:
                return other.Is<T7>() && Get<T7>().Equals(other.Get<T7>());
            case 7:
                return other.Is<T8>() && Get<T8>().Equals(other.Get<T8>());
            }

            Debug.Fail("Not reached");
            return false; 
        }

        /// <summary>
        /// Returns the hash code for this instance.
        /// </summary>
        /// <returns>Hash code.</returns>
        public override int GetHashCode()
        {
            switch (Index)
            {
            case 0: return Get<T1>().GetHashCode();
            case 1: return Get<T2>().GetHashCode();
            case 2: return Get<T3>().GetHashCode();
            case 3: return Get<T4>().GetHashCode();
            case 4: return Get<T5>().GetHashCode();
            case 5: return Get<T6>().GetHashCode();
            case 6: return Get<T7>().GetHashCode();
            case 7: return Get<T8>().GetHashCode();
            }

            Debug.Fail("Not reached");
            return base.GetHashCode(); 
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
        public static explicit operator T1(Variant<T1, T2, T3, T4, T5, T6, T7, T8> variant) => variant.Get<T1>();

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
        public static explicit operator T2(Variant<T1, T2, T3, T4, T5, T6, T7, T8> variant) => variant.Get<T2>();

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
        public static explicit operator T3(Variant<T1, T2, T3, T4, T5, T6, T7, T8> variant) => variant.Get<T3>();

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
        public static explicit operator T4(Variant<T1, T2, T3, T4, T5, T6, T7, T8> variant) => variant.Get<T4>();

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
        public static explicit operator T5(Variant<T1, T2, T3, T4, T5, T6, T7, T8> variant) => variant.Get<T5>();

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
        public static explicit operator T6(Variant<T1, T2, T3, T4, T5, T6, T7, T8> variant) => variant.Get<T6>();

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
        public static explicit operator T7(Variant<T1, T2, T3, T4, T5, T6, T7, T8> variant) => variant.Get<T7>();

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
        public static explicit operator T8(Variant<T1, T2, T3, T4, T5, T6, T7, T8> variant) => variant.Get<T8>();

    }
}