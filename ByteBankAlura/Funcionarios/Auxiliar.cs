using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankAlura.Funcionarios
{
    public class Auxiliar : Funcionario
    {
        // CONSTRUTORES
        public Auxiliar(string cpf) : base(2000, cpf)
        {

        }

        // MÉTODOS E FUNÇÕES
        public override void AumentarSalario()
        {
            Salario *= 1.1;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.2;
        }
    }
}
