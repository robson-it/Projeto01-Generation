using ProjetoFinalBloco01.Controller;
using ProjetoFinalBloco01.Model;
using System;
using System.ComponentModel.Design;
using System.Data;

namespace ProjetoFinalBloco01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcaoMenu, imei, codigoAparelho;
            string modelo, fabricante, sistemaOperacional, cor, descricao, leitorBiometrico, frequenciaRedeMovel;
            decimal preco;
             
            CelularController celularController = new CelularController();

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
                        if (modelo.Equals(string.Empty))
                        {
                            var opcao = "";
                            Console.WriteLine("O modelo do celular não foi inserido! [M] Continuar [C] Cancelar!");
                            opcao = Console.ReadLine().ToUpper();
                            if (opcao.Equals("C"))
                            {
                                CancelarOperacao();
                                break;
                            }
                            else if (!opcao.Equals("M"))
                            {
                                CancelarOperacao("Operação inválida! ");
                                break;
                            }       

                        }

                        Console.WriteLine("Digite o nome do fabricante: ");
                        fabricante = Console.ReadLine();
                        fabricante ??= string.Empty;

                        if (fabricante.Equals(string.Empty))
                        {
                            var opcao = "";
                            Console.WriteLine("O fabricante do celular não foi inserido! [M] Continuar [C] Cancelar!");
                            opcao = Console.ReadLine().ToUpper();
                            if (opcao.Equals("C"))
                            {
                                CancelarOperacao();
                                break;
                            }
                            else if (!opcao.Equals("M"))
                            {
                                CancelarOperacao("Operação inválida! ");
                                break;
                            }

                        }

                        Console.WriteLine("Digite o nome do Sistema Operacional: ");
                        sistemaOperacional = Console.ReadLine();
                        sistemaOperacional ??= string.Empty;

                        if (sistemaOperacional.Equals(string.Empty))
                        {
                            var opcao = "";
                            Console.WriteLine("O sistema operacional do celular não foi inserido! [M] Continuar [C] Cancelar!");
                            opcao = Console.ReadLine().ToUpper();
                            if (opcao.Equals("C"))
                            {
                                CancelarOperacao();
                                break;
                            }
                            else if (!opcao.Equals("M"))
                            {
                                CancelarOperacao("Operação inválida! ");
                                break;
                            }

                        }

                        Console.WriteLine("Digite a cor do aparelho: ");
                        cor = Console.ReadLine();
                        cor ??= string.Empty;

                        if (cor.Equals(string.Empty))
                        {
                            var opcao = "";
                            Console.WriteLine("A cor do celular não foi inserida! [M] Continuar [C] Cancelar!");
                            opcao = Console.ReadLine().ToUpper();
                            if (opcao.Equals("C"))
                            {
                                CancelarOperacao();
                                break;
                            }
                            else if (!opcao.Equals("M"))
                            {
                                CancelarOperacao("Operação inválida! ");
                                break;
                            }

                        }

                        Console.WriteLine("Digite uma descrição para o aparelho (Ex: memória, resolução): ");
                        descricao = Console.ReadLine();
                        descricao ??= string.Empty;

                        if (descricao.Equals(string.Empty))
                        {
                            var opcao = "";
                            Console.WriteLine("A descricao do celular não foi inserida! [M] Continuar [C] Cancelar!");
                            opcao = Console.ReadLine().ToUpper();
                            if (opcao.Equals("C"))
                            {
                                CancelarOperacao();
                                break;
                            }
                            else if (!opcao.Equals("M"))
                            {
                                CancelarOperacao("Operação inválida! ");
                                break;
                            }

                        }

                        do
                        {
                            try
                            {
                                Console.WriteLine("Digite o IMEI aparelho: ");
                                imei = Convert.ToInt32(Console.ReadLine());
                                if(imei <= 0)
                                {
                                    Console.Clear();
                                    Console.WriteLine("\n o Número do IMEI deve ser maior que 0 | Tente novamente!");
                                    KeyPress();
                                }
                                else
                                {
                                    break;
                                }
                                
                            }catch(Exception e)
                            {
                                Console.Clear();
                                Console.WriteLine("\n O Número do IMEI deve ser um número | Tente novamente!");
                                KeyPress();
                            }
                            
                        } while (true);



                        Console.WriteLine("O aparelho possui leitor biométrico? [S] sim [N] não");
                        leitorBiometrico = Console.ReadLine().ToUpper();
                        leitorBiometrico ??= string.Empty;

                        if ((leitorBiometrico.Equals(string.Empty)) )
                        {
                            var opcao = "";
                            Console.WriteLine("Não foi inserida nenhuma resposta para leitor biomátrico! [M] Manter padrão \"não\" [C] Cancelar!");
                            opcao = Console.ReadLine().ToUpper();
                            if (opcao.Equals("C"))
                            {
                                CancelarOperacao();
                                break;
                            }
                            else if (!opcao.Equals("M"))
                            {
                                leitorBiometrico = "N";

                            }
                            else
                            {
                                leitorBiometrico = "N";
                            }

                        }else if ((!leitorBiometrico.Equals("S") && !leitorBiometrico.Equals("M"))) {
                            Console.WriteLine("Opção inválida! Será adotado por padrão \"não\"");
                            leitorBiometrico = "N";
                        }

                        Console.WriteLine("Digite a tecnologia de internet (3G / 4G / 5G : ");
                        frequenciaRedeMovel = Console.ReadLine();
                        frequenciaRedeMovel ??= string.Empty;

                        if (frequenciaRedeMovel.Equals(string.Empty))
                        {
                            var opcao = "";
                            Console.WriteLine("Nenhuma tecnologia digitada! [M] Continuar [C] Cancelar!");
                            opcao = Console.ReadLine().ToUpper();
                            if (opcao.Equals("C"))
                            {
                                CancelarOperacao();
                                break;
                            }
                            else if (!opcao.Equals("M"))
                            {
                                CancelarOperacao("Operação inválida! ");
                                break;
                            }

                        }


                        do
                        {
                            try
                            {
                                Console.WriteLine("Digite o preço do aparelho R$: ");
                                preco = Convert.ToDecimal(Console.ReadLine());
                                if (preco <= 0)
                                {
                                    Console.Clear();
                                    Console.WriteLine("\n O preço do aparelho deve ser maior que 0 | Tente novamente!");
                                    KeyPress();
                                }
                                else
                                {
                                    break;
                                }

                            }
                            catch (Exception e)
                            {
                                Console.Clear();
                                Console.WriteLine("\n Valor inválido | Tente novamente!");
                                KeyPress();
                            }

                        } while (true);

                        if (leitorBiometrico.Equals("N")){
                            celularController.CadastrarAparelho(new SmartPhone(
                                celularController.GerarCodigoCelular(), modelo, fabricante, sistemaOperacional, cor, descricao, imei, preco, false, frequenciaRedeMovel));
                        }
                        else
                        {
                            celularController.CadastrarAparelho(new SmartPhone(
                                celularController.GerarCodigoCelular(), modelo, fabricante, sistemaOperacional, cor, descricao, imei, preco, true, frequenciaRedeMovel));
                        }
                        KeyPress();
                        break;
                    case 2:
                        
                        Console.Clear();
                        Console.WriteLine("");
                        Console.WriteLine("[ATUALIZAR DESCRIÇÃO DO APARELHO]");

                        try
                        {
                            Console.WriteLine("\n\nDigite código do aparelho:");
                            opcaoMenu = Convert.ToInt32(Console.ReadLine());

                            var celular = celularController.BuscarAparelho(opcaoMenu);

                            if(celular is not null)
                            {
                                Console.WriteLine("Digite uma descrição para o aparelho (Ex: memória, resolução): ");
                                descricao = Console.ReadLine();
                                descricao ??= string.Empty;

                                if (descricao.Equals(string.Empty))
                                {
                                    var opcao = "";
                                    Console.WriteLine("A descricao do celular não foi inserida! [M] Continuar [C] Cancelar!");
                                    opcao = Console.ReadLine().ToUpper();
                                    if (opcao.Equals("C"))
                                    {
                                        CancelarOperacao();
                                        break;
                                    }
                                    else if (!opcao.Equals("M"))
                                    {
                                        CancelarOperacao("Operação inválida! ");
                                        break;
                                    }

                                }

                                celular.setDescricao(descricao);
                                celularController.AtualizarAparelho(celular);
                            }
                            

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

                        


                        KeyPress();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("");
                        Console.WriteLine("[DELETAR APARELHO CADASTRADO]");
                        Console.WriteLine("Digite o código do aparelho que deseja deletar: ");
                        codigoAparelho = Convert.ToInt32(Console.ReadLine());
                        celularController.DeletarAparelho(codigoAparelho);
                        KeyPress();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("");
                        Console.WriteLine("[LISTAR APARELHOS CADASTRADOS]");
                        celularController.ListarAparelhos();
                        KeyPress();
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

        private static ConsoleKeyInfo consoleKeyInfo;
        static void KeyPress()
        {
            do
            {
                Console.Write("\nPressione Enter para Continuar...");
                consoleKeyInfo = Console.ReadKey();
            } while (consoleKeyInfo.Key != ConsoleKey.Enter);
        }

        static void CancelarOperacao(string invalida = null)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\n" + invalida + "Operação cancelada com sucesso!");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            KeyPress();
        }
    }
}