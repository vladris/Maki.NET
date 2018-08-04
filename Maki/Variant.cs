using Maki.Details;
using System;
using System.Diagnostics;

namespace Maki
{
    /// <summary>
    /// Represents a 1-type discriminate union.
    /// </summary>
    /// <typeparam name="T1">Represents the variant's first type.</typeparam>
    /// <example>
    /// The following example shows how to assign values of different types to a Variant and how to extract
    /// values from it.
    /// <code>
    /// using Maki;
    /// using System;
    /// 
    /// namespace Samples
    /// {
    ///     class Program
    ///     {
    ///         static void Main(string[] args)
    ///         {
    ///             // A variant can hold a value of any of its generic types
    ///             Variant&lt;int, string, double&gt; variant = 42;
    /// 
    ///             // Depending on the type of the value currently inhabiting the variant,
    ///             // the right Action gets executed
    ///             variant.Apply(
    ///                 i =&gt; Console.WriteLine(i * 2),
    ///                 s =&gt; Console.WriteLine(s + &quot;!&quot;),
    ///                 d =&gt; Console.WriteLine($&quot;Double: {d}&quot;)
    ///             );
    /// 
    ///             // Can reassign variant with another of its generic types
    ///             variant = &quot;Hello world&quot;;
    /// 
    ///             // Check the type of the value currently inhabiting the variant
    ///             if (variant.Is&lt;string&gt;())
    ///             {
    ///                 // Extract a string from the variant
    ///                 Console.WriteLine($&quot;The string is: {variant.Get&lt;string&gt;()}&quot;);
    ///             }
    ///         }
    ///     }
    /// }
    /// </code>
    /// </example>
    public sealed class Variant<T1> : VariantBase
    {
        private Variant(IVariantHolder item, byte index)
            : base(item, index)
        { }

        /// <summary>
        /// Creates a new Variant instance from an item of type <typeparamref name="T1"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T1"/>.</param>
        public Variant(T1 item)
            : base(new VariantHolder<T1>(item), 0)
        { }

        /// <summary>
        /// Creates a new Variant explicitly placing the item as the first type
        /// (<typeparamref name="T1"/>).
        /// </summary>
        /// <param name="item">Item to place in the variant.</param>
        /// <returns>New Variant instance.</returns>
        /// <remarks>Use this method when the variant contains multiple instances of the same type. This
        /// allows explicit placing of the item.</remarks>
        public static Variant<T1> Make1(T1 item) => new Variant<T1>(new VariantHolder<T1>(item), 0);

        /// <summary>
        /// Implicitly casts from <typeparamref name="T1"/> to variant. Creates a new Variant
        /// inhabited by the given item.
        /// </summary>
        /// <param name="item">Item to store in the variant.</param>
        public static implicit operator Variant<T1>(T1 item) => new Variant<T1>(item);

        /// <summary>
        /// Explicitly casts from variant to <typeparamref name="T1"/>.
        /// </summary>
        /// <param name="variant">Variant to cast to <typeparamref name="T1"/>.</param>
        /// <exception cref="System.InvalidCastException">Thrown if the item inhabiting the variant is not of type <typenameref type="T1"/></exception>
        public static explicit operator T1(Variant<T1> variant) => variant.Get<T1>();
    }

    /// <summary>
    /// Represents a 2-type discriminate union.
    /// </summary>
    /// <typeparam name="T1">Represents the variant's first type.</typeparam>
    /// <typeparam name="T2">Represents the variant's second type.</typeparam>
    /// <example>
    /// The following example shows how to assign values of different types to a Variant and how to extract
    /// values from it.
    /// <code>
    /// using Maki;
    /// using System;
    /// 
    /// namespace Samples
    /// {
    ///     class Program
    ///     {
    ///         static void Main(string[] args)
    ///         {
    ///             // A variant can hold a value of any of its generic types
    ///             Variant&lt;int, string, double&gt; variant = 42;
    /// 
    ///             // Depending on the type of the value currently inhabiting the variant,
    ///             // the right Action gets executed
    ///             variant.Apply(
    ///                 i =&gt; Console.WriteLine(i * 2),
    ///                 s =&gt; Console.WriteLine(s + &quot;!&quot;),
    ///                 d =&gt; Console.WriteLine($&quot;Double: {d}&quot;)
    ///             );
    /// 
    ///             // Can reassign variant with another of its generic types
    ///             variant = &quot;Hello world&quot;;
    /// 
    ///             // Check the type of the value currently inhabiting the variant
    ///             if (variant.Is&lt;string&gt;())
    ///             {
    ///                 // Extract a string from the variant
    ///                 Console.WriteLine($&quot;The string is: {variant.Get&lt;string&gt;()}&quot;);
    ///             }
    ///         }
    ///     }
    /// }
    /// </code>
    /// </example>
    public sealed class Variant<T1, T2> : VariantBase
    {
        private Variant(IVariantHolder item, byte index)
            : base(item, index)
        { }

        /// <summary>
        /// Creates a new Variant instance from an item of type <typeparamref name="T1"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T1"/>.</param>
        public Variant(T1 item)
            : base(new VariantHolder<T1>(item), 0)
        { }

