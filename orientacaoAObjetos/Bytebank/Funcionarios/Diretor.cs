using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orientacaoAObjetos.Bytebank.Funcionarios
{
    public class Diretor : Funcionario
    {
        public Diretor(string nome, string cpf) : base(nome, cpf)
        {
            this.Salario = 5000;
        }
        public override double getBonificacao()
        {
            return this.Salario * 0.50;
        }
        public override void aumentarSalario()
        {
            this.Salario *= 0.15;
        }
    }
}
