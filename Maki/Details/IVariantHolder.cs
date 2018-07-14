namespace Maki.Details
{
    interface IVariantHolder
    {
        int Index { get; }

        bool Is<T>();

        dynamic GetDynamic();
    }
}