        /// <summary>
        /// Creates a new Variant explicitly placing the item as the first type
        /// (<typeparamref name="T1"/>).
        /// </summary>
        /// <param name="item">Item to place in the variant.</param>
        /// <returns>New Variant instance.</returns>
        /// <remarks>Use this method when the variant contains multiple instances of the same type. This
        /// allows explicit placing of the item.</remarks>
        public static Variant<T1, T2> Make1(T1 item) => new Variant<T1, T2>(new VariantHolder<T1>(item), 0);

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
        /// Creates a new Variant instance from an item of type <typeparamref name="T2"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T2"/>.</param>
        public Variant(T2 item)
            : base(new VariantHolder<T2>(item), 1)
        { }

        /// <summary>
        /// Creates a new Variant explicitly placing the item as the second type
        /// (<typeparamref name="T2"/>).
        /// </summary>
        /// <param name="item">Item to place in the variant.</param>
        /// <returns>New Variant instance.</returns>
        /// <remarks>Use this method when the variant contains multiple instances of the same type. This
        /// allows explicit placing of the item.</remarks>
        public static Variant<T1, T2> Make2(T2 item) => new Variant<T1, T2>(new VariantHolder<T2>(item), 1);

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
    /// <example>
    /// The following example shows how to assign values of different types to a Variant and how to extract
    /// values from it.
    /// <code>
    /// using Maki;
    /// using System;
    /// 
    /// namespace Samples
    /// {
    ///     class Program
    ///     {
    ///         static void Main(string[] args)
    ///         {
    ///             // A variant can hold a value of any of its generic types
    ///             Variant&lt;int, string, double&gt; variant = 42;
    /// 
    ///             // Depending on the type of the value currently inhabiting the variant,
    ///             // the right Action gets executed
    ///             variant.Apply(
    ///                 i =&gt; Console.WriteLine(i * 2),
    ///                 s =&gt; Console.WriteLine(s + &quot;!&quot;),
    ///                 d =&gt; Console.WriteLine($&quot;Double: {d}&quot;)
    ///             );
    /// 
    ///             // Can reassign variant with another of its generic types
    ///             variant = &quot;Hello world&quot;;
    /// 
    ///             // Check the type of the value currently inhabiting the variant
    ///             if (variant.Is&lt;string&gt;())
    ///             {
    ///                 // Extract a string from the variant
    ///                 Console.WriteLine($&quot;The string is: {variant.Get&lt;string&gt;()}&quot;);
    ///             }
    ///         }
    ///     }
    /// }
    /// </code>
    /// </example>
    public sealed class Variant<T1, T2, T3> : VariantBase
    {
        private Variant(IVariantHolder item, byte index)
            : base(item, index)
        { }

        /// <summary>
        /// Creates a new Variant instance from an item of type <typeparamref name="T1"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T1"/>.</param>
        public Variant(T1 item)
            : base(new VariantHolder<T1>(item), 0)
        { }

        /// <summary>
        /// Creates a new Variant explicitly placing the item as the first type
        /// (<typeparamref name="T1"/>).
        /// </summary>
        /// <param name="item">Item to place in the variant.</param>
        /// <returns>New Variant instance.</returns>
        /// <remarks>Use this method when the variant contains multiple instances of the same type. This
        /// allows explicit placing of the item.</remarks>
        public static Variant<T1, T2, T3> Make1(T1 item) => new Variant<T1, T2, T3>(new VariantHolder<T1>(item), 0);

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
        /// Creates a new Variant instance from an item of type <typeparamref name="T2"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T2"/>.</param>
        public Variant(T2 item)
            : base(new VariantHolder<T2>(item), 1)
        { }

        /// <summary>
        /// Creates a new Variant explicitly placing the item as the second type
        /// (<typeparamref name="T2"/>).
        /// </summary>
        /// <param name="item">Item to place in the variant.</param>
        /// <returns>New Variant instance.</returns>
        /// <remarks>Use this method when the variant contains multiple instances of the same type. This
        /// allows explicit placing of the item.</remarks>
        public static Variant<T1, T2, T3> Make2(T2 item) => new Variant<T1, T2, T3>(new VariantHolder<T2>(item), 1);

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
        /// Creates a new Variant instance from an item of type <typeparamref name="T3"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T3"/>.</param>
        public Variant(T3 item)
            : base(new VariantHolder<T3>(item), 2)
        { }

