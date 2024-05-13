
using EasyParking.Modelos;

namespace EasyParking.Menus;

internal class MenuRemoverVeiculo : Menu
{
    public override void Executar(Estacionamento estacionamento)
    {
        base.Executar(estacionamento);
        ExibirTituloDoMenu("Remova um Veículo");
        Console.Write("Digite a placa do veículo a ser removido: ");
        string placa = Console.ReadLine()!;
        estacionamento.RemoverVeiculo(placa);
        VoltarParaMenuPrincipal();
    }
}
