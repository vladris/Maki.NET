using System;

namespace Maki
{
    /// <summary>
    /// Extensions for Variant.
    /// </summary>
    public static class VariantExtensions
    {
        /// <summary>
        /// Maps the function matching the item inhabiting the variant. Returns a new variant containing the
        /// result of the function.
        /// </summary>
        /// <typeparam name="T1">The first type of the variant.</typeparam>
        /// <typeparam name="T2">The second type of the variant.</typeparam>
        /// <typeparam name="U1">The first type of the returned variant.</typeparam>
        /// <typeparam name="U2">The second type of the returned variant.</typeparam>
        /// <param name="variant">This variant.</param>
        /// <param name="func1">The first function.</param>
        /// <param name="func2">The second function.</param>
        /// <returns>New variant containing the result of the applied function.</returns>
        public static Variant<U1, U2> Map<T1, T2, U1, U2>(
            this Variant<T1, T2> variant,
            Func<T1, U1> func1,
            Func<T2, U2> func2)
        {
            switch (variant.Index)
            {
                case 0: return func1(variant.Get<T1>());
                case 1: return func2(variant.Get<T2>());
                default: throw new InvalidOperationException();
            }
        }

        /// <summary>
        /// Applies the function matching the item inhabiting the variant. Returns the result of the function.
        /// </summary>
        /// <typeparam name="T1">The first type of the variant.</typeparam>
        /// <typeparam name="T2">The second type of the variant.</typeparam>
        /// <typeparam name="U">The return type of the functions.</typeparam>
        /// <param name="variant">This variant.</param>
        /// <param name="func1">The first function.</param>
        /// <param name="func2">The second function.</param>
        /// <returns>Result of the applied function.</returns>
        public static U Apply<T1, T2, U>(
            this Variant<T1, T2> variant,
            Func<T1, U> func1,
            Func<T2, U> func2)
        {
            switch (variant.Index)
            {
                case 0: return func1(variant.Get<T1>());
                case 1: return func2(variant.Get<T2>());
                default: throw new InvalidOperationException();
            }
        }

        /// <summary>
        /// Applies the action matching the item inhabiting the variant.
        /// </summary>
        /// <typeparam name="T1">The first type of the variant.</typeparam>
        /// <typeparam name="T2">The second type of the variant.</typeparam>
        /// <param name="variant">This variant.</param>
        /// <param name="act1">The first action.</param>
        /// <param name="act2">The second action.</param>
        public static void Apply<T1, T2>(
            this Variant<T1, T2> variant,
            Action<T1> act1,
            Action<T2> act2)
        {
            switch (variant.Index)
            {
                case 0: act1(variant.Get<T1>()); return;
                case 1: act2(variant.Get<T2>()); return;
                default: throw new InvalidOperationException();
            }
        }

        /// <summary>
        /// Maps the function matching the item inhabiting the variant. Returns a new variant containing the
        /// result of the function.
        /// </summary>
        /// <typeparam name="T1">The first type of the variant.</typeparam>
        /// <typeparam name="T2">The second type of the variant.</typeparam>
        /// <typeparam name="T3">The third type of the variant.</typeparam>
        /// <typeparam name="U1">The first type of the returned variant.</typeparam>
        /// <typeparam name="U2">The second type of the returned variant.</typeparam>
        /// <typeparam name="U3">The third type of the returned variant.</typeparam>
        /// <param name="variant">This variant.</param>
        /// <param name="func1">The first function.</param>
        /// <param name="func2">The second function.</param>
        /// <param name="func3">The third function.</param>
        /// <returns>New variant containing the result of the applied function.</returns>
        public static Variant<U1, U2, U3> Map<T1, T2, T3, U1, U2, U3>(
            this Variant<T1, T2, T3> variant,
            Func<T1, U1> func1,
            Func<T2, U2> func2,
            Func<T3, U3> func3)
        {
            switch (variant.Index)
            {
                case 0: return func1(variant.Get<T1>());
                case 1: return func2(variant.Get<T2>());
                case 2: return func3(variant.Get<T3>());
                default: throw new InvalidOperationException();
            }
        }

