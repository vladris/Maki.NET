﻿namespace Maki.Details
{
    interface IVariantHolder
    {
        int Index { get; }

        bool Is<T>();

        object Get();
    }
}
