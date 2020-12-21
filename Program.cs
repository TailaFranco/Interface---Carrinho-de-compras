using System;
using Interface.classes;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Carrinho carrinho = new Carrinho();

            Produto p1 = new Produto();
            p1.Codigo = 1;
            p1.Nome = "PS5";
            p1.Preco = 10000;

            Produto p2 = new Produto();
            p2.Codigo = 2;
            p2.Nome = "X box Series X";
            p2.Preco = 5000;

            Produto p3 = new Produto();
            p3.Codigo = 3;
            p3.Nome = "Nintendo Switch";
            p3.Preco = 4000;

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Carrinho de compras");
            Console.ResetColor();
            int Menu = 0;
            do
            {   Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Selecione uma opção válida");
                Console.WriteLine($"[1] Ver produtos disponíveis");
                Console.WriteLine($"[2] Adicionar produto ao carrinho");
                Console.WriteLine($"[3] Remover produto do carrinho");
                Console.WriteLine($"[4] Listar produtos adicionados ao carrinho");
                Console.WriteLine($"[0] Sair");
                Menu = int.Parse(Console.ReadLine());
                Console.ResetColor();

                switch (Menu)
                {
                    case 1:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    carrinho.Cadastrar(p1);
                    carrinho.Cadastrar(p2);
                    carrinho.Cadastrar(p3);
                    carrinho.Listar();
                    Console.ResetColor();
                    carrinho.Deletar(p1);
                    carrinho.Deletar(p2);
                    carrinho.Deletar(p3);
                    break;
                    case 2:
                    Console.WriteLine($"Selecione um produto para adicionar ao carrinho");
                    int opcao = 0;
                    do
                    {
                        Console.WriteLine($"[1] PS5");
                        Console.WriteLine($"[2] X box");
                        Console.WriteLine($"[3] Nintendo Switch");
                        Console.WriteLine($"[0] Sair");
                        opcao = int.Parse(Console.ReadLine());
                        
                        switch (opcao)
                        {
                            case 1:
                            carrinho.Cadastrar(p1);
                            break;
                            case 2:
                            carrinho.Cadastrar(p2);
                            break;
                            case 3:
                            carrinho.Cadastrar(p3);
                            break;
                            case 0:
                            break;
                            default:
                            break;
                        }
                        
                    } while (opcao != 0);
                    
                    break;
                    case 3:
                    carrinho.Listar();
                    Console.WriteLine($"Digite o código do produto para remover do carrinho");
                    int codigo1 = int.Parse(Console.ReadLine());
                    switch (codigo1)
                    {
                        case 1:
                        carrinho.Deletar(p1);
                        break;
                        case 2:
                        carrinho.Deletar(p2);
                        break;
                        case 3:
                        carrinho.Deletar(p3);
                        break;
                        default:
                        break;
                    }
            
                    break;
                    case 4:
                    Console.ForegroundColor = ConsoleColor.Red;
                    carrinho.Listar();
                    Console.ResetColor();
                    break;
                    case 0:
                    break;
                    default:
                        break;
                }
                   
                
            } while (Menu != 0);
            

            

            
            // carrinho.Cadastrar(p2);


            // Console.ForegroundColor = ConsoleColor.Blue;
            // carrinho.Alterar(p1.Codigo, p3);
            // carrinho.Listar();
            // Console.ResetColor();


        }
    }
}