        /// <summary>
        /// Applies the function matching the item inhabiting the variant. Returns the result of the function.
        /// </summary>
        /// <typeparam name="T1">The first type of the variant.</typeparam>
        /// <typeparam name="T2">The second type of the variant.</typeparam>
        /// <typeparam name="T3">The third type of the variant.</typeparam>
        /// <typeparam name="U">The return type of the functions.</typeparam>
        /// <param name="variant">This variant.</param>
        /// <param name="func1">The first function.</param>
        /// <param name="func2">The second function.</param>
        /// <param name="func3">The third function.</param>
        /// <returns>Result of the applied function.</returns>
        public static U Apply<T1, T2, T3, U>(
            this Variant<T1, T2, T3> variant,
            Func<T1, U> func1,
            Func<T2, U> func2,
            Func<T3, U> func3)
        {
            switch (variant.Index)
            {
                case 0: return func1(variant.Get<T1>());
                case 1: return func2(variant.Get<T2>());
                case 2: return func3(variant.Get<T3>());
                default: throw new InvalidOperationException();
            }
        }

        /// <summary>
        /// Applies the action matching the item inhabiting the variant.
        /// </summary>
        /// <typeparam name="T1">The first type of the variant.</typeparam>
        /// <typeparam name="T2">The second type of the variant.</typeparam>
        /// <typeparam name="T3">The third type of the variant.</typeparam>
        /// <param name="variant">This variant.</param>
        /// <param name="act1">The first action.</param>
        /// <param name="act2">The second action.</param>
        /// <param name="act3">The third action.</param>
        public static void Apply<T1, T2, T3>(
            this Variant<T1, T2, T3> variant,
            Action<T1> act1,
            Action<T2> act2,
            Action<T3> act3)
        {
            switch (variant.Index)
            {
                case 0: act1(variant.Get<T1>()); return;
                case 1: act2(variant.Get<T2>()); return;
                case 2: act3(variant.Get<T3>()); return;
                default: throw new InvalidOperationException();
            }
        }

        /// <summary>
        /// Maps the function matching the item inhabiting the variant. Returns a new variant containing the
        /// result of the function.
        /// </summary>
        /// <typeparam name="T1">The first type of the variant.</typeparam>
        /// <typeparam name="T2">The second type of the variant.</typeparam>
        /// <typeparam name="T3">The third type of the variant.</typeparam>
        /// <typeparam name="T4">The fourth type of the variant.</typeparam>
        /// <typeparam name="U1">The first type of the returned variant.</typeparam>
        /// <typeparam name="U2">The second type of the returned variant.</typeparam>
        /// <typeparam name="U3">The third type of the returned variant.</typeparam>
        /// <typeparam name="U4">The fourth type of the returned variant.</typeparam>
        /// <param name="variant">This variant.</param>
        /// <param name="func1">The first function.</param>
        /// <param name="func2">The second function.</param>
        /// <param name="func3">The third function.</param>
        /// <param name="func4">The fourth function.</param>
        /// <returns>New variant containing the result of the applied function.</returns>
        public static Variant<U1, U2, U3, U4> Map<T1, T2, T3, T4, U1, U2, U3, U4>(
            this Variant<T1, T2, T3, T4> variant,
            Func<T1, U1> func1,
            Func<T2, U2> func2,
            Func<T3, U3> func3,
            Func<T4, U4> func4)
        {
            switch (variant.Index)
            {
                case 0: return func1(variant.Get<T1>());
                case 1: return func2(variant.Get<T2>());
                case 2: return func3(variant.Get<T3>());
                case 3: return func4(variant.Get<T4>());
                default: throw new InvalidOperationException();
            }
        }

        /// <summary>
        /// Applies the function matching the item inhabiting the variant. Returns the result of the function.
        /// </summary>
        /// <typeparam name="T1">The first type of the variant.</typeparam>
        /// <typeparam name="T2">The second type of the variant.</typeparam>
        /// <typeparam name="T3">The third type of the variant.</typeparam>
        /// <typeparam name="T4">The fourth type of the variant.</typeparam>
        /// <typeparam name="U">The return type of the functions.</typeparam>
        /// <param name="variant">This variant.</param>
        /// <param name="func1">The first function.</param>
        /// <param name="func2">The second function.</param>
        /// <param name="func3">The third function.</param>
        /// <param name="func4">The fourth function.</param>
        /// <returns>Result of the applied function.</returns>
        public static U Apply<T1, T2, T3, T4, U>(
            this Variant<T1, T2, T3, T4> variant,
            Func<T1, U> func1,
            Func<T2, U> func2,
            Func<T3, U> func3,
            Func<T4, U> func4)
        {
            switch (variant.Index)
            {
                case 0: return func1(variant.Get<T1>());
                case 1: return func2(variant.Get<T2>());
                case 2: return func3(variant.Get<T3>());
                case 3: return func4(variant.Get<T4>());
                default: throw new InvalidOperationException();
            }
        }

