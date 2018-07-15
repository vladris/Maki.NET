namespace Maki.Details
{
    interface IVariantHolder
    {
        bool Is<T>();

        object Get();
    }
}
