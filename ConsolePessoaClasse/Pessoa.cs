using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePessoaClasse
{
    class Pessoa
    {
        public string nome;
        public int idade;

        //apenas define como int qundo for fazer calculos com numeros
        public string rg;
        public string cpf;

        public void Acenar(Pessoa pessoa)
        {
            Console.WriteLine("{0} acenou para {1}", this.nome, pessoa.nome);
        }

        public void PerguntaIdade (Pessoa pessoa)
        {
            Console.WriteLine("{0} qual sua idade? ", pessoa.nome);
            pessoa.RespostaIdade();
        }

        public void RespostaIdade()
        {
            Console.WriteLine("Eu tenho {0} anos", this.idade);
        }
    }
}
