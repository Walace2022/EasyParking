
namespace EasyParking.Modelos;

internal class Estacionamento
{
    public decimal precoInicial { get; set; }
    public decimal precoPorHora { get; set; }
    private List<string> Veiculos = new List<string>();
    
    public void AdicionarVeiculo(string veiculo)
    {
        Veiculos.Add(veiculo);
    }

    public void RemoverVeiculo(string veiculo)
    {
        Veiculos.Remove(veiculo);
    }

    public void ListarVeiculos()
    {
        Console.WriteLine("Veiculos Cadastrados no Estacionamento");
        foreach (string veiculo in Veiculos)
        {
            Console.WriteLine($" - {veiculo}");
        }
    }
}
