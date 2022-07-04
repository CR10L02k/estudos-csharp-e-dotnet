using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orientacaoAObjetos.Bytebank.Funcionarios
{
    public class Auxiliar : Funcionario
    {
        public Auxiliar(string Nome, string Cpf) : base(Nome, Cpf)
        {
            this.Salario = 2000;
        }
        public override double getBonificacao()
        {
            return this.Salario * 0.20;
        }
        public override void aumentarSalario()
        {
            this.Salario *= 0.10;
        }
    }
}
