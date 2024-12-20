using System;

namespace ProgramacaoOrientadaObjeto._2_Classes;

public static class ModeloStatic
{
    public const int VALOR_PADRAO = 6;
    private static int _id;

    public static int Chave { get; set; }
    public static int Codigo { get => Random.Shared.Next(); }

    public static int Somar(int a, int b) => a + b;
    public static int Subtrair(int a, int b) => a - b;

    public static void SetId(int id)
    {
        if (id <= 0)
            throw new ArgumentException("Id deve ser maior que 0");

        _id = id;
    }

    public static string RetornarValores()
    {
        return "" +
            "Id: " + _id +
            "\nChave: " + Chave +
            "\nCodigo: " + Codigo +
            "\nValor Padrão: " + VALOR_PADRAO;
    }
}
