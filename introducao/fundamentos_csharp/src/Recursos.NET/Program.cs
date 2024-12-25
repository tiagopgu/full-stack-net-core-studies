using System.Data;
using Recursos.NET;
using Recursos.NET.Assuntos;

List<IAssunto> assuntos =
[
    new Conversores("Conversores de Tipos Primitivos")
];

var continuarExecucao = true;
var opcaoValida = true;

while (continuarExecucao)
{
    ClearConsole();
    
    if (!opcaoValida)
        Console.WriteLine("# Opção Inválida!\n");

    MostrarMenu();

    Console.Write("\nSelecione uma opção do menu: ");
    
    if (!int.TryParse(Console.ReadLine(), out var opcao))
    {
        opcaoValida = false;
        continue;
    }

    opcaoValida = true;

    if (opcao == 0)
        break;

    _ = opcao--;

    if (opcao < 0 || opcao >= assuntos.Count)
    {
        opcaoValida = false;
        continue;
    }

    var assunto = assuntos[opcao];

    ClearConsole();

    Console.WriteLine("# " + assunto.Titulo + "\n");
    
    assunto.Executar();

    Console.Write("\nPressione qualquer tecla para continuar...");
    Console.ReadKey();

    Console.Clear();
}

void MostrarMenu()
{
    Console.WriteLine("Menu de Assuntos\n");

    Console.WriteLine("\t0. Sair\n");
    
    var countMenu = 1;

    foreach (var assunto in assuntos)
        Console.WriteLine("\t" + countMenu++ + ". " + assunto.Titulo);
}

void ClearConsole()
{
    Console.Clear();
    Console.WriteLine("\x1b[3J");
    Console.SetCursorPosition(0, 0);
    Console.Clear();
}