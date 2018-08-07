using System;

namespace Maki.Functional
{
    /// <summary>
    /// Provides Action extension methods for converting any Action to an equivalent Func
    /// which returns a Unit. With such a conversion, Action and Func can be treated uniformly.
    /// </summary>
    public static class ActionExtensions
    {
        /// <summary>
        /// Converts an Action to an equivalent Func returning a Unit.
        /// </summary>
        /// <typeparam name="T1">Action generic type 1.</typeparam>
        /// <param name="act">Action to convert to Func.</param>
        /// <returns>Func returning a Unit.</returns>
        public static Func<T1, Unit>
            ToFunc<T1>(
                this Action<T1> act
            )
            => (arg1)
                =>
                {
                    act(arg1);
                    return Unit.Singleton;
                };

        /// <summary>
        /// Converts an Action to an equivalent Func returning a Unit.
        /// </summary>
        /// <typeparam name="T1">Action generic type 1.</typeparam>
        /// <typeparam name="T2">Action generic type 2.</typeparam>
        /// <param name="act">Action to convert to Func.</param>
        /// <returns>Func returning a Unit.</returns>
        public static Func<T1, T2, Unit>
            ToFunc<T1, T2>(
                this Action<T1, T2> act
            )
            => (arg1, arg2)
                =>
                {
                    act(arg1, arg2);
                    return Unit.Singleton;
                };

        /// <summary>
        /// Converts an Action to an equivalent Func returning a Unit.
        /// </summary>
        /// <typeparam name="T1">Action generic type 1.</typeparam>
        /// <typeparam name="T2">Action generic type 2.</typeparam>
        /// <typeparam name="T3">Action generic type 3.</typeparam>
        /// <param name="act">Action to convert to Func.</param>
        /// <returns>Func returning a Unit.</returns>
        public static Func<T1, T2, T3, Unit>
            ToFunc<T1, T2, T3>(
                this Action<T1, T2, T3> act
            )
            => (arg1, arg2, arg3)
                =>
                {
                    act(arg1, arg2, arg3);
                    return Unit.Singleton;
                };

        /// <summary>
        /// Converts an Action to an equivalent Func returning a Unit.
        /// </summary>
        /// <typeparam name="T1">Action generic type 1.</typeparam>
        /// <typeparam name="T2">Action generic type 2.</typeparam>
        /// <typeparam name="T3">Action generic type 3.</typeparam>
        /// <typeparam name="T4">Action generic type 4.</typeparam>
        /// <param name="act">Action to convert to Func.</param>
        /// <returns>Func returning a Unit.</returns>
        public static Func<T1, T2, T3, T4, Unit>
            ToFunc<T1, T2, T3, T4>(
                this Action<T1, T2, T3, T4> act
            )
            => (arg1, arg2, arg3, arg4)
                =>
                {
                    act(arg1, arg2, arg3, arg4);
                    return Unit.Singleton;
                };

        /// <summary>
        /// Converts an Action to an equivalent Func returning a Unit.
        /// </summary>
        /// <typeparam name="T1">Action generic type 1.</typeparam>
        /// <typeparam name="T2">Action generic type 2.</typeparam>
        /// <typeparam name="T3">Action generic type 3.</typeparam>
        /// <typeparam name="T4">Action generic type 4.</typeparam>
        /// <typeparam name="T5">Action generic type 5.</typeparam>
        /// <param name="act">Action to convert to Func.</param>
        /// <returns>Func returning a Unit.</returns>
        public static Func<T1, T2, T3, T4, T5, Unit>
            ToFunc<T1, T2, T3, T4, T5>(
                this Action<T1, T2, T3, T4, T5> act
            )
            => (arg1, arg2, arg3, arg4, arg5)
                =>
                {
                    act(arg1, arg2, arg3, arg4, arg5);
                    return Unit.Singleton;
                };

