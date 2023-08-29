using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controle.estoque
{
   public class Estoque
    {
        int id = 0; 
      

        List<Produto> estoque = new List<Produto>();

        public void Menu()
        {
            Console.WriteLine("Selecione a opção desejada:\n");
            Console.WriteLine("[1] Novo");
            Console.WriteLine("[2]Listar Produtos");
            Console.WriteLine("[3] Remover Produto");
            Console.WriteLine("[4] Adicionar ao estoque");
            Console.WriteLine("[5] Saída do estoque");
            Console.WriteLine("[6} Sair");

        }

        public void AddProduto()
        {
            Console.WriteLine($"\n  Nome do produto:");
            string nome = Console.ReadLine();

            Console.WriteLine($" Valor do produto {nome}:");
            double valor = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Qual a quantidade do produto a ser acrescida?");
            int quantidade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Fornecedor:");
            string fornecedor = Console.ReadLine();

            Console.WriteLine("Descrição do Item:");
            string descricao = Console.ReadLine();

            {
                Produto produto = new Produto()
                {
                    Id = id++,
                    NomeProduto = nome,
                    Valor = valor,
                    QuantidadeEstoque = quantidade,
                    Fornecedor =  fornecedor,
                    DescricaoProduto =  descricao,

                };
                



                
                estoque.Add(produto );

                Console.WriteLine($"\n {nome} adicionado com sucesso. ");

                      
            }                          

            
        } 

        public void listarProdutos()
        {
            if (estoque.Count() > 0) {
                Console.WriteLine("\n Os produtos do estoque são:");

                foreach(var p in estoque)
                {
                    Console.WriteLine($"ID:{p.Id}\n{p.NomeProduto}\n Valor de R${p.Valor:N2}\n Disponível no estoque:{p.QuantidadeEstoque}unidades\n");
                }

               
            }
            else {
                Console.WriteLine("\n Não foi possível localizar este produto!");

            }

           
        }

        public void RemoverProduto()
        {
            Console.WriteLine("\n Digite o Código do produto a ser removido");
            int codRemove = Convert.ToInt32(Console.ReadLine());

            estoque.RemoveAll(produto =>produto.Id == codRemove);
            Console.WriteLine("O produto foi removido.");
        }

        public void EntradaEstoque()
        {
            Console.WriteLine("Código do produto a ser acrescido:");
            int codEntrada = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Quantidade:");
            int quant = Convert.ToInt32(Console.ReadLine());

            Produto produto = estoque.Find(p=> p.Id == codEntrada);

            if(produto != null) { 
            produto.QuantidadeEstoque += quant;
                Console.WriteLine($"A quantidade informada de {quant} foi acresccida com sucesso!");

                    }
            else
            {
                Console.WriteLine("Desculpe, produto não foi encontrado!");
            }

        }

        public void SaidaEstoque()
        {
            Console.WriteLine("Código do Produto:");
            int codSaida = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Infome a quantidade a ser retirada:");
            int quant = Convert.ToInt32(Console.ReadLine());

            Produto produto = estoque.Find(p=> p.Id == codSaida);

            if(produto != null)
            {
                produto.QuantidadeEstoque -= quant;
                Console.WriteLine($"A retidara de {quant} foi realizada com sucesso!");
            }
            else
            {
                Console.WriteLine("O produto não pode ser encontrado!");
            }

        }

    }
}