        /// <summary>
        /// Creates a new Variant explicitly placing the item as the third type
        /// (<typeparamref name="T3"/>).
        /// </summary>
        /// <param name="item">Item to place in the variant.</param>
        /// <returns>New Variant instance.</returns>
        /// <remarks>Use this method when the variant contains multiple instances of the same type. This
        /// allows explicit placing of the item.</remarks>
        public static Variant<T1, T2, T3> Make3(T3 item) => new Variant<T1, T2, T3>(new VariantHolder<T3>(item), 2);

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
    /// <example>
    /// The following example shows how to assign values of different types to a Variant and how to extract
    /// values from it.
    /// <code>
    /// using Maki;
    /// using System;
    /// 
    /// namespace Samples
    /// {
    ///     class Program
    ///     {
    ///         static void Main(string[] args)
    ///         {
    ///             // A variant can hold a value of any of its generic types
    ///             Variant&lt;int, string, double&gt; variant = 42;
    /// 
    ///             // Depending on the type of the value currently inhabiting the variant,
    ///             // the right Action gets executed
    ///             variant.Apply(
    ///                 i =&gt; Console.WriteLine(i * 2),
    ///                 s =&gt; Console.WriteLine(s + &quot;!&quot;),
    ///                 d =&gt; Console.WriteLine($&quot;Double: {d}&quot;)
    ///             );
    /// 
    ///             // Can reassign variant with another of its generic types
    ///             variant = &quot;Hello world&quot;;
    /// 
    ///             // Check the type of the value currently inhabiting the variant
    ///             if (variant.Is&lt;string&gt;())
    ///             {
    ///                 // Extract a string from the variant
    ///                 Console.WriteLine($&quot;The string is: {variant.Get&lt;string&gt;()}&quot;);
    ///             }
    ///         }
    ///     }
    /// }
    /// </code>
    /// </example>
    public sealed class Variant<T1, T2, T3, T4> : VariantBase
    {
        private Variant(IVariantHolder item, byte index)
            : base(item, index)
        { }

        /// <summary>
        /// Creates a new Variant instance from an item of type <typeparamref name="T1"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T1"/>.</param>
        public Variant(T1 item)
            : base(new VariantHolder<T1>(item), 0)
        { }

        /// <summary>
        /// Creates a new Variant explicitly placing the item as the first type
        /// (<typeparamref name="T1"/>).
        /// </summary>
        /// <param name="item">Item to place in the variant.</param>
        /// <returns>New Variant instance.</returns>
        /// <remarks>Use this method when the variant contains multiple instances of the same type. This
        /// allows explicit placing of the item.</remarks>
        public static Variant<T1, T2, T3, T4> Make1(T1 item) => new Variant<T1, T2, T3, T4>(new VariantHolder<T1>(item), 0);

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
        /// Creates a new Variant instance from an item of type <typeparamref name="T2"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T2"/>.</param>
        public Variant(T2 item)
            : base(new VariantHolder<T2>(item), 1)
        { }

        /// <summary>
        /// Creates a new Variant explicitly placing the item as the second type
        /// (<typeparamref name="T2"/>).
        /// </summary>
        /// <param name="item">Item to place in the variant.</param>
        /// <returns>New Variant instance.</returns>
        /// <remarks>Use this method when the variant contains multiple instances of the same type. This
        /// allows explicit placing of the item.</remarks>
        public static Variant<T1, T2, T3, T4> Make2(T2 item) => new Variant<T1, T2, T3, T4>(new VariantHolder<T2>(item), 1);

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
        /// Creates a new Variant instance from an item of type <typeparamref name="T3"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T3"/>.</param>
        public Variant(T3 item)
            : base(new VariantHolder<T3>(item), 2)
        { }

        /// <summary>
        /// Creates a new Variant explicitly placing the item as the third type
        /// (<typeparamref name="T3"/>).
        /// </summary>
        /// <param name="item">Item to place in the variant.</param>
        /// <returns>New Variant instance.</returns>
        /// <remarks>Use this method when the variant contains multiple instances of the same type. This
        /// allows explicit placing of the item.</remarks>
        public static Variant<T1, T2, T3, T4> Make3(T3 item) => new Variant<T1, T2, T3, T4>(new VariantHolder<T3>(item), 2);

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
        /// Creates a new Variant instance from an item of type <typeparamref name="T4"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T4"/>.</param>
        public Variant(T4 item)
            : base(new VariantHolder<T4>(item), 3)
        { }

        /// <summary>
        /// Creates a new Variant explicitly placing the item as the fourth type
        /// (<typeparamref name="T4"/>).
        /// </summary>
        /// <param name="item">Item to place in the variant.</param>
        /// <returns>New Variant instance.</returns>
        /// <remarks>Use this method when the variant contains multiple instances of the same type. This
        /// allows explicit placing of the item.</remarks>
        public static Variant<T1, T2, T3, T4> Make4(T4 item) => new Variant<T1, T2, T3, T4>(new VariantHolder<T4>(item), 3);

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
    /// <example>
    /// The following example shows how to assign values of different types to a Variant and how to extract
    /// values from it.
    /// <code>
    /// using Maki;
    /// using System;
    /// 
    /// namespace Samples
    /// {
    ///     class Program
    ///     {
    ///         static void Main(string[] args)
    ///         {
    ///             // A variant can hold a value of any of its generic types
    ///             Variant&lt;int, string, double&gt; variant = 42;
    /// 
    ///             // Depending on the type of the value currently inhabiting the variant,
    ///             // the right Action gets executed
    ///             variant.Apply(
    ///                 i =&gt; Console.WriteLine(i * 2),
    ///                 s =&gt; Console.WriteLine(s + &quot;!&quot;),
    ///                 d =&gt; Console.WriteLine($&quot;Double: {d}&quot;)
    ///             );
    /// 
    ///             // Can reassign variant with another of its generic types
    ///             variant = &quot;Hello world&quot;;
    /// 
    ///             // Check the type of the value currently inhabiting the variant
    ///             if (variant.Is&lt;string&gt;())
    ///             {
    ///                 // Extract a string from the variant
    ///                 Console.WriteLine($&quot;The string is: {variant.Get&lt;string&gt;()}&quot;);
    ///             }
    ///         }
    ///     }
    /// }
    /// </code>
    /// </example>
    public sealed class Variant<T1, T2, T3, T4, T5> : VariantBase
    {
        private Variant(IVariantHolder item, byte index)
            : base(item, index)
        { }

