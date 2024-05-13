using EasyParking.Menus;
using EasyParking.Modelos;

Estacionamento estacionamento = new Estacionamento();

Dictionary<int , Menu> Menus = new Dictionary<int , Menu>();
Menus.Add(1, new MenuAdicionarVeiculo());
Menus.Add(2, new MenuRemoverVeiculo());
Menus.Add(3, new MenuListarVeiculos());
Menus.Add(4, new MenuEncerrar());

void ExibirMenuPrincipal()
{
    Console.WriteLine("\nDigite 1 para cadastar um veiculo");
    Console.WriteLine("Digite 2 para remover um veiculo");
    Console.WriteLine("Digite 3 para listar os veiculos cadastrados");
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
        Console.WriteLine("Opção Invalida!");
        Console.WriteLine("Aperte uma tecla pra continuar.");
        Console.ReadKey();
        Console.Clear();
        ExibirMenuPrincipal();
    }
}

ExibirMenuPrincipal();