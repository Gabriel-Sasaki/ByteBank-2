using ByteBankAlura.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankAlura
{
    public class GerenciadorBonificacao
    {
        // PROPRIEDADES E ATRIBUTOS
        private double _totalBonificacao;

        // MÉTODOS E FUNÇÕES
        public void Registrar(Funcionario funcionario)
        {
            _totalBonificacao += funcionario.GetBonificacao();
        }

        public double GetTotalBonificacao()
        {
            return _totalBonificacao;
        }
    }
}
