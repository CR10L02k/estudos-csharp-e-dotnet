using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orientacaoAObjetos.Bytebank.Funcionarios
{
    public class Desenvolvedor : Funcionario
    {
        public Desenvolvedor(string Nome, string Cpf) : base(Nome, Cpf)
        {
        }

        public override void aumentarSalario()
        {
            this.Salario *= 0.15;
        }

        public override double getBonificacao()
        {
            return Salario * 0.1;
        }
    }
}
