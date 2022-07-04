using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orientacaoAObjetos.Bytebank.Funcionarios
{
    public class GerenteDeContas : Funcionario
    {
        public GerenteDeContas(string Nome, string Cpf) : base(Nome, Cpf)
        {
            this.Salario = 4000;
        }
        public override double getBonificacao()
        {
            return this.Salario * 0.25;
        }
        public override void aumentarSalario()
        {
            this.Salario *= 0.5;
        }
    }
}
