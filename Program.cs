using controle.estoque;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Estoque estoque1 = new();



        bool c = true;
        int op;

        while (c)
        {
            estoque1.Menu();
            op = Convert.ToInt32(Console.ReadLine());


            switch (op)
            {
                case 1:
                    estoque1.AddProduto();

                    break;


                case 2:
                    estoque1.listarProdutos();

                    break;

                case 3:
                    estoque1.RemoverProduto();

                    break;

                case 4:

                    estoque1.EntradaEstoque();

                    break;

                case 5:

                    estoque1.SaidaEstoque();

                    break;

                case 6:
                    c = false;

                    Console.WriteLine("Obrigado por utilizar nosso programa");

                    break;
                // pode dar um break !

                default:
                    Console.WriteLine("Opção inexistente, tente novamente");

                    break;


            }

        }
    }
    }