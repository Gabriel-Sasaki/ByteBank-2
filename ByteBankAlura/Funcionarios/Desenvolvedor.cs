using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankAlura.Funcionarios
{
    public class Desenvolvedor : Funcionario
    {
        // PROPRIEDADES E ATRIBUTOS
        public Desenvolvedor(string cpf) : base(3000, cpf)
        {

        }

        // MÉTODOS E FUNÇÕES
        public override void AumentarSalario()
        {
            Salario *= 0.15;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.1;
        }
    }
}
