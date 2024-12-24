using System.Numerics;

namespace ProgramacaoOrientadaObjeto.Classes;

public class ModeloClasse
{
    private int _idPrivado;
    public void SetIdPrivado(int id)
    {
        if (id <= 0)
            throw new ArgumentException("Id deve ser maior que 0");

        _idPrivado = id;
    }

    public int GetIdPrivado()
    {
        return _idPrivado;
    }

    public string PropriedadeAutoImplementadaDescricao { get; set; }

    private decimal _valor;

    public decimal PropriedadeImplementadaValor
    {
        get
        {
            return _valor;
        }
        set
        {
            if (value < 0M)
                throw new ArgumentException("Valor não pode ser menor que 0");

            _valor = value;
        }
    }
    
    public string PropriedadeSomenteLeitura { get; }
    public readonly string CampoSomenteLeitura;
    
    private int _estoque;
    public int PropriedadeEstoque {
        get => _estoque;
        private set
        {
            if (ValidarValorEstoque(value))
                _estoque = value;
        }
    }

    public const int CONST_ESTOQUE_MINIMO = 10;
    
    public ModeloClasse()
    {
        PropriedadeSomenteLeitura = "Esta propriedade é somente leitura";
        CampoSomenteLeitura = "Este campo é somente leitura";
    }
    
    public ModeloClasse(int id) : this()
    {
        SetIdPrivado(id);
    }

    public ModeloClasse(int id, decimal valor) : this(id)
    {
        PropriedadeImplementadaValor = valor;
    }

    public ModeloClasse(ModeloClasse modelo) : this(modelo.GetIdPrivado(), modelo.PropriedadeImplementadaValor)
    {
        PropriedadeAutoImplementadaDescricao = modelo.PropriedadeAutoImplementadaDescricao;
    }
    
    public void ChecarEstoque()
    {
        if (PropriedadeEstoque < CONST_ESTOQUE_MINIMO)
            throw new ApplicationException("Estoque muito baixo");
    }
    
    public void AtualizarEstoque(int qtd)
    {
        if (ValidarValorEstoque(qtd))
            _estoque += qtd;
    }
    
    public string RetornarDados()
    {
        return 
            "Id: " + GetIdPrivado() +
            "\nDescrição: " + PropriedadeAutoImplementadaDescricao +
            "\nValor: " + PropriedadeImplementadaValor +
            "\nEstoque: " + PropriedadeEstoque +
            "\nObservação 1: " + PropriedadeSomenteLeitura +
            "\nObservação 2: " + CampoSomenteLeitura;
    }
    
    public static decimal CalcularDesconto(decimal valor, decimal percentual) => valor - (valor * (percentual / 100));

    public override int GetHashCode() => HashCode.Combine(_idPrivado, _valor, PropriedadeAutoImplementadaDescricao);

    public override bool Equals(object? obj)
    {
        if (obj is null) return false;

        if (obj is not ModeloClasse objModelo) return false;

        if (ReferenceEquals(obj, objModelo)) return true;

        return objModelo._idPrivado == _idPrivado &&
            objModelo._valor == _valor &&
            objModelo.PropriedadeAutoImplementadaDescricao == PropriedadeAutoImplementadaDescricao;
    }

    public static bool operator ==(ModeloClasse lhs, ModeloClasse rhs) => lhs.Equals(rhs);

    public static bool operator !=(ModeloClasse lhs, ModeloClasse rhs) => !(lhs == rhs);

    private bool ValidarValorEstoque(int qtd)
    {
        if (qtd <= 0)
            throw new ArgumentException("Valor para atualização do estoque deve ser maior que 0");

        return true;
    }
}
