using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Livro
    {
        private string Nome { get; set; }
        private string Autor { get; set; }
        private DateTime Lancamento { get; set; }
        private string Genero { get; set; }
        public Livro(string nome, string autor, DateTime lancamento, string genero) {
            Nome = nome;
            Autor = autor;
            Lancamento = lancamento;
            Genero = genero;
        }
    }
}
