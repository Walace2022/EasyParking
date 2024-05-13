using EasyParking.Modelos;

namespace EasyParking.Menus;

internal class Menu
{
    public void ExibirTituloDoMenu(string titulo)
    {
        int tamanhoDoTitulo = titulo.Length;
        string detalhe = string.Empty.PadLeft(tamanhoDoTitulo, '=');
        Console.WriteLine(detalhe);
        Console.WriteLine(titulo);
        Console.WriteLine(detalhe + "\n");
    }

    public void VoltarParaMenuPrincipal()
    {
        Console.WriteLine("Pressione qualquer tecla para voltar ao Menu Principal.");
        Console.ReadKey();
        Console.Clear();
    }

    public virtual void Executar(Estacionamento estacionamento)
    {
        Console.Clear();
    }
}