        /// <summary>
        /// Creates a new Variant instance from an item of type <typeparamref name="T1"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T1"/>.</param>
        public Variant(T1 item)
            : base(new VariantHolder<T1>(item), 0)
        { }

        /// <summary>
        /// Creates a new Variant explicitly placing the item as the first type
        /// (<typeparamref name="T1"/>).
        /// </summary>
        /// <param name="item">Item to place in the variant.</param>
        /// <returns>New Variant instance.</returns>
        /// <remarks>Use this method when the variant contains multiple instances of the same type. This
        /// allows explicit placing of the item.</remarks>
        public static Variant<T1, T2, T3, T4, T5> Make1(T1 item) => new Variant<T1, T2, T3, T4, T5>(new VariantHolder<T1>(item), 0);

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
        /// Creates a new Variant instance from an item of type <typeparamref name="T2"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T2"/>.</param>
        public Variant(T2 item)
            : base(new VariantHolder<T2>(item), 1)
        { }

        /// <summary>
        /// Creates a new Variant explicitly placing the item as the second type
        /// (<typeparamref name="T2"/>).
        /// </summary>
        /// <param name="item">Item to place in the variant.</param>
        /// <returns>New Variant instance.</returns>
        /// <remarks>Use this method when the variant contains multiple instances of the same type. This
        /// allows explicit placing of the item.</remarks>
        public static Variant<T1, T2, T3, T4, T5> Make2(T2 item) => new Variant<T1, T2, T3, T4, T5>(new VariantHolder<T2>(item), 1);

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
        /// Creates a new Variant instance from an item of type <typeparamref name="T3"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T3"/>.</param>
        public Variant(T3 item)
            : base(new VariantHolder<T3>(item), 2)
        { }

        /// <summary>
        /// Creates a new Variant explicitly placing the item as the third type
        /// (<typeparamref name="T3"/>).
        /// </summary>
        /// <param name="item">Item to place in the variant.</param>
        /// <returns>New Variant instance.</returns>
        /// <remarks>Use this method when the variant contains multiple instances of the same type. This
        /// allows explicit placing of the item.</remarks>
        public static Variant<T1, T2, T3, T4, T5> Make3(T3 item) => new Variant<T1, T2, T3, T4, T5>(new VariantHolder<T3>(item), 2);

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
        /// Creates a new Variant instance from an item of type <typeparamref name="T4"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T4"/>.</param>
        public Variant(T4 item)
            : base(new VariantHolder<T4>(item), 3)
        { }

        /// <summary>
        /// Creates a new Variant explicitly placing the item as the fourth type
        /// (<typeparamref name="T4"/>).
        /// </summary>
        /// <param name="item">Item to place in the variant.</param>
        /// <returns>New Variant instance.</returns>
        /// <remarks>Use this method when the variant contains multiple instances of the same type. This
        /// allows explicit placing of the item.</remarks>
        public static Variant<T1, T2, T3, T4, T5> Make4(T4 item) => new Variant<T1, T2, T3, T4, T5>(new VariantHolder<T4>(item), 3);

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
        /// Creates a new Variant instance from an item of type <typeparamref name="T5"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T5"/>.</param>
        public Variant(T5 item)
            : base(new VariantHolder<T5>(item), 4)
        { }

