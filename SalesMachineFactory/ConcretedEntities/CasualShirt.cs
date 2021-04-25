using SalesMachineFactory.Entities;

namespace SalesMachineFactory.ConcretedEntities
{
    public class CasualShirt : Shirt
    {

        private readonly string _brand;
        private string _size;
        private double _price;
        private int _quantitystock;


        public CasualShirt(string size, double price, int quantitystock)
        {
            this._brand = "Hollister";
            this._size = size;
            this._price = price;
            this._quantitystock = quantitystock;
        }

        public override string Brand
        {
            get { return _brand; }
        }

        public override string Size
        {
            get { return _size;  }
            set { _size = value;  }
        }

        public override double Price 
        {
            get { return _price;  }
            set { _price = value;  }
        }

        public override int QuantityStock
        {
            get { return _quantitystock; }
            set { _quantitystock = value; }
        }
    }
}
