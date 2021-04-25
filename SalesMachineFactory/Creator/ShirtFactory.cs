using SalesMachineFactory.Entities;

namespace SalesMachineFactory.Creator
{
    public abstract class ShirtFactory
    {

        public abstract Shirt SearchShirt();
        public abstract Shirt BuyShirt(string size, int quantityStock, double price);
    }
}