        /// <summary>
        /// Applies the action matching the item inhabiting the variant.
        /// </summary>
        /// <typeparam name="T1">The first type of the variant.</typeparam>
        /// <typeparam name="T2">The second type of the variant.</typeparam>
        /// <typeparam name="T3">The third type of the variant.</typeparam>
        /// <typeparam name="T4">The fourth type of the variant.</typeparam>
        /// <param name="variant">This variant.</param>
        /// <param name="act1">The first action.</param>
        /// <param name="act2">The second action.</param>
        /// <param name="act3">The third action.</param>
        /// <param name="act4">The fourth action.</param>
        public static void Apply<T1, T2, T3, T4>(
            this Variant<T1, T2, T3, T4> variant,
            Action<T1> act1,
            Action<T2> act2,
            Action<T3> act3,
            Action<T4> act4)
        {
            switch (variant.Index)
            {
                case 0: act1(variant.Get<T1>()); return;
                case 1: act2(variant.Get<T2>()); return;
                case 2: act3(variant.Get<T3>()); return;
                case 3: act4(variant.Get<T4>()); return;
                default: throw new InvalidOperationException();
            }
        }

        /// <summary>
        /// Maps the function matching the item inhabiting the variant. Returns a new variant containing the
        /// result of the function.
        /// </summary>
        /// <typeparam name="T1">The first type of the variant.</typeparam>
        /// <typeparam name="T2">The second type of the variant.</typeparam>
        /// <typeparam name="T3">The third type of the variant.</typeparam>
        /// <typeparam name="T4">The fourth type of the variant.</typeparam>
        /// <typeparam name="T5">The fifth type of the variant.</typeparam>
        /// <typeparam name="U1">The first type of the returned variant.</typeparam>
        /// <typeparam name="U2">The second type of the returned variant.</typeparam>
        /// <typeparam name="U3">The third type of the returned variant.</typeparam>
        /// <typeparam name="U4">The fourth type of the returned variant.</typeparam>
        /// <typeparam name="U5">The fifth type of the returned variant.</typeparam>
        /// <param name="variant">This variant.</param>
        /// <param name="func1">The first function.</param>
        /// <param name="func2">The second function.</param>
        /// <param name="func3">The third function.</param>
        /// <param name="func4">The fourth function.</param>
        /// <param name="func5">The fifth function.</param>
        /// <returns>New variant containing the result of the applied function.</returns>
        public static Variant<U1, U2, U3, U4, U5> Map<T1, T2, T3, T4, T5, U1, U2, U3, U4, U5>(
            this Variant<T1, T2, T3, T4, T5> variant,
            Func<T1, U1> func1,
            Func<T2, U2> func2,
            Func<T3, U3> func3,
            Func<T4, U4> func4,
            Func<T5, U5> func5)
        {
            switch (variant.Index)
            {
                case 0: return func1(variant.Get<T1>());
                case 1: return func2(variant.Get<T2>());
                case 2: return func3(variant.Get<T3>());
                case 3: return func4(variant.Get<T4>());
                case 4: return func5(variant.Get<T5>());
                default: throw new InvalidOperationException();
            }
        }