        /// <summary>
        /// Creates a new Variant explicitly placing the item as the fifth type
        /// (<typeparamref name="T5"/>).
        /// </summary>
        /// <param name="item">Item to place in the variant.</param>
        /// <returns>New Variant instance.</returns>
        /// <remarks>Use this method when the variant contains multiple instances of the same type. This
        /// allows explicit placing of the item.</remarks>
        public static Variant<T1, T2, T3, T4, T5> Make5(T5 item) => new Variant<T1, T2, T3, T4, T5>(new VariantHolder<T5>(item), 4);

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
    /// <example>
    /// The following example shows how to assign values of different types to a Variant and how to extract
    /// values from it.
    /// <code>
    /// using Maki;
    /// using System;
    /// 
    /// namespace Samples
    /// {
    ///     class Program
    ///     {
    ///         static void Main(string[] args)
    ///         {
    ///             // A variant can hold a value of any of its generic types
    ///             Variant&lt;int, string, double&gt; variant = 42;
    /// 
    ///             // Depending on the type of the value currently inhabiting the variant,
    ///             // the right Action gets executed
    ///             variant.Apply(
    ///                 i =&gt; Console.WriteLine(i * 2),
    ///                 s =&gt; Console.WriteLine(s + &quot;!&quot;),
    ///                 d =&gt; Console.WriteLine($&quot;Double: {d}&quot;)
    ///             );
    /// 
    ///             // Can reassign variant with another of its generic types
    ///             variant = &quot;Hello world&quot;;
    /// 
    ///             // Check the type of the value currently inhabiting the variant
    ///             if (variant.Is&lt;string&gt;())
    ///             {
    ///                 // Extract a string from the variant
    ///                 Console.WriteLine($&quot;The string is: {variant.Get&lt;string&gt;()}&quot;);
    ///             }
    ///         }
    ///     }
    /// }
    /// </code>
    /// </example>
    public sealed class Variant<T1, T2, T3, T4, T5, T6> : VariantBase
    {
        private Variant(IVariantHolder item, byte index)
            : base(item, index)
        { }

        /// <summary>
        /// Creates a new Variant instance from an item of type <typeparamref name="T1"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T1"/>.</param>
        public Variant(T1 item)
            : base(new VariantHolder<T1>(item), 0)
        { }

        /// <summary>
        /// Creates a new Variant explicitly placing the item as the first type
        /// (<typeparamref name="T1"/>).
        /// </summary>
        /// <param name="item">Item to place in the variant.</param>
        /// <returns>New Variant instance.</returns>
        /// <remarks>Use this method when the variant contains multiple instances of the same type. This
        /// allows explicit placing of the item.</remarks>
        public static Variant<T1, T2, T3, T4, T5, T6> Make1(T1 item) => new Variant<T1, T2, T3, T4, T5, T6>(new VariantHolder<T1>(item), 0);

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
        /// Creates a new Variant instance from an item of type <typeparamref name="T2"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T2"/>.</param>
        public Variant(T2 item)
            : base(new VariantHolder<T2>(item), 1)
        { }

        /// <summary>
        /// Creates a new Variant explicitly placing the item as the second type
        /// (<typeparamref name="T2"/>).
        /// </summary>
        /// <param name="item">Item to place in the variant.</param>
        /// <returns>New Variant instance.</returns>
        /// <remarks>Use this method when the variant contains multiple instances of the same type. This
        /// allows explicit placing of the item.</remarks>
        public static Variant<T1, T2, T3, T4, T5, T6> Make2(T2 item) => new Variant<T1, T2, T3, T4, T5, T6>(new VariantHolder<T2>(item), 1);

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
        /// Creates a new Variant instance from an item of type <typeparamref name="T3"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T3"/>.</param>
        public Variant(T3 item)
            : base(new VariantHolder<T3>(item), 2)
        { }

        /// <summary>
        /// Creates a new Variant explicitly placing the item as the third type
        /// (<typeparamref name="T3"/>).
        /// </summary>
        /// <param name="item">Item to place in the variant.</param>
        /// <returns>New Variant instance.</returns>
        /// <remarks>Use this method when the variant contains multiple instances of the same type. This
        /// allows explicit placing of the item.</remarks>
        public static Variant<T1, T2, T3, T4, T5, T6> Make3(T3 item) => new Variant<T1, T2, T3, T4, T5, T6>(new VariantHolder<T3>(item), 2);

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
        /// Creates a new Variant instance from an item of type <typeparamref name="T4"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T4"/>.</param>
        public Variant(T4 item)
            : base(new VariantHolder<T4>(item), 3)
        { }

        /// <summary>
        /// Creates a new Variant explicitly placing the item as the fourth type
        /// (<typeparamref name="T4"/>).
        /// </summary>
        /// <param name="item">Item to place in the variant.</param>
        /// <returns>New Variant instance.</returns>
        /// <remarks>Use this method when the variant contains multiple instances of the same type. This
        /// allows explicit placing of the item.</remarks>
        public static Variant<T1, T2, T3, T4, T5, T6> Make4(T4 item) => new Variant<T1, T2, T3, T4, T5, T6>(new VariantHolder<T4>(item), 3);

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
        /// Creates a new Variant instance from an item of type <typeparamref name="T5"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T5"/>.</param>
        public Variant(T5 item)
            : base(new VariantHolder<T5>(item), 4)
        { }

        /// <summary>
        /// Creates a new Variant explicitly placing the item as the fifth type
        /// (<typeparamref name="T5"/>).
        /// </summary>
        /// <param name="item">Item to place in the variant.</param>
        /// <returns>New Variant instance.</returns>
        /// <remarks>Use this method when the variant contains multiple instances of the same type. This
        /// allows explicit placing of the item.</remarks>
        public static Variant<T1, T2, T3, T4, T5, T6> Make5(T5 item) => new Variant<T1, T2, T3, T4, T5, T6>(new VariantHolder<T5>(item), 4);

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
        /// Creates a new Variant instance from an item of type <typeparamref name="T6"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T6"/>.</param>
        public Variant(T6 item)
            : base(new VariantHolder<T6>(item), 5)
        { }

