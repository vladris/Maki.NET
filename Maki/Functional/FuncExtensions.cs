using System;

namespace Maki.Functional
{
    /// <summary>
    /// Provides Func extension methods to enable currying and partial application.
    /// </summary>
    public static class FuncExtensions
    {
        /// <summary>
        /// Applies the first argument to the given Func and returns a new Func
        /// derived from the partial application.
        /// </summary>
        /// <typeparam name="T1">Func type argument 1.</typeparam>
        /// <typeparam name="T2">Func type argument 2.</typeparam>
        /// <typeparam name="TResult">Func return type.</typeparam>
        /// <param name="func">Function on which to perform partial application.</param>
        /// <param name="arg1">First argument of function.</param>
        /// <returns>Func derived from given Func by partial application of first argument.</returns>
        public static Func<T2, TResult> 
            Curry<T1, T2, TResult>(
                this Func<T1, T2, TResult> func,
                T1 arg1
            )
            => (arg2)
                => func(arg1, arg2);

        /// <summary>
        /// Curries the given Func returning an equivalent set of functions each taking
        /// a single argument and returning the next function in the set.
        /// </summary>
        /// <typeparam name="T1">Func type argument 1.</typeparam>
        /// <typeparam name="T2">Func type argument 2.</typeparam>
        /// <typeparam name="TResult">Func return type.</typeparam>
        /// <param name="func">Function to curry.</param>
        /// <returns>Curried function.</returns>
        public static Func<T1, Func<T2, TResult>>
            Curry<T1, T2, TResult>(
                this Func<T1, T2, TResult> func
            )
            => arg1 => arg2 => func(arg1, arg2);

        /// <summary>
        /// Applies the first argument to the given Func and returns a new Func
        /// derived from the partial application.
        /// </summary>
        /// <typeparam name="T1">Func type argument 1.</typeparam>
        /// <typeparam name="T2">Func type argument 2.</typeparam>
        /// <typeparam name="T3">Func type argument 3.</typeparam>
        /// <typeparam name="TResult">Func return type.</typeparam>
        /// <param name="func">Function on which to perform partial application.</param>
        /// <param name="arg1">First argument of function.</param>
        /// <returns>Func derived from given Func by partial application of first argument.</returns>
        public static Func<T2, T3, TResult> 
            Curry<T1, T2, T3, TResult>(
                this Func<T1, T2, T3, TResult> func,
                T1 arg1
            )
            => (arg2, arg3)
                => func(arg1, arg2, arg3);

        /// <summary>
        /// Curries the given Func returning an equivalent set of functions each taking
        /// a single argument and returning the next function in the set.
        /// </summary>
        /// <typeparam name="T1">Func type argument 1.</typeparam>
        /// <typeparam name="T2">Func type argument 2.</typeparam>
        /// <typeparam name="T3">Func type argument 3.</typeparam>
        /// <typeparam name="TResult">Func return type.</typeparam>
        /// <param name="func">Function to curry.</param>
        /// <returns>Curried function.</returns>
        public static Func<T1, Func<T2, Func<T3, TResult>>>
            Curry<T1, T2, T3, TResult>(
                this Func<T1, T2, T3, TResult> func
            )
            => arg1 => arg2 => arg3 => func(arg1, arg2, arg3);

        /// <summary>
        /// Applies the first argument to the given Func and returns a new Func
        /// derived from the partial application.
        /// </summary>
        /// <typeparam name="T1">Func type argument 1.</typeparam>
        /// <typeparam name="T2">Func type argument 2.</typeparam>
        /// <typeparam name="T3">Func type argument 3.</typeparam>
        /// <typeparam name="T4">Func type argument 4.</typeparam>
        /// <typeparam name="TResult">Func return type.</typeparam>
        /// <param name="func">Function on which to perform partial application.</param>
        /// <param name="arg1">First argument of function.</param>
        /// <returns>Func derived from given Func by partial application of first argument.</returns>
        public static Func<T2, T3, T4, TResult> 
            Curry<T1, T2, T3, T4, TResult>(
                this Func<T1, T2, T3, T4, TResult> func,
                T1 arg1
            )
            => (arg2, arg3, arg4)
                => func(arg1, arg2, arg3, arg4);