        /// <summary>
        /// Applies the function matching the item inhabiting the variant. Returns the result of the function.
        /// </summary>
        /// <typeparam name="T1">The first type of the variant.</typeparam>
        /// <typeparam name="T2">The second type of the variant.</typeparam>
        /// <typeparam name="T3">The third type of the variant.</typeparam>
        /// <typeparam name="T4">The fourth type of the variant.</typeparam>
        /// <typeparam name="T5">The fifth type of the variant.</typeparam>
        /// <typeparam name="U">The return type of the functions.</typeparam>
        /// <param name="variant">This variant.</param>
        /// <param name="func1">The first function.</param>
        /// <param name="func2">The second function.</param>
        /// <param name="func3">The third function.</param>
        /// <param name="func4">The fourth function.</param>
        /// <param name="func5">The fifth function.</param>
        /// <returns>Result of the applied function.</returns>
        public static U Apply<T1, T2, T3, T4, T5, U>(
            this Variant<T1, T2, T3, T4, T5> variant,
            Func<T1, U> func1,
            Func<T2, U> func2,
            Func<T3, U> func3,
            Func<T4, U> func4,
            Func<T5, U> func5)
        {
            switch (variant.Index)
            {
                case 0: return func1(variant.Get<T1>());
                case 1: return func2(variant.Get<T2>());
                case 2: return func3(variant.Get<T3>());
                case 3: return func4(variant.Get<T4>());
                case 4: return func5(variant.Get<T5>());
                default: throw new InvalidOperationException();
            }
        }

        /// <summary>
        /// Applies the action matching the item inhabiting the variant.
        /// </summary>
        /// <typeparam name="T1">The first type of the variant.</typeparam>
        /// <typeparam name="T2">The second type of the variant.</typeparam>
        /// <typeparam name="T3">The third type of the variant.</typeparam>
        /// <typeparam name="T4">The fourth type of the variant.</typeparam>
        /// <typeparam name="T5">The fifth type of the variant.</typeparam>
        /// <param name="variant">This variant.</param>
        /// <param name="act1">The first action.</param>
        /// <param name="act2">The second action.</param>
        /// <param name="act3">The third action.</param>
        /// <param name="act4">The fourth action.</param>
        /// <param name="act5">The fifth action.</param>
        public static void Apply<T1, T2, T3, T4, T5>(
            this Variant<T1, T2, T3, T4, T5> variant,
            Action<T1> act1,
            Action<T2> act2,
            Action<T3> act3,
            Action<T4> act4,
            Action<T5> act5)
        {
            switch (variant.Index)
            {
                case 0: act1(variant.Get<T1>()); return;
                case 1: act2(variant.Get<T2>()); return;
                case 2: act3(variant.Get<T3>()); return;
                case 3: act4(variant.Get<T4>()); return;
                case 4: act5(variant.Get<T5>()); return;
                default: throw new InvalidOperationException();
            }
        }

        /// <summary>
        /// Maps the function matching the item inhabiting the variant. Returns a new variant containing the
        /// result of the function.
        /// </summary>
        /// <typeparam name="T1">The first type of the variant.</typeparam>
        /// <typeparam name="T2">The second type of the variant.</typeparam>
        /// <typeparam name="T3">The third type of the variant.</typeparam>
        /// <typeparam name="T4">The fourth type of the variant.</typeparam>
        /// <typeparam name="T5">The fifth type of the variant.</typeparam>
        /// <typeparam name="T6">The sixth type of the variant.</typeparam>
        /// <typeparam name="U1">The first type of the returned variant.</typeparam>
        /// <typeparam name="U2">The second type of the returned variant.</typeparam>
        /// <typeparam name="U3">The third type of the returned variant.</typeparam>
        /// <typeparam name="U4">The fourth type of the returned variant.</typeparam>
        /// <typeparam name="U5">The fifth type of the returned variant.</typeparam>
        /// <typeparam name="U6">The sixth type of the returned variant.</typeparam>
        /// <param name="variant">This variant.</param>
        /// <param name="func1">The first function.</param>
        /// <param name="func2">The second function.</param>
        /// <param name="func3">The third function.</param>
        /// <param name="func4">The fourth function.</param>
        /// <param name="func5">The fifth function.</param>
        /// <param name="func6">The sixth function.</param>
        /// <returns>New variant containing the result of the applied function.</returns>
        public static Variant<U1, U2, U3, U4, U5, U6> Map<T1, T2, T3, T4, T5, T6, U1, U2, U3, U4, U5, U6>(
            this Variant<T1, T2, T3, T4, T5, T6> variant,
            Func<T1, U1> func1,
            Func<T2, U2> func2,
            Func<T3, U3> func3,
            Func<T4, U4> func4,
            Func<T5, U5> func5,
            Func<T6, U6> func6)
        {
            switch (variant.Index)
            {
                case 0: return func1(variant.Get<T1>());
                case 1: return func2(variant.Get<T2>());
                case 2: return func3(variant.Get<T3>());
                case 3: return func4(variant.Get<T4>());
                case 4: return func5(variant.Get<T5>());
                case 5: return func6(variant.Get<T6>());
                default: throw new InvalidOperationException();
            }
        }

