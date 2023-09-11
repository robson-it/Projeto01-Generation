using System.ComponentModel.Design;

namespace ProjetoFinalBloco01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcaoMenu, imei;
            string modelo, fabricante, sistemaOperacional, cor, descricao;

            while (true)
            {
                Menu();
                
                do
                {
                    try
                    {
                        Console.WriteLine("\n\nDigite um número inteiro entre 1 e 4");
                        opcaoMenu = Convert.ToInt32(Console.ReadLine());

                    }
                    catch (FormatException e)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Clear();
                        Menu();
                        Console.WriteLine("Número inválido!");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        opcaoMenu = -1;
                    }
                } while (opcaoMenu == -1);

                switch(opcaoMenu) {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("");
                        Console.WriteLine("[CADASTRAR NOVO APARELHO]\n");
                        Console.WriteLine("Digite o modelo do aparelho: ");
                        modelo = Console.ReadLine();
                        modelo ??= string.Empty;
                        Console.WriteLine("Digite o nome do fabricante: ");
                        fabricante = Console.ReadLine();
                        fabricante ??= string.Empty;
                        Console.WriteLine("Digite o nome do Sistema Operacional: ");
                        sistemaOperacional = Console.ReadLine();
                        sistemaOperacional ??= string.Empty;
                        Console.WriteLine("Digite a cor do aparelho: ");
                        cor = Console.ReadLine();
                        cor ??= string.Empty;
                        Console.WriteLine("Digite uma descrição para o aparelho (Ex: memória, resolução): ");
                        descricao = Console.ReadLine();
                        descricao ??= string.Empty;
                        Console.WriteLine("Digite o IMEI aparelho: ");
                        imei = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 2:
                        
                        Console.Clear();
                        Console.WriteLine("");
                        Console.WriteLine("[ATUALIZAR DESCRIÇÃO DO APARELHO]");
                        Console.WriteLine("Digite uma descrição para o aparelho (Ex: memória, resolução): ");
                        descricao = Console.ReadLine();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("");
                        Console.WriteLine("[DELETAR APARELHO CADASTRADO]");
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("");
                        Console.WriteLine("[LISTAR APARELHOS CADASTRADOS]");
                        break;
                    default:
                        Console.WriteLine("Opção inválida! Tente novamente!");
                        break;
                }
            }
        }

        static void Menu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("1 - Cadastrar novo aparelho");
            Console.WriteLine("2 - Atualizar descricao do aparelho");
            Console.WriteLine("3 - Deletar aparelho");
            Console.WriteLine("4 - Listar aparelhos cadastrados");

        }

        static int ValidaInteiro(int numeroInteiro)
        {

            return numeroInteiro;
        }
    }
}