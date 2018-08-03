namespace Maki
{
    /// <summary>
    /// Represents an uninhabitable type.
    /// </summary>
    /// <example>
    /// Never is impossible to instantiate, thus it can be use to denote absence of a value. The following
    /// example shows two use-cases of Never: explicitly showing a method does not return and as a generic
    /// type argument to remove the type option.
    /// <code>
    /// using Maki;
    /// using System;
    /// 
    /// namespace Samples
    /// {
    ///     class Program
    ///     {
    ///         // This function never returns
    ///         static Never Fail(string message)
    ///         {
    ///             throw new Exception(message);
    ///         }
    /// 
    ///         // This function also never returns
    ///         static Never LoopForever()
    ///         {
    ///             while (true)
    ///             { }
    ///         }
    /// 
    ///         // Assume a generic library method which expects an Either&lt;T, U&gt;
    ///         static void NeedsGenericEither&lt;T, U&gt;(Either&lt;T, U&gt; either)
    ///         {
    ///             // ...
    ///         }
    /// 
    ///         static void Main(string[] args)
    ///         {
    ///             // We can remove a type from Either by providing Never
    ///             Either&lt;int, Never&gt; either = 42;
    /// 
    ///             NeedsGenericEither(either);
    ///         }
    ///     }
    /// }
    /// </code>
    /// </example>
    public enum Never
    {
    }
}