        /// <summary>
        /// Applies the function matching the item inhabiting the variant. Returns the result of the function.
        /// </summary>
        /// <typeparam name="T1">The first type of the variant.</typeparam>
        /// <typeparam name="T2">The second type of the variant.</typeparam>
        /// <typeparam name="T3">The third type of the variant.</typeparam>
        /// <typeparam name="T4">The fourth type of the variant.</typeparam>
        /// <typeparam name="T5">The fifth type of the variant.</typeparam>
        /// <typeparam name="T6">The sixth type of the variant.</typeparam>
        /// <typeparam name="U">The return type of the functions.</typeparam>
        /// <param name="variant">This variant.</param>
        /// <param name="func1">The first function.</param>
        /// <param name="func2">The second function.</param>
        /// <param name="func3">The third function.</param>
        /// <param name="func4">The fourth function.</param>
        /// <param name="func5">The fifth function.</param>
        /// <param name="func6">The sixth function.</param>
        /// <returns>Result of the applied function.</returns>
        public static U Apply<T1, T2, T3, T4, T5, T6, U>(
            this Variant<T1, T2, T3, T4, T5, T6> variant,
            Func<T1, U> func1,
            Func<T2, U> func2,
            Func<T3, U> func3,
            Func<T4, U> func4,
            Func<T5, U> func5,
            Func<T6, U> func6)
        {
            switch (variant.Index)
            {
                case 0: return func1(variant.Get<T1>());
                case 1: return func2(variant.Get<T2>());
                case 2: return func3(variant.Get<T3>());
                case 3: return func4(variant.Get<T4>());
                case 4: return func5(variant.Get<T5>());
                case 5: return func6(variant.Get<T6>());
                default: throw new InvalidOperationException();
            }
        }

        /// <summary>
        /// Applies the action matching the item inhabiting the variant.
        /// </summary>
        /// <typeparam name="T1">The first type of the variant.</typeparam>
        /// <typeparam name="T2">The second type of the variant.</typeparam>
        /// <typeparam name="T3">The third type of the variant.</typeparam>
        /// <typeparam name="T4">The fourth type of the variant.</typeparam>
        /// <typeparam name="T5">The fifth type of the variant.</typeparam>
        /// <typeparam name="T6">The sixth type of the variant.</typeparam>
        /// <param name="variant">This variant.</param>
        /// <param name="act1">The first action.</param>
        /// <param name="act2">The second action.</param>
        /// <param name="act3">The third action.</param>
        /// <param name="act4">The fourth action.</param>
        /// <param name="act5">The fifth action.</param>
        /// <param name="act6">The sixth action.</param>
        public static void Apply<T1, T2, T3, T4, T5, T6>(
            this Variant<T1, T2, T3, T4, T5, T6> variant,
            Action<T1> act1,
            Action<T2> act2,
            Action<T3> act3,
            Action<T4> act4,
            Action<T5> act5,
            Action<T6> act6)
        {
            switch (variant.Index)
            {
                case 0: act1(variant.Get<T1>()); return;
                case 1: act2(variant.Get<T2>()); return;
                case 2: act3(variant.Get<T3>()); return;
                case 3: act4(variant.Get<T4>()); return;
                case 4: act5(variant.Get<T5>()); return;
                case 5: act6(variant.Get<T6>()); return;
                default: throw new InvalidOperationException();
            }
        }