        /// <summary>
        /// Creates a new Variant explicitly placing the item as the sixth type
        /// (<typeparamref name="T6"/>).
        /// </summary>
        /// <param name="item">Item to place in the variant.</param>
        /// <returns>New Variant instance.</returns>
        /// <remarks>Use this method when the variant contains multiple instances of the same type. This
        /// allows explicit placing of the item.</remarks>
        public static Variant<T1, T2, T3, T4, T5, T6> Make6(T6 item) => new Variant<T1, T2, T3, T4, T5, T6>(new VariantHolder<T6>(item), 5);

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
    /// <example>
    /// The following example shows how to assign values of different types to a Variant and how to extract
    /// values from it.
    /// <code>
    /// using Maki;
    /// using System;
    /// 
    /// namespace Samples
    /// {
    ///     class Program
    ///     {
    ///         static void Main(string[] args)
    ///         {
    ///             // A variant can hold a value of any of its generic types
    ///             Variant&lt;int, string, double&gt; variant = 42;
    /// 
    ///             // Depending on the type of the value currently inhabiting the variant,
    ///             // the right Action gets executed
    ///             variant.Apply(
    ///                 i =&gt; Console.WriteLine(i * 2),
    ///                 s =&gt; Console.WriteLine(s + &quot;!&quot;),
    ///                 d =&gt; Console.WriteLine($&quot;Double: {d}&quot;)
    ///             );
    /// 
    ///             // Can reassign variant with another of its generic types
    ///             variant = &quot;Hello world&quot;;
    /// 
    ///             // Check the type of the value currently inhabiting the variant
    ///             if (variant.Is&lt;string&gt;())
    ///             {
    ///                 // Extract a string from the variant
    ///                 Console.WriteLine($&quot;The string is: {variant.Get&lt;string&gt;()}&quot;);
    ///             }
    ///         }
    ///     }
    /// }
    /// </code>
    /// </example>
    public sealed class Variant<T1, T2, T3, T4, T5, T6, T7> : VariantBase
    {
        private Variant(IVariantHolder item, byte index)
            : base(item, index)
        { }

        /// <summary>
        /// Creates a new Variant instance from an item of type <typeparamref name="T1"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T1"/>.</param>
        public Variant(T1 item)
            : base(new VariantHolder<T1>(item), 0)
        { }

        /// <summary>
        /// Creates a new Variant explicitly placing the item as the first type
        /// (<typeparamref name="T1"/>).
        /// </summary>
        /// <param name="item">Item to place in the variant.</param>
        /// <returns>New Variant instance.</returns>
        /// <remarks>Use this method when the variant contains multiple instances of the same type. This
        /// allows explicit placing of the item.</remarks>
        public static Variant<T1, T2, T3, T4, T5, T6, T7> Make1(T1 item) => new Variant<T1, T2, T3, T4, T5, T6, T7>(new VariantHolder<T1>(item), 0);

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
        /// Creates a new Variant instance from an item of type <typeparamref name="T2"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T2"/>.</param>
        public Variant(T2 item)
            : base(new VariantHolder<T2>(item), 1)
        { }

        /// <summary>
        /// Creates a new Variant explicitly placing the item as the second type
        /// (<typeparamref name="T2"/>).
        /// </summary>
        /// <param name="item">Item to place in the variant.</param>
        /// <returns>New Variant instance.</returns>
        /// <remarks>Use this method when the variant contains multiple instances of the same type. This
        /// allows explicit placing of the item.</remarks>
        public static Variant<T1, T2, T3, T4, T5, T6, T7> Make2(T2 item) => new Variant<T1, T2, T3, T4, T5, T6, T7>(new VariantHolder<T2>(item), 1);

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
        /// Creates a new Variant instance from an item of type <typeparamref name="T3"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T3"/>.</param>
        public Variant(T3 item)
            : base(new VariantHolder<T3>(item), 2)
        { }

        /// <summary>
        /// Creates a new Variant explicitly placing the item as the third type
        /// (<typeparamref name="T3"/>).
        /// </summary>
        /// <param name="item">Item to place in the variant.</param>
        /// <returns>New Variant instance.</returns>
        /// <remarks>Use this method when the variant contains multiple instances of the same type. This
        /// allows explicit placing of the item.</remarks>
        public static Variant<T1, T2, T3, T4, T5, T6, T7> Make3(T3 item) => new Variant<T1, T2, T3, T4, T5, T6, T7>(new VariantHolder<T3>(item), 2);

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
        /// Creates a new Variant instance from an item of type <typeparamref name="T4"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T4"/>.</param>
        public Variant(T4 item)
            : base(new VariantHolder<T4>(item), 3)
        { }