        /// <summary>
        /// Converts an Action to an equivalent Func returning a Unit.
        /// </summary>
        /// <typeparam name="T1">Action generic type 1.</typeparam>
        /// <typeparam name="T2">Action generic type 2.</typeparam>
        /// <typeparam name="T3">Action generic type 3.</typeparam>
        /// <typeparam name="T4">Action generic type 4.</typeparam>
        /// <typeparam name="T5">Action generic type 5.</typeparam>
        /// <typeparam name="T6">Action generic type 6.</typeparam>
        /// <param name="act">Action to convert to Func.</param>
        /// <returns>Func returning a Unit.</returns>
        public static Func<T1, T2, T3, T4, T5, T6, Unit>
            ToFunc<T1, T2, T3, T4, T5, T6>(
                this Action<T1, T2, T3, T4, T5, T6> act
            )
            => (arg1, arg2, arg3, arg4, arg5, arg6)
                =>
                {
                    act(arg1, arg2, arg3, arg4, arg5, arg6);
                    return Unit.Singleton;
                };

        /// <summary>
        /// Converts an Action to an equivalent Func returning a Unit.
        /// </summary>
        /// <typeparam name="T1">Action generic type 1.</typeparam>
        /// <typeparam name="T2">Action generic type 2.</typeparam>
        /// <typeparam name="T3">Action generic type 3.</typeparam>
        /// <typeparam name="T4">Action generic type 4.</typeparam>
        /// <typeparam name="T5">Action generic type 5.</typeparam>
        /// <typeparam name="T6">Action generic type 6.</typeparam>
        /// <typeparam name="T7">Action generic type 7.</typeparam>
        /// <param name="act">Action to convert to Func.</param>
        /// <returns>Func returning a Unit.</returns>
        public static Func<T1, T2, T3, T4, T5, T6, T7, Unit>
            ToFunc<T1, T2, T3, T4, T5, T6, T7>(
                this Action<T1, T2, T3, T4, T5, T6, T7> act
            )
            => (arg1, arg2, arg3, arg4, arg5, arg6, arg7)
                =>
                {
                    act(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
                    return Unit.Singleton;
                };

        /// <summary>
        /// Converts an Action to an equivalent Func returning a Unit.
        /// </summary>
        /// <typeparam name="T1">Action generic type 1.</typeparam>
        /// <typeparam name="T2">Action generic type 2.</typeparam>
        /// <typeparam name="T3">Action generic type 3.</typeparam>
        /// <typeparam name="T4">Action generic type 4.</typeparam>
        /// <typeparam name="T5">Action generic type 5.</typeparam>
        /// <typeparam name="T6">Action generic type 6.</typeparam>
        /// <typeparam name="T7">Action generic type 7.</typeparam>
        /// <typeparam name="T8">Action generic type 8.</typeparam>
        /// <param name="act">Action to convert to Func.</param>
        /// <returns>Func returning a Unit.</returns>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, Unit>
            ToFunc<T1, T2, T3, T4, T5, T6, T7, T8>(
                this Action<T1, T2, T3, T4, T5, T6, T7, T8> act
            )
            => (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8)
                =>
                {
                    act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
                    return Unit.Singleton;
                };

        /// <summary>
        /// Converts an Action to an equivalent Func returning a Unit.
        /// </summary>
        /// <typeparam name="T1">Action generic type 1.</typeparam>
        /// <typeparam name="T2">Action generic type 2.</typeparam>
        /// <typeparam name="T3">Action generic type 3.</typeparam>
        /// <typeparam name="T4">Action generic type 4.</typeparam>
        /// <typeparam name="T5">Action generic type 5.</typeparam>
        /// <typeparam name="T6">Action generic type 6.</typeparam>
        /// <typeparam name="T7">Action generic type 7.</typeparam>
        /// <typeparam name="T8">Action generic type 8.</typeparam>
        /// <typeparam name="T9">Action generic type 9.</typeparam>
        /// <param name="act">Action to convert to Func.</param>
        /// <returns>Func returning a Unit.</returns>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Unit>
            ToFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
                this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> act
            )
            => (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9)
                =>
                {
                    act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
                    return Unit.Singleton;
                };

