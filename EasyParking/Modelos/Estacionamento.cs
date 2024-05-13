
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
        if (Veiculos.Contains(veiculo))
        {
            Console.Write("Quantas horas o veiculo ficou no estacionamento? ");
            int horas = int.Parse(Console.ReadLine()!);
            Veiculos.Remove(veiculo);
            Console.WriteLine($"\nO veiculo de placa {veiculo} foi removido.");
            Console.WriteLine($"O valor total é de {horas * precoPorHora + precoInicial}");
        }
        else
        {
            Console.WriteLine("O veiculo informado não está no estacionamento.");
        }
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
