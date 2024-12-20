using ProgramacaoOrientadaObjeto;
using ProgramacaoOrientadaObjeto.Classes;
using ProgramacaoOrientadaObjeto.Namespaces;

List<Assunto> assuntos =
[
    new AssuntoNamespace("Namespace"),
    new AssuntoClasse("Classes"),
    new AssuntoClasseEstatica("Classes Estáticas"),
    new AssuntoClasseAbstrata("Classes Abstratas")
];

var continuarExecucao = true;
var opcaoInvalida = false;

do
{
    ClearConsole();

    Console.WriteLine();

    if (opcaoInvalida)
        Console.WriteLine("# Opção inválida.\n");

    MostrarMenu();

    Console.Write("\nSelecione uma opção do menu: ");

    opcaoInvalida = !int.TryParse(Console.ReadLine(), out var opcao) || !ValidarOpcao(opcao);

    if (opcaoInvalida)
        continue;

    if (opcao == 0)
        break;
        
    var assunto = assuntos[opcao - 1];

    Console.Clear();

     Console.WriteLine("\n** " + assunto.Titulo + " **\n");

    assunto.ExecutarDemo();

    Console.Write("\nPressione qualquer tecla para continuar...");
    Console.ReadKey();

    Console.Clear();

} while (continuarExecucao);

void MostrarMenu()
{
    Console.WriteLine("** Menu de Assuntos **\n");

    Console.WriteLine("\t0. Sair\n");

    for (int i = 0; i < assuntos.Count; i++)
    {
        var assunto = assuntos[i];
        Console.WriteLine("\t" + (i + 1) + ". " + assunto.Titulo);
    }
}

bool ValidarOpcao(int opcao) => opcao >= 0 && opcao <= assuntos.Count;

void ClearConsole()
{
    Console.Clear();
    Console.WriteLine("\x1b[3J");
    Console.SetCursorPosition(0, 0);
    Console.Clear();
}