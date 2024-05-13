﻿using EasyParking.Modelos;

namespace EasyParking.Menus;

internal class MenuListarVeiculos : Menu
{
    public override void Executar(Estacionamento estacionamento)
    {
        base.Executar(estacionamento);
        ExibirTituloDoMenu("Lista de Veiculos");
        estacionamento.ListarVeiculos();
        VoltarParaMenuPrincipal();
    }
}
