using System.ComponentModel.Design;

namespace ProjetoFinalBloco01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcaoMenu;

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
                        Console.WriteLine("Número inválido!");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        opcaoMenu = -1;
                    }
                } while (opcaoMenu == -1);
            }
        }

        static void Menu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("1 - Cadastrar novo aparelho");
            Console.WriteLine("2 - Atualizar dados do aparelho");
            Console.WriteLine("3 - Deletar aparelho");
            Console.WriteLine("4 - Listar aparelhos cadastrados");

        }
    }
}