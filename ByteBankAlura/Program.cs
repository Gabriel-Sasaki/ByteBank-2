using ByteBankAlura.Funcionarios;
using ByteBankAlura.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankAlura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CalcularBonificacao();

            UsarSistema();

            Console.ReadLine();
        }

        public static void UsarSistema()
        {
            // Criando o objeto sistemaInterno
            SistemaInterno sistemaInterno = new SistemaInterno();

            // Criando o objeto roberta e informando o nome e a senha
            Diretor roberta = new Diretor("159.753.398-04");
            roberta.Nome = "Roberta";
            roberta.Senha = "123";

            // Criando o objeto camila e informando o nome e a senha
            GerenteDeConta camila = new GerenteDeConta("326.985.628-89");
            camila.Nome = "Camila";
            camila.Senha = "abc";

            // Criando o objeto parceiro e informando a senha
            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "123456";

            // Usando o método Logar para verificar o acesso de cada objeto
            sistemaInterno.Logar(parceiro, "123456");
            sistemaInterno.Logar(roberta, "123");
            sistemaInterno.Logar(camila, "abc");
        }

        public static void CalcularBonificacao()
        {
            // Criando o objeto gerenciadorBonificacao
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            // Criando os objetos das classes derivadas de Funcionario
            Funcionario pedro = new Designer("833.222.048-39");
            pedro.Nome = "Pedro";

            Funcionario roberta = new Diretor("159.753.398-04");
            roberta.Nome = "Roberta";

            Funcionario igor = new Auxiliar("981.198.778-53");
            igor.Nome = "Igor";

            Funcionario camila = new GerenteDeConta("326.985.628-89");
            camila.Nome = "Camila";

            Desenvolvedor guilherme = new Desenvolvedor("456.175.468-20");
            guilherme.Nome = "Guilherme";

            // Usando o método Registrar para calcular o total de bonificação 
            gerenciadorBonificacao.Registrar(guilherme);
            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(camila);

            // Escrevendo em tela o total de bonificação
            Console.WriteLine("Total de Bonificações do Mês: " +
                gerenciadorBonificacao.GetTotalBonificacao());
        }
    }
}