        /// <summary>
        /// Curries the given Func returning an equivalent set of functions each taking
        /// a single argument and returning the next function in the set.
        /// </summary>
        /// <typeparam name="T1">Func type argument 1.</typeparam>
        /// <typeparam name="T2">Func type argument 2.</typeparam>
        /// <typeparam name="T3">Func type argument 3.</typeparam>
        /// <typeparam name="T4">Func type argument 4.</typeparam>
        /// <typeparam name="TResult">Func return type.</typeparam>
        /// <param name="func">Function to curry.</param>
        /// <returns>Curried function.</returns>
        public static Func<T1, Func<T2, Func<T3, Func<T4, TResult>>>>
            Curry<T1, T2, T3, T4, TResult>(
                this Func<T1, T2, T3, T4, TResult> func
            )
            => arg1 => arg2 => arg3 => arg4 => func(arg1, arg2, arg3, arg4);

        /// <summary>
        /// Applies the first argument to the given Func and returns a new Func
        /// derived from the partial application.
        /// </summary>
        /// <typeparam name="T1">Func type argument 1.</typeparam>
        /// <typeparam name="T2">Func type argument 2.</typeparam>
        /// <typeparam name="T3">Func type argument 3.</typeparam>
        /// <typeparam name="T4">Func type argument 4.</typeparam>
        /// <typeparam name="T5">Func type argument 5.</typeparam>
        /// <typeparam name="TResult">Func return type.</typeparam>
        /// <param name="func">Function on which to perform partial application.</param>
        /// <param name="arg1">First argument of function.</param>
        /// <returns>Func derived from given Func by partial application of first argument.</returns>
        public static Func<T2, T3, T4, T5, TResult> 
            Curry<T1, T2, T3, T4, T5, TResult>(
                this Func<T1, T2, T3, T4, T5, TResult> func,
                T1 arg1
            )
            => (arg2, arg3, arg4, arg5)
                => func(arg1, arg2, arg3, arg4, arg5);

        /// <summary>
        /// Curries the given Func returning an equivalent set of functions each taking
        /// a single argument and returning the next function in the set.
        /// </summary>
        /// <typeparam name="T1">Func type argument 1.</typeparam>
        /// <typeparam name="T2">Func type argument 2.</typeparam>
        /// <typeparam name="T3">Func type argument 3.</typeparam>
        /// <typeparam name="T4">Func type argument 4.</typeparam>
        /// <typeparam name="T5">Func type argument 5.</typeparam>
        /// <typeparam name="TResult">Func return type.</typeparam>
        /// <param name="func">Function to curry.</param>
        /// <returns>Curried function.</returns>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, TResult>>>>>
            Curry<T1, T2, T3, T4, T5, TResult>(
                this Func<T1, T2, T3, T4, T5, TResult> func
            )
            => arg1 => arg2 => arg3 => arg4 => arg5 => func(arg1, arg2, arg3, arg4, arg5);

        /// <summary>
        /// Applies the first argument to the given Func and returns a new Func
        /// derived from the partial application.
        /// </summary>
        /// <typeparam name="T1">Func type argument 1.</typeparam>
        /// <typeparam name="T2">Func type argument 2.</typeparam>
        /// <typeparam name="T3">Func type argument 3.</typeparam>
        /// <typeparam name="T4">Func type argument 4.</typeparam>
        /// <typeparam name="T5">Func type argument 5.</typeparam>
        /// <typeparam name="T6">Func type argument 6.</typeparam>
        /// <typeparam name="TResult">Func return type.</typeparam>
        /// <param name="func">Function on which to perform partial application.</param>
        /// <param name="arg1">First argument of function.</param>
        /// <returns>Func derived from given Func by partial application of first argument.</returns>
        public static Func<T2, T3, T4, T5, T6, TResult> 
            Curry<T1, T2, T3, T4, T5, T6, TResult>(
                this Func<T1, T2, T3, T4, T5, T6, TResult> func,
                T1 arg1
            )
            => (arg2, arg3, arg4, arg5, arg6)
                => func(arg1, arg2, arg3, arg4, arg5, arg6);

        /// <summary>
        /// Curries the given Func returning an equivalent set of functions each taking
        /// a single argument and returning the next function in the set.
        /// </summary>
        /// <typeparam name="T1">Func type argument 1.</typeparam>
        /// <typeparam name="T2">Func type argument 2.</typeparam>
        /// <typeparam name="T3">Func type argument 3.</typeparam>
        /// <typeparam name="T4">Func type argument 4.</typeparam>
        /// <typeparam name="T5">Func type argument 5.</typeparam>
        /// <typeparam name="T6">Func type argument 6.</typeparam>
        /// <typeparam name="TResult">Func return type.</typeparam>
        /// <param name="func">Function to curry.</param>
        /// <returns>Curried function.</returns>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, TResult>>>>>>
            Curry<T1, T2, T3, T4, T5, T6, TResult>(
                this Func<T1, T2, T3, T4, T5, T6, TResult> func
            )
            => arg1 => arg2 => arg3 => arg4 => arg5 => arg6 => func(arg1, arg2, arg3, arg4, arg5, arg6);

