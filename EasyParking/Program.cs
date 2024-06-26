﻿using EasyParking.Menus;
using EasyParking.Modelos;

Console.WriteLine("Seja bem vindo ao EasyParking!\n" +
                  "Digite o preço inicial:");
decimal precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Agora digite o preço por hora:");
decimal precoPorHora = Convert.ToDecimal(Console.ReadLine());

Console.Clear();

Estacionamento estacionamento = new Estacionamento(precoInicial,precoPorHora);

Dictionary<int , Menu> Menus = new Dictionary<int , Menu>();
Menus.Add(1, new MenuAdicionarVeiculo());
Menus.Add(2, new MenuRemoverVeiculo());
Menus.Add(3, new MenuListarVeiculos());
Menus.Add(4, new MenuEncerrar());

void ExibirMenuPrincipal()
{
    Console.WriteLine("\nDigite 1 para cadastar um veículo");
    Console.WriteLine("Digite 2 para remover um veículo");
    Console.WriteLine("Digite 3 para listar os veículos cadastrados");
    Console.WriteLine("Digite 4 para encerrar o programa");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    if (Menus.ContainsKey(opcaoEscolhidaNumerica))
    {
        Menu  menu = Menus[opcaoEscolhidaNumerica];
        menu.Executar(estacionamento);
        if(opcaoEscolhidaNumerica != 4) ExibirMenuPrincipal();
    }
    else
    {
        Console.WriteLine("Opção Inválida!");
        Console.WriteLine("Aperte uma tecla pra continuar.");
        Console.ReadKey();
        Console.Clear();
        ExibirMenuPrincipal();
    }
}

ExibirMenuPrincipal();