        /// <summary>
        /// Maps the function matching the item inhabiting the variant. Returns a new variant containing the
        /// result of the function.
        /// </summary>
        /// <typeparam name="T1">The first type of the variant.</typeparam>
        /// <typeparam name="T2">The second type of the variant.</typeparam>
        /// <typeparam name="T3">The third type of the variant.</typeparam>
        /// <typeparam name="T4">The fourth type of the variant.</typeparam>
        /// <typeparam name="T5">The fifth type of the variant.</typeparam>
        /// <typeparam name="T6">The sixth type of the variant.</typeparam>
        /// <typeparam name="T7">The seventh type of the variant.</typeparam>
        /// <typeparam name="U1">The first type of the returned variant.</typeparam>
        /// <typeparam name="U2">The second type of the returned variant.</typeparam>
        /// <typeparam name="U3">The third type of the returned variant.</typeparam>
        /// <typeparam name="U4">The fourth type of the returned variant.</typeparam>
        /// <typeparam name="U5">The fifth type of the returned variant.</typeparam>
        /// <typeparam name="U6">The sixth type of the returned variant.</typeparam>
        /// <typeparam name="U7">The seventh type of the returned variant.</typeparam>
        /// <param name="variant">This variant.</param>
        /// <param name="func1">The first function.</param>
        /// <param name="func2">The second function.</param>
        /// <param name="func3">The third function.</param>
        /// <param name="func4">The fourth function.</param>
        /// <param name="func5">The fifth function.</param>
        /// <param name="func6">The sixth function.</param>
        /// <param name="func7">The seventh function.</param>
        /// <returns>New variant containing the result of the applied function.</returns>
        public static Variant<U1, U2, U3, U4, U5, U6, U7> Map<T1, T2, T3, T4, T5, T6, T7, U1, U2, U3, U4, U5, U6, U7>(
            this Variant<T1, T2, T3, T4, T5, T6, T7> variant,
            Func<T1, U1> func1,
            Func<T2, U2> func2,
            Func<T3, U3> func3,
            Func<T4, U4> func4,
            Func<T5, U5> func5,
            Func<T6, U6> func6,
            Func<T7, U7> func7)
        {
            switch (variant.Index)
            {
                case 0: return func1(variant.Get<T1>());
                case 1: return func2(variant.Get<T2>());
                case 2: return func3(variant.Get<T3>());
                case 3: return func4(variant.Get<T4>());
                case 4: return func5(variant.Get<T5>());
                case 5: return func6(variant.Get<T6>());
                case 6: return func7(variant.Get<T7>());
                default: throw new InvalidOperationException();
            }
        }

        /// <summary>
        /// Applies the function matching the item inhabiting the variant. Returns the result of the function.
        /// </summary>
        /// <typeparam name="T1">The first type of the variant.</typeparam>
        /// <typeparam name="T2">The second type of the variant.</typeparam>
        /// <typeparam name="T3">The third type of the variant.</typeparam>
        /// <typeparam name="T4">The fourth type of the variant.</typeparam>
        /// <typeparam name="T5">The fifth type of the variant.</typeparam>
        /// <typeparam name="T6">The sixth type of the variant.</typeparam>
        /// <typeparam name="T7">The seventh type of the variant.</typeparam>
        /// <typeparam name="U">The return type of the functions.</typeparam>
        /// <param name="variant">This variant.</param>
        /// <param name="func1">The first function.</param>
        /// <param name="func2">The second function.</param>
        /// <param name="func3">The third function.</param>
        /// <param name="func4">The fourth function.</param>
        /// <param name="func5">The fifth function.</param>
        /// <param name="func6">The sixth function.</param>
        /// <param name="func7">The seventh function.</param>
        /// <returns>Result of the applied function.</returns>
        public static U Apply<T1, T2, T3, T4, T5, T6, T7, U>(
            this Variant<T1, T2, T3, T4, T5, T6, T7> variant,
            Func<T1, U> func1,
            Func<T2, U> func2,
            Func<T3, U> func3,
            Func<T4, U> func4,
            Func<T5, U> func5,
            Func<T6, U> func6,
            Func<T7, U> func7)
        {
            switch (variant.Index)
            {
                case 0: return func1(variant.Get<T1>());
                case 1: return func2(variant.Get<T2>());
                case 2: return func3(variant.Get<T3>());
                case 3: return func4(variant.Get<T4>());
                case 4: return func5(variant.Get<T5>());
                case 5: return func6(variant.Get<T6>());
                case 6: return func7(variant.Get<T7>());
                default: throw new InvalidOperationException();
            }
        }

