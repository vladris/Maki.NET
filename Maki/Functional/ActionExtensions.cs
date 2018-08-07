using System;

namespace Maki.Functional
{
    public static class ActionExtensions
    {
        public static Func<T1, Unit>
            ToFunc<T1>(
                Action<T1> act
            )
            => (arg1)
                =>
                {
                    act(arg1);
                    return Unit.Singleton;
                };

        public static Func<T1, T2, Unit>
            ToFunc<T1, T2>(
                Action<T1, T2> act
            )
            => (arg1, arg2)
                =>
                {
                    act(arg1, arg2);
                    return Unit.Singleton;
                };

        public static Func<T1, T2, T3, Unit>
            ToFunc<T1, T2, T3>(
                Action<T1, T2, T3> act
            )
            => (arg1, arg2, arg3)
                =>
                {
                    act(arg1, arg2, arg3);
                    return Unit.Singleton;
                };

        public static Func<T1, T2, T3, T4, Unit>
            ToFunc<T1, T2, T3, T4>(
                Action<T1, T2, T3, T4> act
            )
            => (arg1, arg2, arg3, arg4)
                =>
                {
                    act(arg1, arg2, arg3, arg4);
                    return Unit.Singleton;
                };

        public static Func<T1, T2, T3, T4, T5, Unit>
            ToFunc<T1, T2, T3, T4, T5>(
                Action<T1, T2, T3, T4, T5> act
            )
            => (arg1, arg2, arg3, arg4, arg5)
                =>
                {
                    act(arg1, arg2, arg3, arg4, arg5);
                    return Unit.Singleton;
                };

        public static Func<T1, T2, T3, T4, T5, T6, Unit>
            ToFunc<T1, T2, T3, T4, T5, T6>(
                Action<T1, T2, T3, T4, T5, T6> act
            )
            => (arg1, arg2, arg3, arg4, arg5, arg6)
                =>
                {
                    act(arg1, arg2, arg3, arg4, arg5, arg6);
                    return Unit.Singleton;
                };

        public static Func<T1, T2, T3, T4, T5, T6, T7, Unit>
            ToFunc<T1, T2, T3, T4, T5, T6, T7>(
                Action<T1, T2, T3, T4, T5, T6, T7> act
            )
            => (arg1, arg2, arg3, arg4, arg5, arg6, arg7)
                =>
                {
                    act(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
                    return Unit.Singleton;
                };

        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, Unit>
            ToFunc<T1, T2, T3, T4, T5, T6, T7, T8>(
                Action<T1, T2, T3, T4, T5, T6, T7, T8> act
            )
            => (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8)
                =>
                {
                    act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
                    return Unit.Singleton;
                };

        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Unit>
            ToFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
                Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> act
            )
            => (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9)
                =>
                {
                    act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
                    return Unit.Singleton;
                };

        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Unit>
            ToFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
                Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> act
            )
            => (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10)
                =>
                {
                    act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
                    return Unit.Singleton;
                };

        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Unit>
            ToFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
                Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> act
            )
            => (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11)
                =>
                {
                    act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
                    return Unit.Singleton;
                };

        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Unit>
            ToFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
                Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> act
            )
            => (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12)
                =>
                {
                    act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
                    return Unit.Singleton;
                };

        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Unit>
            ToFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
                Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> act
            )
            => (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13)
                =>
                {
                    act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
                    return Unit.Singleton;
                };

        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Unit>
            ToFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
                Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> act
            )
            => (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14)
                =>
                {
                    act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
                    return Unit.Singleton;
                };

        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Unit>
            ToFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
                Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> act
            )
            => (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15)
                =>
                {
                    act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
                    return Unit.Singleton;
                };

        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Unit>
            ToFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
                Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> act
            )
            => (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16)
                =>
                {
                    act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
                    return Unit.Singleton;
                };

    }
}