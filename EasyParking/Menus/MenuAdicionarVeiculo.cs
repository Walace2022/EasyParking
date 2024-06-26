﻿using EasyParking.Modelos;

namespace EasyParking.Menus;

internal class MenuAdicionarVeiculo : Menu
{
    public override void Executar(Estacionamento estacionamento)
    {
        base.Executar(estacionamento);
        ExibirTituloDoMenu("Adicione um Veículo");
        Console.Write("Digite a placa do veículo a ser adicionado: ");
        string placa = Console.ReadLine()!;
        estacionamento.AdicionarVeiculo(placa);
        Console.WriteLine($"\nO veículo {placa} foi adicionado com sucesso.");
        VoltarParaMenuPrincipal();
    }
}
