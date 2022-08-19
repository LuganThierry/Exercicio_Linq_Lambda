using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace TP.Aula06Exer
{
    internal class Program
    {
        public class Produto
        {

            public int Id { get; set; }
            public string Nome { get; set; }
            public decimal Valor { get; set; }
            public bool Ativo { get; set; }


            public override string ToString()
            {
                return $"Id: {Id} | Nome: {Nome} | Valor: R$ {Valor}";
            }

        }

        private static List<Produto> listaProdutos = new()
        {
            new Produto{Id = 2, Nome = "Camiseta", Valor = 52, Ativo = true},
            new Produto{Id = 8, Nome = "Guarda-Chuva", Valor = 19, Ativo = true},
            new Produto{Id = 4, Nome = "Celular", Valor = 8500, Ativo = true},
            new Produto{Id = 3, Nome = "Arroz", Valor = 21, Ativo = false},
            new Produto{Id = 1, Nome = "Geladeira", Valor = 1900, Ativo = true},
            new Produto{Id = 9, Nome = "Panela", Valor = 41, Ativo = true},
            new Produto{Id = 5, Nome = "Chinelo", Valor = 11, Ativo = false},
            new Produto{Id = 7, Nome = "TV", Valor = 2350, Ativo = true},
            new Produto{Id = 6, Nome = "Patins", Valor = 66, Ativo = true},
        };

        // EXERCÍCIO 1
        public static List<Produto> RetornaProdutoFimLetraC(string letra)
        {
            return listaProdutos.Where(prod => prod.Nome.ToLower().EndsWith(letra.ToLower())).ToList();

        }

        // ------------------------------------------------------

        //EXERCÍCIO 2
        public static List<Produto> RetornaProdutoMenorValor(int valor)
        {
            return listaProdutos.Where(prod => prod.Valor < valor).ToList();
        }

        // ------------------------------------------------------

        //EXERCÍCIO 3
        public static decimal RetornaProdutoInativoMedia()
        {
            return listaProdutos.Where(prod => prod.Ativo == false).Average(prod => prod.Valor); 
        }

        // ------------------------------------------------------

        // EXERCÍCIO 4
        public static string RetornaPrimeiroMenorValor()
        {
            return listaProdutos.Where(prod => prod.Valor < 10).FirstOrDefault().ToString();
        }

        // ------------------------------------------------------

        // EXERCÍCIO 5
        public static string RetornaUltimoDecrescente()
        {
            return listaProdutos.OrderByDescending(prod => prod.Nome).LastOrDefault().ToString();
        }



        // EXERCÍCIO 6
        public static void MetodoAlteracaoValor(int idEntrada, decimal valorEntrada)
        {
            if (listaProdutos.Any(prod => prod.Id == idEntrada))
            {
                Produto produto = listaProdutos.Where((prod) => prod.Id == idEntrada).Single();

                produto.Valor = valorEntrada;
            }
            else
            {
                Console.WriteLine("O produto com ID informado não existe");
            }
        }


        static void Main(string[] args)
        {

            // TESTES DOS MÉTODOS

            // ------------------------------------------------------

            // EXERCÍCIO 1
            //var retorno = RetornaProdutoFimLetraC("O");

            //foreach (Produto produto in retorno)
            //{
            //    Console.WriteLine(produto.Nome);
            //}

            // ------------------------------------------------------

            // EXERCÍCIO 2

            //var retorno = RetornaProdutoMenorValor(50);

            //foreach (Produto produto in retorno)
            //{
            //    Console.WriteLine(produto.Nome);
            //}

            // ------------------------------------------------------

            // EXERCÍCIO 3

            //var retorno = RetornaProdutoInativoMedia();

            //Console.WriteLine(retorno);

            // ------------------------------------------------------

            //EXERCÍCIO 4

            //var retorno = RetornaPrimeiroMenorValor();

            //Console.WriteLine(retorno);

            // ------------------------------------------------------

            // EXERCÍCIO 5

            //var retorno = RetornaUltimoDecrescente();

            //Console.WriteLine( retorno );

            // ------------------------------------------------------

            // EXERCÍCIO 6

            //MetodoAlteracaoValor(2, 100);

            //Console.WriteLine(listaProdutos[0]);

            // ------------------------------------------------------


        }
    }
}