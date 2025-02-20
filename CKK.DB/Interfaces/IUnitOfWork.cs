namespace CKK.DB.Interfaces
{
    interface IUnitOfWork
    {
        IProductRepository Products { get; }
        IOrderRepository Orders { get; }
        IShoppingCartRepository ShoppingCarts { get; }
    }
}
