using Microsoft.VisualBasic;

namespace Recursos.NET.Assuntos;

public class Conversores(string titulo) : IAssunto
{
    public string Titulo { get; set; } = titulo;

    public void Executar()
    {
        EscreverConversoesNumericas();
        EscreverConversoesBooleanas();
    }

    private void EscreverConversoesNumericas()
    {
        Console.WriteLine("### Conversões numéricas\n");

        string entradaNull = null;
        
        var entradaString1 = "a";
        var entradaString2 = "";
        var entradaString3 = "5";
        var entradaString4 = "-10";
        var entradaString5 = "19,99";
        var entradaString6 = "9.99";
        var entradaString8 = "257";

        var entradaNumero1 = 32.664;

        EscreverConversoesNumericasInteiras(entradaNull, mensagemErroParse: "(Parâmetro não pode ser null)");

        EscreverConversoesNumericasInteiras(entradaString1, mensagemErroParse: "Erro (Formato inválido)", mensagemErroConvert: "Erro (Formato inválido)");
        EscreverConversoesNumericasInteiras(entradaString2, mensagemErroParse: "Erro (Formato inválido)", mensagemErroConvert: "Erro (Formato inválido)");
        EscreverConversoesNumericasInteiras(entradaString3);
        EscreverConversoesNumericasInteiras(entradaString4);
        EscreverConversoesNumericasInteiras(entradaString5, mensagemErroParse: "Erro (Formato inválido)", mensagemErroConvert: "Erro (Formato inválido)");
        EscreverConversoesNumericasInteiras(entradaString6, mensagemErroParse: "Erro (Formato inválido)", mensagemErroConvert: "Erro (Formato inválido)");

        EscreverConversoesNumericasDecimais(entradaString5);
        EscreverConversoesNumericasDecimais(entradaString6);

        EscreverConversoesNumericasByte(entradaString8, mensagemErroParse: "Erro (Valor fora do range permitido para o tipo)", mensagemErroConvert: "Erro (Valor fora do range permitido para o tipo)");

        EscreverConversoesNumericasInteiras(entradaNumero1);
    }

    private void EscreverConversoesNumericasInteiras(string valor, string mensagemErroParse = null, string mensagemErroConvert = null)
    {
        Console.WriteLine("Conversão de " + (valor is null ? "null" : "\"" + valor + "\"") + " para inteiro\n");
        Console.WriteLine("\tCom Parse: " + (string.IsNullOrEmpty(mensagemErroParse) ? int.Parse(valor).ToString() : mensagemErroParse));
        Console.WriteLine("\tCom Convert: " + (string.IsNullOrEmpty(mensagemErroConvert) ? Convert.ToInt32(valor).ToString() : mensagemErroConvert));

        var sucessoParse = int.TryParse(valor, out var resultadoInt);

        Console.WriteLine("\tCom TryParse: " + resultadoInt + " (Conversão bem sucedida: " + sucessoParse + ")\n");
    }

    private void EscreverConversoesNumericasInteiras(double valor)
    {
        Console.WriteLine("Conversão de " + valor + " para inteiro\n");
        Console.WriteLine("\tCom Convert: " + Convert.ToInt32(valor) + "\n");
    }

    private void EscreverConversoesNumericasDecimais(string valor, string mensagemErroParse = null, string mensagemErroConvert = null)
    {
        Console.WriteLine("Conversão de "+ (valor is null ? "null" : "\"" + valor + "\"") + " para decimal\n");
        Console.WriteLine("\tCom Parse: " + (string.IsNullOrEmpty(mensagemErroParse) ? decimal.Parse(valor).ToString() : mensagemErroParse));
        Console.WriteLine("\tCom Convert: " + (string.IsNullOrEmpty(mensagemErroConvert) ? Convert.ToDecimal(valor).ToString() : mensagemErroConvert));

        var sucessoParse = decimal.TryParse(valor, out var resultadoInt);

        Console.WriteLine("\tCom TryParse: " + resultadoInt + " (Conversão bem sucedida: " + sucessoParse + ")\n");
    }

    private void EscreverConversoesNumericasByte(string valor, string mensagemErroParse = null, string mensagemErroConvert = null)
    {
        Console.WriteLine("Conversão de "+ (valor is null ? "null" : "\"" + valor + "\"") + " para byte\n");
        Console.WriteLine("\tCom Parse: " + (string.IsNullOrEmpty(mensagemErroParse) ? byte.Parse(valor).ToString() : mensagemErroParse));
        Console.WriteLine("\tCom Convert: " + (string.IsNullOrEmpty(mensagemErroConvert) ? Convert.ToByte(valor).ToString() : mensagemErroConvert));

        var sucessoParse = byte.TryParse(valor, out var resultadoInt);

        Console.WriteLine("\tCom TryParse: " + resultadoInt + " (Conversão bem sucedida: " + sucessoParse + ")\n");
    }

    private void EscreverConversoesBooleanas()
    {
        Console.WriteLine("### Conversões booleanas\n");

        string entradaNull = null;

        var entradaString1 = "true";
        var entradaString2 = "false";
        var entradaString3 = "verdadeiro";
        var entradaString4 = "0";

        var entradaNumerica1 = 0;
        var entradaNumerica2 = 1;
        var entradaNumerica3 = -1;

        EscreverConversoesBooleanas(entradaNull, mensagemErroParse: "Erro (Parâmetro não pode ser null)");

        EscreverConversoesBooleanas(entradaString1);
        EscreverConversoesBooleanas(entradaString2);
        EscreverConversoesBooleanas(entradaString3, mensagemErroParse: "Erro (Valor inválido)", mensagemErroConvert: "Erro (Valor inválido)");
        EscreverConversoesBooleanas(entradaString4, mensagemErroParse: "Erro (Valor inválido)", mensagemErroConvert: "Erro (Valor inválido)");

        EscreverConversoesBooleanas(entradaNumerica1);
        EscreverConversoesBooleanas(entradaNumerica2);
        EscreverConversoesBooleanas(entradaNumerica3);
    }

    private void EscreverConversoesBooleanas(string valor, string mensagemErroParse = null, string mensagemErroConvert = null)
    {
        Console.WriteLine("Conversão de " + (valor is null ? "null" : "\"" + valor + "\"") + " para booleano\n");
        Console.WriteLine("\tCom Parse: " + (string.IsNullOrEmpty(mensagemErroParse) ? bool.Parse(valor).ToString() : mensagemErroParse));
        Console.WriteLine("\tCom Convert: " + (string.IsNullOrEmpty(mensagemErroConvert) ? Convert.ToBoolean(valor).ToString() : mensagemErroConvert));

        var sucessoParse = bool.TryParse(valor, out var resultadoInt);

        Console.WriteLine("\tCom TryParse: " + resultadoInt + " (Conversão bem sucedida: " + sucessoParse + ")\n");
    }

    private void EscreverConversoesBooleanas(int valor)
    {
        Console.WriteLine("Conversão de " + valor + " para booleano\n");
        Console.WriteLine("\tCom Convert: " + Convert.ToBoolean(valor) + "\n");
    }
}
