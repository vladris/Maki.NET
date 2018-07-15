using System;

namespace Maki.Details
{
    class VariantHolder<T> : IVariantHolder
    {
        public T Item { get; }

        public bool Is<U>() => typeof(U) == typeof(T);

        public object Get() => Item;

        public VariantHolder(T item) => Item = item;
    }
}
