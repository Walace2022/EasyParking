
namespace EasyParking.Modelos;

internal class Estacionamento
{
    private decimal precoInicial { get; set; }
    private decimal precoPorHora { get; set; }
    private List<string> Veiculos = new List<string>();

    public Estacionamento(decimal Inicial, decimal PorHora)
    {
        precoInicial = Inicial;
        precoPorHora = PorHora;
    }

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
        if (Veiculos.Any())
        {
            Console.WriteLine("Veículos Cadastrados no Estacionamento");
            foreach (string veiculo in Veiculos)
            {
                Console.WriteLine($" - {veiculo}");
            }

        }
        else
        {
            Console.WriteLine("Não há veículos estacionados.");
        }
    }
}
