﻿using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;



Reserva reserva = new Reserva();
bool executando = true;

while (executando)
    {
        Console.Clear();
        Console.WriteLine(@"
======= Sistema de Reservas =======
1 - Cadastrar Suíte
2 - Cadastrar Hóspedes
3 - Exibir Resumo da Reserva
4 - Sair
====================================
Escolha uma opção: ");

        string opcao = Console.ReadLine();

        switch (opcao)
        {
            case "1":
                reserva.CadastrarSuite();
                break;

            case "2":
                try
                {
                    reserva.CadastrarHospedes();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"\nErro: {ex.Message}");
                    Console.WriteLine("\nPressione qualquer tecla para continuar...");
                    Console.ReadKey();
                }
                break;

            case "3":
                try
                {
                    Console.Clear();
                    reserva.Resumo();
                    Console.WriteLine("\nPressione qualquer tecla para continuar...");
                    Console.ReadKey();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"\nErro: {ex.Message}");
                    Console.WriteLine("\nPressione qualquer tecla para continuar...");
                    Console.ReadKey();
                }
                break;

            case "0":
                executando = false;
                Console.WriteLine("\nEncerrando o programa...");
                break;

            default:
                Console.WriteLine("Opção inválida! Pressione qualquer tecla para tentar novamente...");
                Console.ReadKey();
                break;
            }
        }
    

