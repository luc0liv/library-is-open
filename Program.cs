//Exercicio:
//Criar projeto novo(biblioteca), criar 3 classes: emprestimo, livro e pessoa.
//criar de 3 a 5 atributos em cada classe e métodos contrutores. usar UML para praticar.

using System;

namespace Biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Emprestimo emprestimo = new();
            Console.WriteLine(emprestimo.Emprestar(new Pessoa("Luciana", "Cunha", 29, "luckaksa@gmail.com"),
                new Livro("Nome", "MARUA", new DateTime(2000, 04, 20), "Terror"), new DateTime(2023, 08, 12)));
            Console.WriteLine(emprestimo.Devolver());

            Emprestimo emprestimo2 = new();
            Console.WriteLine(emprestimo2.Emprestar(new Pessoa("Luciana", "Cunha", 29, "luckaksa@gmail.com"),
                new Livro("Nome", "Dom Casmurro", new DateTime(2000, 04, 20), "Romance"), new DateTime(2023, 08, 11)));
            Console.WriteLine(emprestimo2.Devolver());


            Console.ReadLine();
        }
    }
}