        /// <summary>
        /// Applies the first argument to the given Func and returns a new Func
        /// derived from the partial application.
        /// </summary>
        /// <typeparam name="T1">Func type argument 1.</typeparam>
        /// <typeparam name="T2">Func type argument 2.</typeparam>
        /// <typeparam name="T3">Func type argument 3.</typeparam>
        /// <typeparam name="T4">Func type argument 4.</typeparam>
        /// <typeparam name="T5">Func type argument 5.</typeparam>
        /// <typeparam name="T6">Func type argument 6.</typeparam>
        /// <typeparam name="T7">Func type argument 7.</typeparam>
        /// <typeparam name="TResult">Func return type.</typeparam>
        /// <param name="func">Function on which to perform partial application.</param>
        /// <param name="arg1">First argument of function.</param>
        /// <returns>Func derived from given Func by partial application of first argument.</returns>
        public static Func<T2, T3, T4, T5, T6, T7, TResult> 
            Curry<T1, T2, T3, T4, T5, T6, T7, TResult>(
                this Func<T1, T2, T3, T4, T5, T6, T7, TResult> func,
                T1 arg1
            )
            => (arg2, arg3, arg4, arg5, arg6, arg7)
                => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7);

        /// <summary>
        /// Curries the given Func returning an equivalent set of functions each taking
        /// a single argument and returning the next function in the set.
        /// </summary>
        /// <typeparam name="T1">Func type argument 1.</typeparam>
        /// <typeparam name="T2">Func type argument 2.</typeparam>
        /// <typeparam name="T3">Func type argument 3.</typeparam>
        /// <typeparam name="T4">Func type argument 4.</typeparam>
        /// <typeparam name="T5">Func type argument 5.</typeparam>
        /// <typeparam name="T6">Func type argument 6.</typeparam>
        /// <typeparam name="T7">Func type argument 7.</typeparam>
        /// <typeparam name="TResult">Func return type.</typeparam>
        /// <param name="func">Function to curry.</param>
        /// <returns>Curried function.</returns>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, TResult>>>>>>>
            Curry<T1, T2, T3, T4, T5, T6, T7, TResult>(
                this Func<T1, T2, T3, T4, T5, T6, T7, TResult> func
            )
            => arg1 => arg2 => arg3 => arg4 => arg5 => arg6 => arg7 => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7);

        /// <summary>
        /// Applies the first argument to the given Func and returns a new Func
        /// derived from the partial application.
        /// </summary>
        /// <typeparam name="T1">Func type argument 1.</typeparam>
        /// <typeparam name="T2">Func type argument 2.</typeparam>
        /// <typeparam name="T3">Func type argument 3.</typeparam>
        /// <typeparam name="T4">Func type argument 4.</typeparam>
        /// <typeparam name="T5">Func type argument 5.</typeparam>
        /// <typeparam name="T6">Func type argument 6.</typeparam>
        /// <typeparam name="T7">Func type argument 7.</typeparam>
        /// <typeparam name="T8">Func type argument 8.</typeparam>
        /// <typeparam name="TResult">Func return type.</typeparam>
        /// <param name="func">Function on which to perform partial application.</param>
        /// <param name="arg1">First argument of function.</param>
        /// <returns>Func derived from given Func by partial application of first argument.</returns>
        public static Func<T2, T3, T4, T5, T6, T7, T8, TResult> 
            Curry<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
                this Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> func,
                T1 arg1
            )
            => (arg2, arg3, arg4, arg5, arg6, arg7, arg8)
                => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);

        /// <summary>
        /// Curries the given Func returning an equivalent set of functions each taking
        /// a single argument and returning the next function in the set.
        /// </summary>
        /// <typeparam name="T1">Func type argument 1.</typeparam>
        /// <typeparam name="T2">Func type argument 2.</typeparam>
        /// <typeparam name="T3">Func type argument 3.</typeparam>
        /// <typeparam name="T4">Func type argument 4.</typeparam>
        /// <typeparam name="T5">Func type argument 5.</typeparam>
        /// <typeparam name="T6">Func type argument 6.</typeparam>
        /// <typeparam name="T7">Func type argument 7.</typeparam>
        /// <typeparam name="T8">Func type argument 8.</typeparam>
        /// <typeparam name="TResult">Func return type.</typeparam>
        /// <param name="func">Function to curry.</param>
        /// <returns>Curried function.</returns>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, TResult>>>>>>>>
            Curry<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
                this Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> func
            )
            => arg1 => arg2 => arg3 => arg4 => arg5 => arg6 => arg7 => arg8 => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);

        /// <summary>
        /// Applies the first argument to the given Func and returns a new Func
        /// derived from the partial application.
        /// </summary>
        /// <typeparam name="T1">Func type argument 1.</typeparam>
        /// <typeparam name="T2">Func type argument 2.</typeparam>
        /// <typeparam name="T3">Func type argument 3.</typeparam>
        /// <typeparam name="T4">Func type argument 4.</typeparam>
        /// <typeparam name="T5">Func type argument 5.</typeparam>
        /// <typeparam name="T6">Func type argument 6.</typeparam>
        /// <typeparam name="T7">Func type argument 7.</typeparam>
        /// <typeparam name="T8">Func type argument 8.</typeparam>
        /// <typeparam name="T9">Func type argument 9.</typeparam>
        /// <typeparam name="TResult">Func return type.</typeparam>
        /// <param name="func">Function on which to perform partial application.</param>
        /// <param name="arg1">First argument of function.</param>
        /// <returns>Func derived from given Func by partial application of first argument.</returns>
        public static Func<T2, T3, T4, T5, T6, T7, T8, T9, TResult> 
            Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
                this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> func,
                T1 arg1
            )
            => (arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9)
                => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);

        /// <summary>
        /// Curries the given Func returning an equivalent set of functions each taking
        /// a single argument and returning the next function in the set.
        /// </summary>
        /// <typeparam name="T1">Func type argument 1.</typeparam>
        /// <typeparam name="T2">Func type argument 2.</typeparam>
        /// <typeparam name="T3">Func type argument 3.</typeparam>
        /// <typeparam name="T4">Func type argument 4.</typeparam>
        /// <typeparam name="T5">Func type argument 5.</typeparam>
        /// <typeparam name="T6">Func type argument 6.</typeparam>
        /// <typeparam name="T7">Func type argument 7.</typeparam>
        /// <typeparam name="T8">Func type argument 8.</typeparam>
        /// <typeparam name="T9">Func type argument 9.</typeparam>
        /// <typeparam name="TResult">Func return type.</typeparam>
        /// <param name="func">Function to curry.</param>
        /// <returns>Curried function.</returns>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, TResult>>>>>>>>>
            Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
                this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> func
            )
            => arg1 => arg2 => arg3 => arg4 => arg5 => arg6 => arg7 => arg8 => arg9 => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);

        /// <summary>
        /// Applies the first argument to the given Func and returns a new Func
        /// derived from the partial application.
        /// </summary>
        /// <typeparam name="T1">Func type argument 1.</typeparam>
        /// <typeparam name="T2">Func type argument 2.</typeparam>
        /// <typeparam name="T3">Func type argument 3.</typeparam>
        /// <typeparam name="T4">Func type argument 4.</typeparam>
        /// <typeparam name="T5">Func type argument 5.</typeparam>
        /// <typeparam name="T6">Func type argument 6.</typeparam>
        /// <typeparam name="T7">Func type argument 7.</typeparam>
        /// <typeparam name="T8">Func type argument 8.</typeparam>
        /// <typeparam name="T9">Func type argument 9.</typeparam>
        /// <typeparam name="T10">Func type argument 10.</typeparam>
        /// <typeparam name="TResult">Func return type.</typeparam>
        /// <param name="func">Function on which to perform partial application.</param>
        /// <param name="arg1">First argument of function.</param>
        /// <returns>Func derived from given Func by partial application of first argument.</returns>
        public static Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> 
            Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
                this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> func,
                T1 arg1
            )
            => (arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10)
                => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);

        /// <summary>
        /// Curries the given Func returning an equivalent set of functions each taking
        /// a single argument and returning the next function in the set.
        /// </summary>
        /// <typeparam name="T1">Func type argument 1.</typeparam>
        /// <typeparam name="T2">Func type argument 2.</typeparam>
        /// <typeparam name="T3">Func type argument 3.</typeparam>
        /// <typeparam name="T4">Func type argument 4.</typeparam>
        /// <typeparam name="T5">Func type argument 5.</typeparam>
        /// <typeparam name="T6">Func type argument 6.</typeparam>
        /// <typeparam name="T7">Func type argument 7.</typeparam>
        /// <typeparam name="T8">Func type argument 8.</typeparam>
        /// <typeparam name="T9">Func type argument 9.</typeparam>
        /// <typeparam name="T10">Func type argument 10.</typeparam>
        /// <typeparam name="TResult">Func return type.</typeparam>
        /// <param name="func">Function to curry.</param>
        /// <returns>Curried function.</returns>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, TResult>>>>>>>>>>
            Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
                this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> func
            )
            => arg1 => arg2 => arg3 => arg4 => arg5 => arg6 => arg7 => arg8 => arg9 => arg10 => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);

        /// <summary>
        /// Applies the first argument to the given Func and returns a new Func
        /// derived from the partial application.
        /// </summary>
        /// <typeparam name="T1">Func type argument 1.</typeparam>
        /// <typeparam name="T2">Func type argument 2.</typeparam>
        /// <typeparam name="T3">Func type argument 3.</typeparam>
        /// <typeparam name="T4">Func type argument 4.</typeparam>
        /// <typeparam name="T5">Func type argument 5.</typeparam>
        /// <typeparam name="T6">Func type argument 6.</typeparam>
        /// <typeparam name="T7">Func type argument 7.</typeparam>
        /// <typeparam name="T8">Func type argument 8.</typeparam>
        /// <typeparam name="T9">Func type argument 9.</typeparam>
        /// <typeparam name="T10">Func type argument 10.</typeparam>
        /// <typeparam name="T11">Func type argument 11.</typeparam>
        /// <typeparam name="TResult">Func return type.</typeparam>
        /// <param name="func">Function on which to perform partial application.</param>
        /// <param name="arg1">First argument of function.</param>
        /// <returns>Func derived from given Func by partial application of first argument.</returns>
        public static Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> 
            Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(
                this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> func,
                T1 arg1
            )
            => (arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11)
                => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);

        /// <summary>
        /// Curries the given Func returning an equivalent set of functions each taking
        /// a single argument and returning the next function in the set.
        /// </summary>
        /// <typeparam name="T1">Func type argument 1.</typeparam>
        /// <typeparam name="T2">Func type argument 2.</typeparam>
        /// <typeparam name="T3">Func type argument 3.</typeparam>
        /// <typeparam name="T4">Func type argument 4.</typeparam>
        /// <typeparam name="T5">Func type argument 5.</typeparam>
        /// <typeparam name="T6">Func type argument 6.</typeparam>
        /// <typeparam name="T7">Func type argument 7.</typeparam>
        /// <typeparam name="T8">Func type argument 8.</typeparam>
        /// <typeparam name="T9">Func type argument 9.</typeparam>
        /// <typeparam name="T10">Func type argument 10.</typeparam>
        /// <typeparam name="T11">Func type argument 11.</typeparam>
        /// <typeparam name="TResult">Func return type.</typeparam>
        /// <param name="func">Function to curry.</param>
        /// <returns>Curried function.</returns>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, TResult>>>>>>>>>>>
            Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(
                this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> func
            )
            => arg1 => arg2 => arg3 => arg4 => arg5 => arg6 => arg7 => arg8 => arg9 => arg10 => arg11 => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);

        /// <summary>
        /// Applies the first argument to the given Func and returns a new Func
        /// derived from the partial application.
        /// </summary>
        /// <typeparam name="T1">Func type argument 1.</typeparam>
        /// <typeparam name="T2">Func type argument 2.</typeparam>
        /// <typeparam name="T3">Func type argument 3.</typeparam>
        /// <typeparam name="T4">Func type argument 4.</typeparam>
        /// <typeparam name="T5">Func type argument 5.</typeparam>
        /// <typeparam name="T6">Func type argument 6.</typeparam>
        /// <typeparam name="T7">Func type argument 7.</typeparam>
        /// <typeparam name="T8">Func type argument 8.</typeparam>
        /// <typeparam name="T9">Func type argument 9.</typeparam>
        /// <typeparam name="T10">Func type argument 10.</typeparam>
        /// <typeparam name="T11">Func type argument 11.</typeparam>
        /// <typeparam name="T12">Func type argument 12.</typeparam>
        /// <typeparam name="TResult">Func return type.</typeparam>
        /// <param name="func">Function on which to perform partial application.</param>
        /// <param name="arg1">First argument of function.</param>
        /// <returns>Func derived from given Func by partial application of first argument.</returns>
        public static Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> 
            Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(
                this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> func,
                T1 arg1
            )
            => (arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12)
                => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);

        /// <summary>
        /// Curries the given Func returning an equivalent set of functions each taking
        /// a single argument and returning the next function in the set.
        /// </summary>
        /// <typeparam name="T1">Func type argument 1.</typeparam>
        /// <typeparam name="T2">Func type argument 2.</typeparam>
        /// <typeparam name="T3">Func type argument 3.</typeparam>
        /// <typeparam name="T4">Func type argument 4.</typeparam>
        /// <typeparam name="T5">Func type argument 5.</typeparam>
        /// <typeparam name="T6">Func type argument 6.</typeparam>
        /// <typeparam name="T7">Func type argument 7.</typeparam>
        /// <typeparam name="T8">Func type argument 8.</typeparam>
        /// <typeparam name="T9">Func type argument 9.</typeparam>
        /// <typeparam name="T10">Func type argument 10.</typeparam>
        /// <typeparam name="T11">Func type argument 11.</typeparam>
        /// <typeparam name="T12">Func type argument 12.</typeparam>
        /// <typeparam name="TResult">Func return type.</typeparam>
        /// <param name="func">Function to curry.</param>
        /// <returns>Curried function.</returns>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, TResult>>>>>>>>>>>>
            Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(
                this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> func
            )
            => arg1 => arg2 => arg3 => arg4 => arg5 => arg6 => arg7 => arg8 => arg9 => arg10 => arg11 => arg12 => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);

        /// <summary>
        /// Applies the first argument to the given Func and returns a new Func
        /// derived from the partial application.
        /// </summary>
        /// <typeparam name="T1">Func type argument 1.</typeparam>
        /// <typeparam name="T2">Func type argument 2.</typeparam>
        /// <typeparam name="T3">Func type argument 3.</typeparam>
        /// <typeparam name="T4">Func type argument 4.</typeparam>
        /// <typeparam name="T5">Func type argument 5.</typeparam>
        /// <typeparam name="T6">Func type argument 6.</typeparam>
        /// <typeparam name="T7">Func type argument 7.</typeparam>
        /// <typeparam name="T8">Func type argument 8.</typeparam>
        /// <typeparam name="T9">Func type argument 9.</typeparam>
        /// <typeparam name="T10">Func type argument 10.</typeparam>
        /// <typeparam name="T11">Func type argument 11.</typeparam>
        /// <typeparam name="T12">Func type argument 12.</typeparam>
        /// <typeparam name="T13">Func type argument 13.</typeparam>
        /// <typeparam name="TResult">Func return type.</typeparam>
        /// <param name="func">Function on which to perform partial application.</param>
        /// <param name="arg1">First argument of function.</param>
        /// <returns>Func derived from given Func by partial application of first argument.</returns>
        public static Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> 
            Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(
                this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> func,
                T1 arg1
            )
            => (arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13)
                => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);

        /// <summary>
        /// Curries the given Func returning an equivalent set of functions each taking
        /// a single argument and returning the next function in the set.
        /// </summary>
        /// <typeparam name="T1">Func type argument 1.</typeparam>
        /// <typeparam name="T2">Func type argument 2.</typeparam>
        /// <typeparam name="T3">Func type argument 3.</typeparam>
        /// <typeparam name="T4">Func type argument 4.</typeparam>
        /// <typeparam name="T5">Func type argument 5.</typeparam>
        /// <typeparam name="T6">Func type argument 6.</typeparam>
        /// <typeparam name="T7">Func type argument 7.</typeparam>
        /// <typeparam name="T8">Func type argument 8.</typeparam>
        /// <typeparam name="T9">Func type argument 9.</typeparam>
        /// <typeparam name="T10">Func type argument 10.</typeparam>
        /// <typeparam name="T11">Func type argument 11.</typeparam>
        /// <typeparam name="T12">Func type argument 12.</typeparam>
        /// <typeparam name="T13">Func type argument 13.</typeparam>
        /// <typeparam name="TResult">Func return type.</typeparam>
        /// <param name="func">Function to curry.</param>
        /// <returns>Curried function.</returns>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, TResult>>>>>>>>>>>>>
            Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(
                this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> func
            )
            => arg1 => arg2 => arg3 => arg4 => arg5 => arg6 => arg7 => arg8 => arg9 => arg10 => arg11 => arg12 => arg13 => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);

        /// <summary>
        /// Applies the first argument to the given Func and returns a new Func
        /// derived from the partial application.
        /// </summary>
        /// <typeparam name="T1">Func type argument 1.</typeparam>
        /// <typeparam name="T2">Func type argument 2.</typeparam>
        /// <typeparam name="T3">Func type argument 3.</typeparam>
        /// <typeparam name="T4">Func type argument 4.</typeparam>
        /// <typeparam name="T5">Func type argument 5.</typeparam>
        /// <typeparam name="T6">Func type argument 6.</typeparam>
        /// <typeparam name="T7">Func type argument 7.</typeparam>
        /// <typeparam name="T8">Func type argument 8.</typeparam>
        /// <typeparam name="T9">Func type argument 9.</typeparam>
        /// <typeparam name="T10">Func type argument 10.</typeparam>
        /// <typeparam name="T11">Func type argument 11.</typeparam>
        /// <typeparam name="T12">Func type argument 12.</typeparam>
        /// <typeparam name="T13">Func type argument 13.</typeparam>
        /// <typeparam name="T14">Func type argument 14.</typeparam>
        /// <typeparam name="TResult">Func return type.</typeparam>
        /// <param name="func">Function on which to perform partial application.</param>
        /// <param name="arg1">First argument of function.</param>
        /// <returns>Func derived from given Func by partial application of first argument.</returns>
        public static Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> 
            Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(
                this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> func,
                T1 arg1
            )
            => (arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14)
                => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);

        /// <summary>
        /// Curries the given Func returning an equivalent set of functions each taking
        /// a single argument and returning the next function in the set.
        /// </summary>
        /// <typeparam name="T1">Func type argument 1.</typeparam>
        /// <typeparam name="T2">Func type argument 2.</typeparam>
        /// <typeparam name="T3">Func type argument 3.</typeparam>
        /// <typeparam name="T4">Func type argument 4.</typeparam>
        /// <typeparam name="T5">Func type argument 5.</typeparam>
        /// <typeparam name="T6">Func type argument 6.</typeparam>
        /// <typeparam name="T7">Func type argument 7.</typeparam>
        /// <typeparam name="T8">Func type argument 8.</typeparam>
        /// <typeparam name="T9">Func type argument 9.</typeparam>
        /// <typeparam name="T10">Func type argument 10.</typeparam>
        /// <typeparam name="T11">Func type argument 11.</typeparam>
        /// <typeparam name="T12">Func type argument 12.</typeparam>
        /// <typeparam name="T13">Func type argument 13.</typeparam>
        /// <typeparam name="T14">Func type argument 14.</typeparam>
        /// <typeparam name="TResult">Func return type.</typeparam>
        /// <param name="func">Function to curry.</param>
        /// <returns>Curried function.</returns>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, TResult>>>>>>>>>>>>>>
            Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(
                this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> func
            )
            => arg1 => arg2 => arg3 => arg4 => arg5 => arg6 => arg7 => arg8 => arg9 => arg10 => arg11 => arg12 => arg13 => arg14 => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);

        /// <summary>
        /// Applies the first argument to the given Func and returns a new Func
        /// derived from the partial application.
        /// </summary>
        /// <typeparam name="T1">Func type argument 1.</typeparam>
        /// <typeparam name="T2">Func type argument 2.</typeparam>
        /// <typeparam name="T3">Func type argument 3.</typeparam>
        /// <typeparam name="T4">Func type argument 4.</typeparam>
        /// <typeparam name="T5">Func type argument 5.</typeparam>
        /// <typeparam name="T6">Func type argument 6.</typeparam>
        /// <typeparam name="T7">Func type argument 7.</typeparam>
        /// <typeparam name="T8">Func type argument 8.</typeparam>
        /// <typeparam name="T9">Func type argument 9.</typeparam>
        /// <typeparam name="T10">Func type argument 10.</typeparam>
        /// <typeparam name="T11">Func type argument 11.</typeparam>
        /// <typeparam name="T12">Func type argument 12.</typeparam>
        /// <typeparam name="T13">Func type argument 13.</typeparam>
        /// <typeparam name="T14">Func type argument 14.</typeparam>
        /// <typeparam name="T15">Func type argument 15.</typeparam>
        /// <typeparam name="TResult">Func return type.</typeparam>
        /// <param name="func">Function on which to perform partial application.</param>
        /// <param name="arg1">First argument of function.</param>
        /// <returns>Func derived from given Func by partial application of first argument.</returns>
        public static Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> 
            Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(
                this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> func,
                T1 arg1
            )
            => (arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15)
                => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);

        /// <summary>
        /// Curries the given Func returning an equivalent set of functions each taking
        /// a single argument and returning the next function in the set.
        /// </summary>
        /// <typeparam name="T1">Func type argument 1.</typeparam>
        /// <typeparam name="T2">Func type argument 2.</typeparam>
        /// <typeparam name="T3">Func type argument 3.</typeparam>
        /// <typeparam name="T4">Func type argument 4.</typeparam>
        /// <typeparam name="T5">Func type argument 5.</typeparam>
        /// <typeparam name="T6">Func type argument 6.</typeparam>
        /// <typeparam name="T7">Func type argument 7.</typeparam>
        /// <typeparam name="T8">Func type argument 8.</typeparam>
        /// <typeparam name="T9">Func type argument 9.</typeparam>
        /// <typeparam name="T10">Func type argument 10.</typeparam>
        /// <typeparam name="T11">Func type argument 11.</typeparam>
        /// <typeparam name="T12">Func type argument 12.</typeparam>
        /// <typeparam name="T13">Func type argument 13.</typeparam>
        /// <typeparam name="T14">Func type argument 14.</typeparam>
        /// <typeparam name="T15">Func type argument 15.</typeparam>
        /// <typeparam name="TResult">Func return type.</typeparam>
        /// <param name="func">Function to curry.</param>
        /// <returns>Curried function.</returns>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, TResult>>>>>>>>>>>>>>>
            Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(
                this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> func
            )
            => arg1 => arg2 => arg3 => arg4 => arg5 => arg6 => arg7 => arg8 => arg9 => arg10 => arg11 => arg12 => arg13 => arg14 => arg15 => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);

        /// <summary>
        /// Applies the first argument to the given Func and returns a new Func
        /// derived from the partial application.
        /// </summary>
        /// <typeparam name="T1">Func type argument 1.</typeparam>
        /// <typeparam name="T2">Func type argument 2.</typeparam>
        /// <typeparam name="T3">Func type argument 3.</typeparam>
        /// <typeparam name="T4">Func type argument 4.</typeparam>
        /// <typeparam name="T5">Func type argument 5.</typeparam>
        /// <typeparam name="T6">Func type argument 6.</typeparam>
        /// <typeparam name="T7">Func type argument 7.</typeparam>
        /// <typeparam name="T8">Func type argument 8.</typeparam>
        /// <typeparam name="T9">Func type argument 9.</typeparam>
        /// <typeparam name="T10">Func type argument 10.</typeparam>
        /// <typeparam name="T11">Func type argument 11.</typeparam>
        /// <typeparam name="T12">Func type argument 12.</typeparam>
        /// <typeparam name="T13">Func type argument 13.</typeparam>
        /// <typeparam name="T14">Func type argument 14.</typeparam>
        /// <typeparam name="T15">Func type argument 15.</typeparam>
        /// <typeparam name="T16">Func type argument 16.</typeparam>
        /// <typeparam name="TResult">Func return type.</typeparam>
        /// <param name="func">Function on which to perform partial application.</param>
        /// <param name="arg1">First argument of function.</param>
        /// <returns>Func derived from given Func by partial application of first argument.</returns>
        public static Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> 
            Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(
                this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> func,
                T1 arg1
            )
            => (arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16)
                => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);

        /// <summary>
        /// Curries the given Func returning an equivalent set of functions each taking
        /// a single argument and returning the next function in the set.
        /// </summary>
        /// <typeparam name="T1">Func type argument 1.</typeparam>
        /// <typeparam name="T2">Func type argument 2.</typeparam>
        /// <typeparam name="T3">Func type argument 3.</typeparam>
        /// <typeparam name="T4">Func type argument 4.</typeparam>
        /// <typeparam name="T5">Func type argument 5.</typeparam>
        /// <typeparam name="T6">Func type argument 6.</typeparam>
        /// <typeparam name="T7">Func type argument 7.</typeparam>
        /// <typeparam name="T8">Func type argument 8.</typeparam>
        /// <typeparam name="T9">Func type argument 9.</typeparam>
        /// <typeparam name="T10">Func type argument 10.</typeparam>
        /// <typeparam name="T11">Func type argument 11.</typeparam>
        /// <typeparam name="T12">Func type argument 12.</typeparam>
        /// <typeparam name="T13">Func type argument 13.</typeparam>
        /// <typeparam name="T14">Func type argument 14.</typeparam>
        /// <typeparam name="T15">Func type argument 15.</typeparam>
        /// <typeparam name="T16">Func type argument 16.</typeparam>
        /// <typeparam name="TResult">Func return type.</typeparam>
        /// <param name="func">Function to curry.</param>
        /// <returns>Curried function.</returns>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, Func<T16, TResult>>>>>>>>>>>>>>>>
            Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(
                this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> func
            )
            => arg1 => arg2 => arg3 => arg4 => arg5 => arg6 => arg7 => arg8 => arg9 => arg10 => arg11 => arg12 => arg13 => arg14 => arg15 => arg16 => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);

    }
}