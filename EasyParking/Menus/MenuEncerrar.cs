
using EasyParking.Modelos;

namespace EasyParking.Menus;

internal class MenuEncerrar : Menu
{
    public override void Executar(Estacionamento estacionamento)
    {
        base.Executar(estacionamento);
        Console.WriteLine("Obrigado por usar o EasyParking.");
    }
}
