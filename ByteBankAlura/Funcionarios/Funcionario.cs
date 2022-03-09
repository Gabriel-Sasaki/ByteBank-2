using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankAlura.Funcionarios
{
    public abstract class Funcionario
    {
        // PROPRIEDADES E ATRIBUTOS
        public static int TotalDeFuncionarios { get; private set; }
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }

        // CONSTRUTORES
        public Funcionario(double salario, string cpf)
        {
            Console.WriteLine("Criando FUNCIONÁRIO");
            CPF = cpf;
            Salario = salario;
            TotalDeFuncionarios++;
        }

        // MÉTODOS E FUNÇÕES
        public abstract void AumentarSalario();

        public abstract double GetBonificacao();
    }
}
