using SalesMachineFactory.ConcretedCreator;
using SalesMachineFactory.Creator;
using SalesMachineFactory.Entities;
using System;

namespace SalesMachineFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            ShirtFactory casualFactory = null;
            ShirtFactory poloFactory = null;
            ShirtFactory socialFactory = null;

            for (; ; )
            {

                Console.WriteLine("Welcome Shirt Machine");
                Console.WriteLine("-----------------------");
                Console.WriteLine();

                Console.WriteLine("Digite o estilo da camisa");
                Console.Write("Casual, Polo ou Social: ");

                string shirtModel = Console.ReadLine();

                switch (shirtModel.ToLower())
                {
                    case "casual":
                        if (casualFactory == null)
                        {
                            casualFactory = new CasualFactory("M", 259.99, 10);
                        }

                        Shirt shirt = casualFactory.SearchShirt();
                        Console.WriteLine("\nDetalhes da camisa solicitada:\n");
                        Console.WriteLine("Marca: {0}\nTamanho:{1}\nPreço: {2}\nQuantidade em Stock: {3}",
                        shirt.Brand, shirt.Size, shirt.Price, shirt.QuantityStock);

                        Console.WriteLine("\n");
                        Console.Write("Deseja realizar a compra da Camisa (s/n) ? ");

                        string resp = Console.ReadLine();

                        if (resp == "S" || resp == "s")
                        {
                            casualFactory.BuyShirt(shirt.Size, shirt.QuantityStock, shirt.Price);
                        }
                        else
                        {
                            Console.WriteLine("Retornando.....\n");
                            break;
                        }
                        break;
                    case "polo":
                        if (poloFactory == null)
                        {
                            poloFactory = new PoloFactory("P", 199.90, 5);
                        }
                        Shirt poloshirt = poloFactory.SearchShirt();
                        Console.WriteLine("\nDetalhes da camisa solicitada:\n");
                        Console.WriteLine("Marca: {0}\nTamanho:{1}\nPreço: {2}\nQuantidade em Stock: {3}",
                          poloshirt.Brand, poloshirt.Size, poloshirt.Price, poloshirt.QuantityStock);

                        Console.WriteLine("\n");
                        Console.Write("Deseja realizar a compra da Camisa (s/n) ? ");


                        string poloresp = Console.ReadLine();

                        if (poloresp == "S" || poloresp == "s")
                        {
                            poloFactory.BuyShirt(poloshirt.Size, poloshirt.QuantityStock, poloshirt.Price);
                        }
                        else
                        {
                            Console.WriteLine("Retornando.....\n");
                            break;
                        }

                        break;
                    case "social":
                        if (socialFactory == null)
                        {
                            socialFactory = new SocialFactory("G", 500.00, 15);
                        }

                        Shirt socialshirt = socialFactory.SearchShirt();
                        Console.WriteLine("\nDetalhes da camisa solicitada:\n");
                        Console.WriteLine("Marca: {0}\nTamanho:{1}\nPreço: {2}\nQuantidade em Stock: {3}",
                          socialshirt.Brand, socialshirt.Size, socialshirt.Price, socialshirt.QuantityStock);

                        Console.WriteLine("\n");
                        Console.Write("Deseja realizar a compra da Camisa (s/n) ? ");

                        string socialresp = Console.ReadLine();

                        if (socialresp == "S" || socialresp == "s")
                        {
                            socialFactory.BuyShirt(socialshirt.Size, socialshirt.QuantityStock, socialshirt.Price);
                        }
                        else
                        {
                            Console.WriteLine("Retornando.....\n");
                            break;
                        }
                        break;
                    default:
                        Console.WriteLine("Digite uma opção valida para continuar");
                        break;

                }
                Console.ReadKey();
            }
        }
    }
}
