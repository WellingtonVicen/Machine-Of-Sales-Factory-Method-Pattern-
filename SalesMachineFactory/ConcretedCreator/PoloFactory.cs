using SalesMachineFactory.ConcretedEntities;
using SalesMachineFactory.Creator;
using SalesMachineFactory.Entities;
using System;
using System.Globalization;

namespace SalesMachineFactory.ConcretedCreator
{
    public class PoloFactory: ShirtFactory
    {

        private string _size;
        private double _price;
        private int _quantityStock;

        public PoloFactory()
        {
        }

        public PoloFactory(string size, double price, int quantityStock)
        {
            _size = size;
            _price = price;
            _quantityStock = quantityStock;
        }

        public override Shirt SearchShirt()
        {
            return new PoloShirt(_size, _price, _quantityStock);
        }

        public override Shirt BuyShirt(string size, int quantityStock,  double price)
        {
            
            Console.Write("Digite a quantidade desejada: ");
            int quantity = int.Parse(Console.ReadLine());

            if(quantity <= quantityStock)
            {
                this._size = size;
                this._quantityStock = quantityStock;
                this._price = price;

                double total = quantity * price;
                Console.WriteLine("Valor a Pagar R$: " +  total.ToString("F2"), CultureInfo.InvariantCulture);
                Console.Write("Digite o valor do deposito R$: ");

                double deposit = double.Parse(Console.ReadLine());

                if(deposit < total)
                {
                    while(deposit < total)
                    {
                        double remaining = total - deposit;
                        Console.WriteLine("Insira o valor restante para finalizar a compra R$: " + remaining.ToString("F2"), CultureInfo.InvariantCulture);

                        double remainin = double.Parse(Console.ReadLine());
                        deposit += remainin;

                        Console.WriteLine();

                        if(deposit == total)
                        {
                            Console.WriteLine("Compra Concluida!! Volte Sempre");
                            Console.WriteLine();
                            _quantityStock = quantityStock - quantity;
                            return new PoloShirt(size, price, _quantityStock);
                        }
                    }

                }
                else if(deposit == total)
                {
                    Console.WriteLine("Compra concluida !! Volte sempre");
                    Console.WriteLine();
                    _quantityStock = quantityStock - quantity;
                    return new PoloShirt(size, price, _quantityStock);
                }
                else if(deposit > total)
                {
                    double thing = deposit - total;
                    Console.WriteLine("Seu troco é R$: " +  thing.ToString("F2"), CultureInfo.InvariantCulture);
                    Console.WriteLine("Compra Concluida!! Volte Sempre");
                    _quantityStock = quantityStock - quantity;
                    Console.WriteLine();
                    return new PoloShirt(size, price, _quantityStock);
                }

            }
            else
            {
                Console.WriteLine("Não Temos a Quantidade que deseja Disponivel\n");
            }

            return new PoloShirt(size, price, _quantityStock);


        }
    }
}