        /// <summary>
        /// Applies the action matching the item inhabiting the variant.
        /// </summary>
        /// <typeparam name="T1">The first type of the variant.</typeparam>
        /// <typeparam name="T2">The second type of the variant.</typeparam>
        /// <typeparam name="T3">The third type of the variant.</typeparam>
        /// <typeparam name="T4">The fourth type of the variant.</typeparam>
        /// <typeparam name="T5">The fifth type of the variant.</typeparam>
        /// <typeparam name="T6">The sixth type of the variant.</typeparam>
        /// <typeparam name="T7">The seventh type of the variant.</typeparam>
        /// <param name="variant">This variant.</param>
        /// <param name="act1">The first action.</param>
        /// <param name="act2">The second action.</param>
        /// <param name="act3">The third action.</param>
        /// <param name="act4">The fourth action.</param>
        /// <param name="act5">The fifth action.</param>
        /// <param name="act6">The sixth action.</param>
        /// <param name="act7">The seventh action.</param>
        public static void Apply<T1, T2, T3, T4, T5, T6, T7>(
            this Variant<T1, T2, T3, T4, T5, T6, T7> variant,
            Action<T1> act1,
            Action<T2> act2,
            Action<T3> act3,
            Action<T4> act4,
            Action<T5> act5,
            Action<T6> act6,
            Action<T7> act7)
        {
            switch (variant.Index)
            {
                case 0: act1(variant.Get<T1>()); return;
                case 1: act2(variant.Get<T2>()); return;
                case 2: act3(variant.Get<T3>()); return;
                case 3: act4(variant.Get<T4>()); return;
                case 4: act5(variant.Get<T5>()); return;
                case 5: act6(variant.Get<T6>()); return;
                case 6: act7(variant.Get<T7>()); return;
                default: throw new InvalidOperationException();
            }
        }

        /// <summary>
        /// Maps the function matching the item inhabiting the variant. Returns a new variant containing the
        /// result of the function.
        /// </summary>
        /// <typeparam name="T1">The first type of the variant.</typeparam>
        /// <typeparam name="T2">The second type of the variant.</typeparam>
        /// <typeparam name="T3">The third type of the variant.</typeparam>
        /// <typeparam name="T4">The fourth type of the variant.</typeparam>
        /// <typeparam name="T5">The fifth type of the variant.</typeparam>
        /// <typeparam name="T6">The sixth type of the variant.</typeparam>
        /// <typeparam name="T7">The seventh type of the variant.</typeparam>
        /// <typeparam name="T8">The eighth type of the variant.</typeparam>
        /// <typeparam name="U1">The first type of the returned variant.</typeparam>
        /// <typeparam name="U2">The second type of the returned variant.</typeparam>
        /// <typeparam name="U3">The third type of the returned variant.</typeparam>
        /// <typeparam name="U4">The fourth type of the returned variant.</typeparam>
        /// <typeparam name="U5">The fifth type of the returned variant.</typeparam>
        /// <typeparam name="U6">The sixth type of the returned variant.</typeparam>
        /// <typeparam name="U7">The seventh type of the returned variant.</typeparam>
        /// <typeparam name="U8">The eighth type of the returned variant.</typeparam>
        /// <param name="variant">This variant.</param>
        /// <param name="func1">The first function.</param>
        /// <param name="func2">The second function.</param>
        /// <param name="func3">The third function.</param>
        /// <param name="func4">The fourth function.</param>
        /// <param name="func5">The fifth function.</param>
        /// <param name="func6">The sixth function.</param>
        /// <param name="func7">The seventh function.</param>
        /// <param name="func8">The eighth function.</param>
        /// <returns>New variant containing the result of the applied function.</returns>
        public static Variant<U1, U2, U3, U4, U5, U6, U7, U8> Map<T1, T2, T3, T4, T5, T6, T7, T8, U1, U2, U3, U4, U5, U6, U7, U8>(
            this Variant<T1, T2, T3, T4, T5, T6, T7, T8> variant,
            Func<T1, U1> func1,
            Func<T2, U2> func2,
            Func<T3, U3> func3,
            Func<T4, U4> func4,
            Func<T5, U5> func5,
            Func<T6, U6> func6,
            Func<T7, U7> func7,
            Func<T8, U8> func8)
        {
            switch (variant.Index)
            {
                case 0: return func1(variant.Get<T1>());
                case 1: return func2(variant.Get<T2>());
                case 2: return func3(variant.Get<T3>());
                case 3: return func4(variant.Get<T4>());
                case 4: return func5(variant.Get<T5>());
                case 5: return func6(variant.Get<T6>());
                case 6: return func7(variant.Get<T7>());
                case 7: return func8(variant.Get<T8>());
                default: throw new InvalidOperationException();
            }
        }

