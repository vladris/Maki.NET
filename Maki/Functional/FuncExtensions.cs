using System;

namespace Maki.Functional
{
    public static class FuncExtensions
    {
        public static Func<T2, TResult> 
            Curry<T1, T2, TResult>(
                this Func<T1, T2, TResult> func,
                T1 arg1
            )
            => (arg2)
                => func(arg1, arg2);

        public static Func<T1, Func<T2, TResult>>
            Curry<T1, T2, TResult>(
                this Func<T1, T2, TResult> func
            )
            => arg1 => arg2 => func(arg1, arg2);

        public static Func<T2, T3, TResult> 
            Curry<T1, T2, T3, TResult>(
                this Func<T1, T2, T3, TResult> func,
                T1 arg1
            )
            => (arg2, arg3)
                => func(arg1, arg2, arg3);

        public static Func<T1, Func<T2, Func<T3, TResult>>>
            Curry<T1, T2, T3, TResult>(
                this Func<T1, T2, T3, TResult> func
            )
            => arg1 => arg2 => arg3 => func(arg1, arg2, arg3);

        public static Func<T2, T3, T4, TResult> 
            Curry<T1, T2, T3, T4, TResult>(
                this Func<T1, T2, T3, T4, TResult> func,
                T1 arg1
            )
            => (arg2, arg3, arg4)
                => func(arg1, arg2, arg3, arg4);

        public static Func<T1, Func<T2, Func<T3, Func<T4, TResult>>>>
            Curry<T1, T2, T3, T4, TResult>(
                this Func<T1, T2, T3, T4, TResult> func
            )
            => arg1 => arg2 => arg3 => arg4 => func(arg1, arg2, arg3, arg4);

        public static Func<T2, T3, T4, T5, TResult> 
            Curry<T1, T2, T3, T4, T5, TResult>(
                this Func<T1, T2, T3, T4, T5, TResult> func,
                T1 arg1
            )
            => (arg2, arg3, arg4, arg5)
                => func(arg1, arg2, arg3, arg4, arg5);

        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, TResult>>>>>
            Curry<T1, T2, T3, T4, T5, TResult>(
                this Func<T1, T2, T3, T4, T5, TResult> func
            )
            => arg1 => arg2 => arg3 => arg4 => arg5 => func(arg1, arg2, arg3, arg4, arg5);

        public static Func<T2, T3, T4, T5, T6, TResult> 
            Curry<T1, T2, T3, T4, T5, T6, TResult>(
                this Func<T1, T2, T3, T4, T5, T6, TResult> func,
                T1 arg1
            )
            => (arg2, arg3, arg4, arg5, arg6)
                => func(arg1, arg2, arg3, arg4, arg5, arg6);

        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, TResult>>>>>>
            Curry<T1, T2, T3, T4, T5, T6, TResult>(
                this Func<T1, T2, T3, T4, T5, T6, TResult> func
            )
            => arg1 => arg2 => arg3 => arg4 => arg5 => arg6 => func(arg1, arg2, arg3, arg4, arg5, arg6);

        public static Func<T2, T3, T4, T5, T6, T7, TResult> 
            Curry<T1, T2, T3, T4, T5, T6, T7, TResult>(
                this Func<T1, T2, T3, T4, T5, T6, T7, TResult> func,
                T1 arg1
            )
            => (arg2, arg3, arg4, arg5, arg6, arg7)
                => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7);

        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, TResult>>>>>>>
            Curry<T1, T2, T3, T4, T5, T6, T7, TResult>(
                this Func<T1, T2, T3, T4, T5, T6, T7, TResult> func
            )
            => arg1 => arg2 => arg3 => arg4 => arg5 => arg6 => arg7 => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7);

        public static Func<T2, T3, T4, T5, T6, T7, T8, TResult> 
            Curry<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
                this Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> func,
                T1 arg1
            )
            => (arg2, arg3, arg4, arg5, arg6, arg7, arg8)
                => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);

        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, TResult>>>>>>>>
            Curry<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
                this Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> func
            )
            => arg1 => arg2 => arg3 => arg4 => arg5 => arg6 => arg7 => arg8 => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);

        public static Func<T2, T3, T4, T5, T6, T7, T8, T9, TResult> 
            Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
                this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> func,
                T1 arg1
            )
            => (arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9)
                => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);

        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, TResult>>>>>>>>>
            Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
                this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> func
            )
            => arg1 => arg2 => arg3 => arg4 => arg5 => arg6 => arg7 => arg8 => arg9 => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);

        public static Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> 
            Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
                this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> func,
                T1 arg1
            )
            => (arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10)
                => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);

        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, TResult>>>>>>>>>>
            Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
                this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> func
            )
            => arg1 => arg2 => arg3 => arg4 => arg5 => arg6 => arg7 => arg8 => arg9 => arg10 => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);

        public static Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> 
            Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(
                this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> func,
                T1 arg1
            )
            => (arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11)
                => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);

        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, TResult>>>>>>>>>>>
            Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(
                this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> func
            )
            => arg1 => arg2 => arg3 => arg4 => arg5 => arg6 => arg7 => arg8 => arg9 => arg10 => arg11 => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);

        public static Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> 
            Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(
                this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> func,
                T1 arg1
            )
            => (arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12)
                => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);

        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, TResult>>>>>>>>>>>>
            Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(
                this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> func
            )
            => arg1 => arg2 => arg3 => arg4 => arg5 => arg6 => arg7 => arg8 => arg9 => arg10 => arg11 => arg12 => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);

        public static Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> 
            Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(
                this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> func,
                T1 arg1
            )
            => (arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13)
                => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);

        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, TResult>>>>>>>>>>>>>
            Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(
                this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> func
            )
            => arg1 => arg2 => arg3 => arg4 => arg5 => arg6 => arg7 => arg8 => arg9 => arg10 => arg11 => arg12 => arg13 => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);

        public static Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> 
            Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(
                this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> func,
                T1 arg1
            )
            => (arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14)
                => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);

        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, TResult>>>>>>>>>>>>>>
            Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(
                this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> func
            )
            => arg1 => arg2 => arg3 => arg4 => arg5 => arg6 => arg7 => arg8 => arg9 => arg10 => arg11 => arg12 => arg13 => arg14 => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);

        public static Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> 
            Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(
                this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> func,
                T1 arg1
            )
            => (arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15)
                => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);

        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, TResult>>>>>>>>>>>>>>>
            Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(
                this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> func
            )
            => arg1 => arg2 => arg3 => arg4 => arg5 => arg6 => arg7 => arg8 => arg9 => arg10 => arg11 => arg12 => arg13 => arg14 => arg15 => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);

        public static Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> 
            Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(
                this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> func,
                T1 arg1
            )
            => (arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16)
                => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);

        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, Func<T16, TResult>>>>>>>>>>>>>>>>
            Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(
                this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> func
            )
            => arg1 => arg2 => arg3 => arg4 => arg5 => arg6 => arg7 => arg8 => arg9 => arg10 => arg11 => arg12 => arg13 => arg14 => arg15 => arg16 => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);

    }
}