        /// <summary>
        /// Converts an Action to an equivalent Func returning a Unit.
        /// </summary>
        /// <typeparam name="T1">Action generic type 1.</typeparam>
        /// <typeparam name="T2">Action generic type 2.</typeparam>
        /// <typeparam name="T3">Action generic type 3.</typeparam>
        /// <typeparam name="T4">Action generic type 4.</typeparam>
        /// <typeparam name="T5">Action generic type 5.</typeparam>
        /// <typeparam name="T6">Action generic type 6.</typeparam>
        /// <typeparam name="T7">Action generic type 7.</typeparam>
        /// <typeparam name="T8">Action generic type 8.</typeparam>
        /// <typeparam name="T9">Action generic type 9.</typeparam>
        /// <typeparam name="T10">Action generic type 10.</typeparam>
        /// <param name="act">Action to convert to Func.</param>
        /// <returns>Func returning a Unit.</returns>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Unit>
            ToFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
                this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> act
            )
            => (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10)
                =>
                {
                    act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
                    return Unit.Singleton;
                };

        /// <summary>
        /// Converts an Action to an equivalent Func returning a Unit.
        /// </summary>
        /// <typeparam name="T1">Action generic type 1.</typeparam>
        /// <typeparam name="T2">Action generic type 2.</typeparam>
        /// <typeparam name="T3">Action generic type 3.</typeparam>
        /// <typeparam name="T4">Action generic type 4.</typeparam>
        /// <typeparam name="T5">Action generic type 5.</typeparam>
        /// <typeparam name="T6">Action generic type 6.</typeparam>
        /// <typeparam name="T7">Action generic type 7.</typeparam>
        /// <typeparam name="T8">Action generic type 8.</typeparam>
        /// <typeparam name="T9">Action generic type 9.</typeparam>
        /// <typeparam name="T10">Action generic type 10.</typeparam>
        /// <typeparam name="T11">Action generic type 11.</typeparam>
        /// <param name="act">Action to convert to Func.</param>
        /// <returns>Func returning a Unit.</returns>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Unit>
            ToFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
                this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> act
            )
            => (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11)
                =>
                {
                    act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
                    return Unit.Singleton;
                };

        /// <summary>
        /// Converts an Action to an equivalent Func returning a Unit.
        /// </summary>
        /// <typeparam name="T1">Action generic type 1.</typeparam>
        /// <typeparam name="T2">Action generic type 2.</typeparam>
        /// <typeparam name="T3">Action generic type 3.</typeparam>
        /// <typeparam name="T4">Action generic type 4.</typeparam>
        /// <typeparam name="T5">Action generic type 5.</typeparam>
        /// <typeparam name="T6">Action generic type 6.</typeparam>
        /// <typeparam name="T7">Action generic type 7.</typeparam>
        /// <typeparam name="T8">Action generic type 8.</typeparam>
        /// <typeparam name="T9">Action generic type 9.</typeparam>
        /// <typeparam name="T10">Action generic type 10.</typeparam>
        /// <typeparam name="T11">Action generic type 11.</typeparam>
        /// <typeparam name="T12">Action generic type 12.</typeparam>
        /// <param name="act">Action to convert to Func.</param>
        /// <returns>Func returning a Unit.</returns>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Unit>
            ToFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
                this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> act
            )
            => (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12)
                =>
                {
                    act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
                    return Unit.Singleton;
                };

        /// <summary>
        /// Converts an Action to an equivalent Func returning a Unit.
        /// </summary>
        /// <typeparam name="T1">Action generic type 1.</typeparam>
        /// <typeparam name="T2">Action generic type 2.</typeparam>
        /// <typeparam name="T3">Action generic type 3.</typeparam>
        /// <typeparam name="T4">Action generic type 4.</typeparam>
        /// <typeparam name="T5">Action generic type 5.</typeparam>
        /// <typeparam name="T6">Action generic type 6.</typeparam>
        /// <typeparam name="T7">Action generic type 7.</typeparam>
        /// <typeparam name="T8">Action generic type 8.</typeparam>
        /// <typeparam name="T9">Action generic type 9.</typeparam>
        /// <typeparam name="T10">Action generic type 10.</typeparam>
        /// <typeparam name="T11">Action generic type 11.</typeparam>
        /// <typeparam name="T12">Action generic type 12.</typeparam>
        /// <typeparam name="T13">Action generic type 13.</typeparam>
        /// <param name="act">Action to convert to Func.</param>
        /// <returns>Func returning a Unit.</returns>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Unit>
            ToFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
                this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> act
            )
            => (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13)
                =>
                {
                    act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
                    return Unit.Singleton;
                };

        /// <summary>
        /// Converts an Action to an equivalent Func returning a Unit.
        /// </summary>
        /// <typeparam name="T1">Action generic type 1.</typeparam>
        /// <typeparam name="T2">Action generic type 2.</typeparam>
        /// <typeparam name="T3">Action generic type 3.</typeparam>
        /// <typeparam name="T4">Action generic type 4.</typeparam>
        /// <typeparam name="T5">Action generic type 5.</typeparam>
        /// <typeparam name="T6">Action generic type 6.</typeparam>
        /// <typeparam name="T7">Action generic type 7.</typeparam>
        /// <typeparam name="T8">Action generic type 8.</typeparam>
        /// <typeparam name="T9">Action generic type 9.</typeparam>
        /// <typeparam name="T10">Action generic type 10.</typeparam>
        /// <typeparam name="T11">Action generic type 11.</typeparam>
        /// <typeparam name="T12">Action generic type 12.</typeparam>
        /// <typeparam name="T13">Action generic type 13.</typeparam>
        /// <typeparam name="T14">Action generic type 14.</typeparam>
        /// <param name="act">Action to convert to Func.</param>
        /// <returns>Func returning a Unit.</returns>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Unit>
            ToFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
                this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> act
            )
            => (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14)
                =>
                {
                    act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
                    return Unit.Singleton;
                };

        /// <summary>
        /// Converts an Action to an equivalent Func returning a Unit.
        /// </summary>
        /// <typeparam name="T1">Action generic type 1.</typeparam>
        /// <typeparam name="T2">Action generic type 2.</typeparam>
        /// <typeparam name="T3">Action generic type 3.</typeparam>
        /// <typeparam name="T4">Action generic type 4.</typeparam>
        /// <typeparam name="T5">Action generic type 5.</typeparam>
        /// <typeparam name="T6">Action generic type 6.</typeparam>
        /// <typeparam name="T7">Action generic type 7.</typeparam>
        /// <typeparam name="T8">Action generic type 8.</typeparam>
        /// <typeparam name="T9">Action generic type 9.</typeparam>
        /// <typeparam name="T10">Action generic type 10.</typeparam>
        /// <typeparam name="T11">Action generic type 11.</typeparam>
        /// <typeparam name="T12">Action generic type 12.</typeparam>
        /// <typeparam name="T13">Action generic type 13.</typeparam>
        /// <typeparam name="T14">Action generic type 14.</typeparam>
        /// <typeparam name="T15">Action generic type 15.</typeparam>
        /// <param name="act">Action to convert to Func.</param>
        /// <returns>Func returning a Unit.</returns>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Unit>
            ToFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
                this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> act
            )
            => (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15)
                =>
                {
                    act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
                    return Unit.Singleton;
                };

        /// <summary>
        /// Converts an Action to an equivalent Func returning a Unit.
        /// </summary>
        /// <typeparam name="T1">Action generic type 1.</typeparam>
        /// <typeparam name="T2">Action generic type 2.</typeparam>
        /// <typeparam name="T3">Action generic type 3.</typeparam>
        /// <typeparam name="T4">Action generic type 4.</typeparam>
        /// <typeparam name="T5">Action generic type 5.</typeparam>
        /// <typeparam name="T6">Action generic type 6.</typeparam>
        /// <typeparam name="T7">Action generic type 7.</typeparam>
        /// <typeparam name="T8">Action generic type 8.</typeparam>
        /// <typeparam name="T9">Action generic type 9.</typeparam>
        /// <typeparam name="T10">Action generic type 10.</typeparam>
        /// <typeparam name="T11">Action generic type 11.</typeparam>
        /// <typeparam name="T12">Action generic type 12.</typeparam>
        /// <typeparam name="T13">Action generic type 13.</typeparam>
        /// <typeparam name="T14">Action generic type 14.</typeparam>
        /// <typeparam name="T15">Action generic type 15.</typeparam>
        /// <typeparam name="T16">Action generic type 16.</typeparam>
        /// <param name="act">Action to convert to Func.</param>
        /// <returns>Func returning a Unit.</returns>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Unit>
            ToFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
                this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> act
            )
            => (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16)
                =>
                {
                    act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
                    return Unit.Singleton;
                };

    }
}