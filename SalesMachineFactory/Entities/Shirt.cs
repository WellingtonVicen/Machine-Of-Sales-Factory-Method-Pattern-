namespace SalesMachineFactory.Entities
{
    public abstract class Shirt
    {
        public abstract string Brand { get; }
        public abstract string  Size { get; set; }
        public abstract double Price { get; set; }
        public abstract int QuantityStock { get; set; }

        protected Shirt()
        {
        }

        protected Shirt(string size, double price, int quantityStock)
        {
            Size = size;
            Price = price;
            QuantityStock = quantityStock;
        }
    }
}