        /// <summary>
        /// Applies the function matching the item inhabiting the variant. Returns the result of the function.
        /// </summary>
        /// <typeparam name="T1">The first type of the variant.</typeparam>
        /// <typeparam name="T2">The second type of the variant.</typeparam>
        /// <typeparam name="T3">The third type of the variant.</typeparam>
        /// <typeparam name="T4">The fourth type of the variant.</typeparam>
        /// <typeparam name="T5">The fifth type of the variant.</typeparam>
        /// <typeparam name="T6">The sixth type of the variant.</typeparam>
        /// <typeparam name="T7">The seventh type of the variant.</typeparam>
        /// <typeparam name="T8">The eighth type of the variant.</typeparam>
        /// <typeparam name="U">The return type of the functions.</typeparam>
        /// <param name="variant">This variant.</param>
        /// <param name="func1">The first function.</param>
        /// <param name="func2">The second function.</param>
        /// <param name="func3">The third function.</param>
        /// <param name="func4">The fourth function.</param>
        /// <param name="func5">The fifth function.</param>
        /// <param name="func6">The sixth function.</param>
        /// <param name="func7">The seventh function.</param>
        /// <param name="func8">The eighth function.</param>
        /// <returns>Result of the applied function.</returns>
        public static U Apply<T1, T2, T3, T4, T5, T6, T7, T8, U>(
            this Variant<T1, T2, T3, T4, T5, T6, T7, T8> variant,
            Func<T1, U> func1,
            Func<T2, U> func2,
            Func<T3, U> func3,
            Func<T4, U> func4,
            Func<T5, U> func5,
            Func<T6, U> func6,
            Func<T7, U> func7,
            Func<T8, U> func8)
        {
            switch (variant.Index)
            {
                case 0: return func1(variant.Get<T1>());
                case 1: return func2(variant.Get<T2>());
                case 2: return func3(variant.Get<T3>());
                case 3: return func4(variant.Get<T4>());
                case 4: return func5(variant.Get<T5>());
                case 5: return func6(variant.Get<T6>());
                case 6: return func7(variant.Get<T7>());
                case 7: return func8(variant.Get<T8>());
                default: throw new InvalidOperationException();
            }
        }

        /// <summary>
        /// Applies the action matching the item inhabiting the variant.
        /// </summary>
        /// <typeparam name="T1">The first type of the variant.</typeparam>
        /// <typeparam name="T2">The second type of the variant.</typeparam>
        /// <typeparam name="T3">The third type of the variant.</typeparam>
        /// <typeparam name="T4">The fourth type of the variant.</typeparam>
        /// <typeparam name="T5">The fifth type of the variant.</typeparam>
        /// <typeparam name="T6">The sixth type of the variant.</typeparam>
        /// <typeparam name="T7">The seventh type of the variant.</typeparam>
        /// <typeparam name="T8">The eighth type of the variant.</typeparam>
        /// <param name="variant">This variant.</param>
        /// <param name="act1">The first action.</param>
        /// <param name="act2">The second action.</param>
        /// <param name="act3">The third action.</param>
        /// <param name="act4">The fourth action.</param>
        /// <param name="act5">The fifth action.</param>
        /// <param name="act6">The sixth action.</param>
        /// <param name="act7">The seventh action.</param>
        /// <param name="act8">The eighth action.</param>
        public static void Apply<T1, T2, T3, T4, T5, T6, T7, T8>(
            this Variant<T1, T2, T3, T4, T5, T6, T7, T8> variant,
            Action<T1> act1,
            Action<T2> act2,
            Action<T3> act3,
            Action<T4> act4,
            Action<T5> act5,
            Action<T6> act6,
            Action<T7> act7,
            Action<T8> act8)
        {
            switch (variant.Index)
            {
                case 0: act1(variant.Get<T1>()); return;
                case 1: act2(variant.Get<T2>()); return;
                case 2: act3(variant.Get<T3>()); return;
                case 3: act4(variant.Get<T4>()); return;
                case 4: act5(variant.Get<T5>()); return;
                case 5: act6(variant.Get<T6>()); return;
                case 6: act7(variant.Get<T7>()); return;
                case 7: act8(variant.Get<T8>()); return;
                default: throw new InvalidOperationException();
            }
        }

    }
}
