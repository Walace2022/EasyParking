using EasyParking.Modelos;

namespace EasyParking.Menus;

internal class MenuAdicionarVeiculo : Menu
{
    public override void Executar(Estacionamento estacionamento)
    {
        base.Executar(estacionamento);
        ExibirTituloDoMenu("Adicione um Veiculo");
        Console.Write("Digite a placa do veiculo a ser adicionado: ");
        string placa = Console.ReadLine()!;
        estacionamento.AdicionarVeiculo(placa);
        VoltarParaMenuPrincipal();
    }
}
