namespace Maki
{
    /// <summary>
    /// Represents a unit type.
    /// </summary>
    /// <example>
    /// A unit type has only one possible value. It is semantically equivalent to <c>void</c>, but
    /// can be instantiated. <c>Optional&lt;T&gt;</c> uses <c>Unit</c> to represent the absence of
    /// a value.
    /// <code>
    /// using Maki;
    /// using System;
    /// 
    /// namespace Samples
    /// {
    ///     class Program
    ///     {
    ///         // Assume a generic library method which expects a Func&lt;int, T&gt; and applies
    ///         // it to 42
    ///         static T Apply&lt;T&gt;(Func&lt;int, T&gt; func)
    ///         {
    ///             return func(42);
    ///         }
    /// 
    ///         static void Main(string[] args)
    ///         {
    ///             // If the return type is not meaningful, we would use void but we
    ///             // cannot create a Func&lt;int, void&gt; since cannot be used as a generic 
    ///             // argument. We can return Unit instead.
    ///             Func&lt;int, Unit&gt; func = i =&gt; Unit.Singleton;
    /// 
    ///             Apply(func);
    ///         }
    ///     }
    /// }
    /// </code>
    /// </example>
    public enum Unit
    {
        /// <summary>
        /// Unique value.
        /// </summary>
        Singleton
    }
}
