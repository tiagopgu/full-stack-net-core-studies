namespace ProgramacaoOrientadaObjeto.Classes;

public class AssuntoClasseAbstrata(string titulo) : Assunto(titulo)
{
    public override void ExecutarDemo()
    {
        // Erro: classe abstrata não pode ser instanciada
        //var modeloAbstrato = new ModeloAbstrato();
        var modeloEspecializado = new ModeloEspecializado()
        {
            Id = 3,
            PropriedadeEspecializada = "Valor 1"
            //Codigo = 5; // Erro. Propriedade somente leitura externamente
        };
        var modeloEspecializado2 = new ModeloEspecializado2(5, "Valor 2");

        Console.WriteLine("Dados Especializados 1\n" + modeloEspecializado.ObterDados() + "\n");
        Console.WriteLine("Dados Especializados 2\n" + modeloEspecializado2.ObterDados() + "\n");

        Console.WriteLine("Membro estático na superclasse\n" + "Valor Padrão: " + ModeloAbstrato.CHAVE_PADRAO + "\n");

        Console.WriteLine("Membros existente somente nas especializações");
        Console.WriteLine("Propriedade Especializada 1: " + modeloEspecializado.PropriedadeEspecializada);
        Console.WriteLine("Método Especializado 1: " + modeloEspecializado.MetodoEspecializado());
        Console.WriteLine("Propriedade Especializada 2: " + modeloEspecializado2.PropriedadeEspecializada2);
        Console.WriteLine("Método Especializado 2: " + modeloEspecializado2.MetodoEspecializado2() + "\n");

        Console.WriteLine("Membro somente na superclasse");
        Console.WriteLine("Objeto especializado 1: " + modeloEspecializado.Metodo());
        Console.WriteLine("Objeto especializado 2: " + modeloEspecializado2.Metodo() + "\n");

        Console.WriteLine("Membro implementado somente em um objeto especializado");
        Console.WriteLine("Objeto especializado 1: " + modeloEspecializado.Metodo2());
        Console.WriteLine("Objeto especializado 2: " + modeloEspecializado2.Metodo2() + "\n");

        Console.WriteLine("Membro de implementação obrigatória pelos objetos especializados");
        Console.WriteLine("Objeto especializado 1: " + modeloEspecializado.Metodo3());
        Console.WriteLine("Objeto especializado 2: " + modeloEspecializado2.Metodo3() + "\n");

        // Abstração permite a aplicação do polimorfismo
        List<ModeloAbstrato> especializacoes = [modeloEspecializado, modeloEspecializado2];

        Console.WriteLine("Usando abstração para aplicação do polimorfismo");

        foreach (var obj in especializacoes)
        {
            Console.WriteLine();
            Console.WriteLine("Id: " + obj.Id);
            Console.WriteLine("Método 1: " + obj.Metodo());
            Console.WriteLine("Método 2: " + obj.Metodo2());
            Console.WriteLine("Método 3: " + obj.Metodo3());
        }
    }
}
