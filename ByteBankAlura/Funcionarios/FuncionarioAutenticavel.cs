using ByteBankAlura.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankAlura.Funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        // PROPRIEDADES E ATRIBUTOS
        public string Senha { get; set; }

        // CONSTRUTORES
        public FuncionarioAutenticavel(double salario, string cpf) : base(salario, cpf)
        {

        }

        // MÉTODOS E FUNÇÕES
        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }

    }
}
