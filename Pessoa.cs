using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Pessoa
    {
        private string Nome { get; set; }
        private string Sobrenome { get; set; }
        private int Idade { get; set; }
        private string Email { get; set; }

        public Pessoa(string nome, string sobrenome, int idade, string email)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Idade = idade;
            Email = email;
        }
    }
}
