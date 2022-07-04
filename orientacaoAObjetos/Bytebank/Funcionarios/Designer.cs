using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orientacaoAObjetos.Bytebank.Funcionarios
{
    public class Designer : Funcionario
    {
        public Designer(string Nome, string Cpf) : base(Nome, Cpf)
        {
            this.Salario = 3000;
        }
        public override double getBonificacao()
        {
            return this.Salario * 0.17;
        }
        public override void aumentarSalario()
        {
            this.Salario *= 0.11;
        }
    }
}
