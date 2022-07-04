using orientacaoAObjetos.Bytebank.Contas;
using orientacaoAObjetos.Bytebank.Funcionarios;
using orientacaoAObjetos.Bytebank.Utilitario;

class teste
{

    static void Main(string[] args)
    {
        Funcionario jose = new Designer("José Santos", "654.988.979-86");
        Funcionario victor = new Auxiliar("Victor Vieira", "043.435.435-98");
        Funcionario santos = new GerenteDeContas("Santos José", "455.776.565-53");
        Funcionario vieira = new Diretor("Vieira Victor", "343.754.543-87");
        Funcionario joseVictor = new Desenvolvedor("José Victor Santos Vieira", "535.564.434-54");

        GerenciadorDeBonificacoes gerenciador = new GerenciadorDeBonificacoes();

        gerenciador.registrar(jose);
        gerenciador.registrar(victor);
        gerenciador.registrar(santos);
        gerenciador.registrar(vieira);
        gerenciador.registrar(joseVictor);

        Console.WriteLine("BONIFICACAO JOSÉ\t: " + jose.getBonificacao());
        Console.WriteLine("BONIFICACAO VICTOR\t: " + victor.getBonificacao());
        Console.WriteLine("BONIFICACAO SANTOS\t: " + santos.getBonificacao());
        Console.WriteLine("BONIFICACAO VIEIRA\t: " + vieira.getBonificacao());

        Console.WriteLine("\nTOTAL DE BONIFICACOES\t: " + gerenciador.getBonificacao());
        Console.WriteLine("QTN DE FUNCIONARIOS\t: " + Funcionario.getQuantidadeDeFuncionarios());

    }
}