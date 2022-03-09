using ByteBankAlura.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankAlura.Sistemas
{
    public interface IAutenticavel
    {
        // MÉTODOS E FUNÇÕES
        bool Autenticar(string senha);
    }
}
