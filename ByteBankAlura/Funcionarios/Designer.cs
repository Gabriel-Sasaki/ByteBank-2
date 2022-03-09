using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankAlura.Funcionarios
{
    public class Designer : Funcionario
    {
        // CONSTRUTORES
        public Designer (string cpf) : base(3000, cpf)
        {

        }

        // MÉTODOS E FUNÇÕES
        public override void AumentarSalario()
        {
            Salario *= 1.11;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.17;
        }
    }
}
