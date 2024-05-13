
using EasyParking.Modelos;

namespace EasyParking.Menus;

internal class MenuRemoverVeiculo : Menu
{
    public override void Executar(Estacionamento estacionamento)
    {
        base.Executar(estacionamento);
        ExibirTituloDoMenu("Remova um Veiculo");
        Console.Write("Digite a placa do veiculo a ser removido: ");
        string placa = Console.ReadLine()!;
        estacionamento.RemoverVeiculo(placa);
        VoltarParaMenuPrincipal();
    }
}
