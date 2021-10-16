using System;

namespace ConsolePessoaClasse
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();

            Console.WriteLine("Digite o nome: ");
            pessoa.nome = Console.ReadLine();

            Console.WriteLine("Digite sua idade: ");
            pessoa.idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite seu RG: ");
            pessoa.rg = Console.ReadLine();

            Console.WriteLine("Digite sei CPF: ");
            pessoa.cpf = Console.ReadLine();

            Console.WriteLine("Nome: {0}", pessoa.nome);
            Console.WriteLine("Idade: {0}", pessoa.idade);
            Console.WriteLine("RG: {0}", pessoa.rg);
            Console.WriteLine("CPF {0}", pessoa.cpf);

            Pessoa pessoaDani = new Pessoa();
            pessoaDani.nome = "Daniele Marighetti";
            pessoaDani.idade = 32;
            pessoaDani.rg = "12.000.00.-00";
            pessoaDani.cpf = "123.000.000-00";

            Console.WriteLine("Nome: {0}", pessoaDani.nome);
            Console.WriteLine("Idade: {0}", pessoaDani.idade);
            Console.WriteLine("RG: {0}", pessoaDani.rg);
            Console.WriteLine("CPF {0}", pessoaDani.cpf);

            pessoa.Acenar(pessoaDani);
            pessoa.PerguntaIdade(pessoaDani);
        }
    }
}
