using System;

namespace Maki.Details
{
    class VariantHolder<T> : IVariantHolder
    {
        public T Item { get; }

        public int Index { get; }

        public bool Is<U>() => typeof(U) == typeof(T);

        public dynamic GetDynamic() => Item;

        private VariantHolder(T item, int index)
        {
            Item = item;
            Index = index;
        }

        public static VariantHolder<T1> T1<T1>(T1 item) => new VariantHolder<T1>(item, 0);

        public static VariantHolder<T2> T2<T2>(T2 item) => new VariantHolder<T2>(item, 1);

        public static VariantHolder<T3> T3<T3>(T3 item) => new VariantHolder<T3>(item, 2);

        public static VariantHolder<T4> T4<T4>(T4 item) => new VariantHolder<T4>(item, 3);

        public static VariantHolder<T5> T5<T5>(T5 item) => new VariantHolder<T5>(item, 4);

        public static VariantHolder<T6> T6<T6>(T6 item) => new VariantHolder<T6>(item, 5);

        public static VariantHolder<T7> T7<T7>(T7 item) => new VariantHolder<T7>(item, 6);

        public static VariantHolder<T8> T8<T8>(T8 item) => new VariantHolder<T8>(item, 7);
    }
}