        /// <summary>
        /// Creates a new Variant explicitly placing the item as the fourth type
        /// (<typeparamref name="T4"/>).
        /// </summary>
        /// <param name="item">Item to place in the variant.</param>
        /// <returns>New Variant instance.</returns>
        /// <remarks>Use this method when the variant contains multiple instances of the same type. This
        /// allows explicit placing of the item.</remarks>
        public static Variant<T1, T2, T3, T4, T5, T6, T7> Make4(T4 item) => new Variant<T1, T2, T3, T4, T5, T6, T7>(new VariantHolder<T4>(item), 3);

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
        /// Creates a new Variant instance from an item of type <typeparamref name="T5"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T5"/>.</param>
        public Variant(T5 item)
            : base(new VariantHolder<T5>(item), 4)
        { }

        /// <summary>
        /// Creates a new Variant explicitly placing the item as the fifth type
        /// (<typeparamref name="T5"/>).
        /// </summary>
        /// <param name="item">Item to place in the variant.</param>
        /// <returns>New Variant instance.</returns>
        /// <remarks>Use this method when the variant contains multiple instances of the same type. This
        /// allows explicit placing of the item.</remarks>
        public static Variant<T1, T2, T3, T4, T5, T6, T7> Make5(T5 item) => new Variant<T1, T2, T3, T4, T5, T6, T7>(new VariantHolder<T5>(item), 4);

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
        /// Creates a new Variant instance from an item of type <typeparamref name="T6"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T6"/>.</param>
        public Variant(T6 item)
            : base(new VariantHolder<T6>(item), 5)
        { }

        /// <summary>
        /// Creates a new Variant explicitly placing the item as the sixth type
        /// (<typeparamref name="T6"/>).
        /// </summary>
        /// <param name="item">Item to place in the variant.</param>
        /// <returns>New Variant instance.</returns>
        /// <remarks>Use this method when the variant contains multiple instances of the same type. This
        /// allows explicit placing of the item.</remarks>
        public static Variant<T1, T2, T3, T4, T5, T6, T7> Make6(T6 item) => new Variant<T1, T2, T3, T4, T5, T6, T7>(new VariantHolder<T6>(item), 5);

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
        /// Creates a new Variant instance from an item of type <typeparamref name="T7"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T7"/>.</param>
        public Variant(T7 item)
            : base(new VariantHolder<T7>(item), 6)
        { }

        /// <summary>
        /// Creates a new Variant explicitly placing the item as the seventh type
        /// (<typeparamref name="T7"/>).
        /// </summary>
        /// <param name="item">Item to place in the variant.</param>
        /// <returns>New Variant instance.</returns>
        /// <remarks>Use this method when the variant contains multiple instances of the same type. This
        /// allows explicit placing of the item.</remarks>
        public static Variant<T1, T2, T3, T4, T5, T6, T7> Make7(T7 item) => new Variant<T1, T2, T3, T4, T5, T6, T7>(new VariantHolder<T7>(item), 6);

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
    /// <example>
    /// The following example shows how to assign values of different types to a Variant and how to extract
    /// values from it.
    /// <code>
    /// using Maki;
    /// using System;
    /// 
    /// namespace Samples
    /// {
    ///     class Program
    ///     {
    ///         static void Main(string[] args)
    ///         {
    ///             // A variant can hold a value of any of its generic types
    ///             Variant&lt;int, string, double&gt; variant = 42;
    /// 
    ///             // Depending on the type of the value currently inhabiting the variant,
    ///             // the right Action gets executed
    ///             variant.Apply(
    ///                 i =&gt; Console.WriteLine(i * 2),
    ///                 s =&gt; Console.WriteLine(s + &quot;!&quot;),
    ///                 d =&gt; Console.WriteLine($&quot;Double: {d}&quot;)
    ///             );
    /// 
    ///             // Can reassign variant with another of its generic types
    ///             variant = &quot;Hello world&quot;;
    /// 
    ///             // Check the type of the value currently inhabiting the variant
    ///             if (variant.Is&lt;string&gt;())
    ///             {
    ///                 // Extract a string from the variant
    ///                 Console.WriteLine($&quot;The string is: {variant.Get&lt;string&gt;()}&quot;);
    ///             }
    ///         }
    ///     }
    /// }
    /// </code>
    /// </example>
    public sealed class Variant<T1, T2, T3, T4, T5, T6, T7, T8> : VariantBase
    {
        private Variant(IVariantHolder item, byte index)
            : base(item, index)
        { }

        /// <summary>
        /// Creates a new Variant instance from an item of type <typeparamref name="T1"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T1"/>.</param>
        public Variant(T1 item)
            : base(new VariantHolder<T1>(item), 0)
        { }

        /// <summary>
        /// Creates a new Variant explicitly placing the item as the first type
        /// (<typeparamref name="T1"/>).
        /// </summary>
        /// <param name="item">Item to place in the variant.</param>
        /// <returns>New Variant instance.</returns>
        /// <remarks>Use this method when the variant contains multiple instances of the same type. This
        /// allows explicit placing of the item.</remarks>
        public static Variant<T1, T2, T3, T4, T5, T6, T7, T8> Make1(T1 item) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8>(new VariantHolder<T1>(item), 0);

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
        /// Creates a new Variant instance from an item of type <typeparamref name="T2"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T2"/>.</param>
        public Variant(T2 item)
            : base(new VariantHolder<T2>(item), 1)
        { }

