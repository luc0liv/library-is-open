using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Emprestimo
    {
        private DateTime DataEmprestimo { get; set; }
        private DateTime DataEstorno { get; set; }
        public DateTime DataEstimadaRetorno { get; set; }

        private Pessoa? Pessoa { get; set; }
        private Livro? Livro { get; set; }
    
        public Emprestimo()
        {
        }

        public string Emprestar(Pessoa pessoa, Livro livro, DateTime dataEstimadaRetorno)
        {   
            Pessoa = pessoa;
            Livro = livro;
            DataEmprestimo = DateTime.Now;
            return DataEmprestimo.ToString();
        }

        public string Devolver()
        {
            DataEstorno = DateTime.Now;
            if (DataEstorno > DataEstimadaRetorno)
            {
                return "Atrasado";
            } else
            {
                return "Devolvido";
            }
        }


    }
}
