using orientacaoAObjetos.Bytebank.Utilitario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orientacaoAObjetos.Bytebank.Funcionarios
{
    public abstract class Funcionario
    {
        protected string Nome;
        protected string Cpf;
        protected double Salario;
        private static int quantidadeDeFuncionarios;
     
        public Funcionario(string Nome, string Cpf)
        {
            this.Nome = Nome;
            this.Cpf = Cpf;
            quantidadeDeFuncionarios++;
        }

        public abstract double getBonificacao();
        public abstract void aumentarSalario();
        static public int getQuantidadeDeFuncionarios()
        {
            return quantidadeDeFuncionarios;
        }
        public double getSalario()
        {
            return this.Salario;
        }
    }
}