        /// <summary>
        /// Creates a new Variant explicitly placing the item as the second type
        /// (<typeparamref name="T2"/>).
        /// </summary>
        /// <param name="item">Item to place in the variant.</param>
        /// <returns>New Variant instance.</returns>
        /// <remarks>Use this method when the variant contains multiple instances of the same type. This
        /// allows explicit placing of the item.</remarks>
        public static Variant<T1, T2, T3, T4, T5, T6, T7, T8> Make2(T2 item) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8>(new VariantHolder<T2>(item), 1);

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
        /// Creates a new Variant instance from an item of type <typeparamref name="T3"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T3"/>.</param>
        public Variant(T3 item)
            : base(new VariantHolder<T3>(item), 2)
        { }

        /// <summary>
        /// Creates a new Variant explicitly placing the item as the third type
        /// (<typeparamref name="T3"/>).
        /// </summary>
        /// <param name="item">Item to place in the variant.</param>
        /// <returns>New Variant instance.</returns>
        /// <remarks>Use this method when the variant contains multiple instances of the same type. This
        /// allows explicit placing of the item.</remarks>
        public static Variant<T1, T2, T3, T4, T5, T6, T7, T8> Make3(T3 item) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8>(new VariantHolder<T3>(item), 2);

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
        /// Creates a new Variant instance from an item of type <typeparamref name="T4"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T4"/>.</param>
        public Variant(T4 item)
            : base(new VariantHolder<T4>(item), 3)
        { }

        /// <summary>
        /// Creates a new Variant explicitly placing the item as the fourth type
        /// (<typeparamref name="T4"/>).
        /// </summary>
        /// <param name="item">Item to place in the variant.</param>
        /// <returns>New Variant instance.</returns>
        /// <remarks>Use this method when the variant contains multiple instances of the same type. This
        /// allows explicit placing of the item.</remarks>
        public static Variant<T1, T2, T3, T4, T5, T6, T7, T8> Make4(T4 item) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8>(new VariantHolder<T4>(item), 3);

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
        /// Creates a new Variant instance from an item of type <typeparamref name="T5"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T5"/>.</param>
        public Variant(T5 item)
            : base(new VariantHolder<T5>(item), 4)
        { }

        /// <summary>
        /// Creates a new Variant explicitly placing the item as the fifth type
        /// (<typeparamref name="T5"/>).
        /// </summary>
        /// <param name="item">Item to place in the variant.</param>
        /// <returns>New Variant instance.</returns>
        /// <remarks>Use this method when the variant contains multiple instances of the same type. This
        /// allows explicit placing of the item.</remarks>
        public static Variant<T1, T2, T3, T4, T5, T6, T7, T8> Make5(T5 item) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8>(new VariantHolder<T5>(item), 4);

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
        /// Creates a new Variant instance from an item of type <typeparamref name="T6"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T6"/>.</param>
        public Variant(T6 item)
            : base(new VariantHolder<T6>(item), 5)
        { }

        /// <summary>
        /// Creates a new Variant explicitly placing the item as the sixth type
        /// (<typeparamref name="T6"/>).
        /// </summary>
        /// <param name="item">Item to place in the variant.</param>
        /// <returns>New Variant instance.</returns>
        /// <remarks>Use this method when the variant contains multiple instances of the same type. This
        /// allows explicit placing of the item.</remarks>
        public static Variant<T1, T2, T3, T4, T5, T6, T7, T8> Make6(T6 item) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8>(new VariantHolder<T6>(item), 5);

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
        /// Creates a new Variant instance from an item of type <typeparamref name="T7"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T7"/>.</param>
        public Variant(T7 item)
            : base(new VariantHolder<T7>(item), 6)
        { }

        /// <summary>
        /// Creates a new Variant explicitly placing the item as the seventh type
        /// (<typeparamref name="T7"/>).
        /// </summary>
        /// <param name="item">Item to place in the variant.</param>
        /// <returns>New Variant instance.</returns>
        /// <remarks>Use this method when the variant contains multiple instances of the same type. This
        /// allows explicit placing of the item.</remarks>
        public static Variant<T1, T2, T3, T4, T5, T6, T7, T8> Make7(T7 item) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8>(new VariantHolder<T7>(item), 6);

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
        /// Creates a new Variant instance from an item of type <typeparamref name="T8"/>.
        /// </summary>
        /// <param name="item">Item of type <typeparamref name="T8"/>.</param>
        public Variant(T8 item)
            : base(new VariantHolder<T8>(item), 7)
        { }

        /// <summary>
        /// Creates a new Variant explicitly placing the item as the eighth type
        /// (<typeparamref name="T8"/>).
        /// </summary>
        /// <param name="item">Item to place in the variant.</param>
        /// <returns>New Variant instance.</returns>
        /// <remarks>Use this method when the variant contains multiple instances of the same type. This
        /// allows explicit placing of the item.</remarks>
        public static Variant<T1, T2, T3, T4, T5, T6, T7, T8> Make8(T8 item) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8>(new VariantHolder<T8>(item), 7);

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