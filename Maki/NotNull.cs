using System;
using System.Collections.Generic;
using System.Text;

namespace Maki
{
    public struct NotNull<T>
    {
        public T Item { get; }

        public NotNull(T item)
        {
            if (item == null)
            {
                throw new ArgumentNullException();
            }

            Item = item;
        }

        public static implicit operator T(NotNull<T> notNull) => notNull.Item;

        public static implicit operator NotNull<T>(T item) => new NotNull<T>(item);
    }
}
