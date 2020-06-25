/*
*Enunciado da atividade: 
Nesta atividade faça o mesmo exemplo dado em aula, incrementando com uma classe Cartao, com seus devidos métodos construtores e atributos: titular, numero, bandeira, vencimento e cvv;
Crie uma lista de cartões no Program.cs, utilize foreach para mostrar para o usuário os cartões instanciados.

Feito por: Felipe Vidal
*/
using System;
using System.Collections.Generic;

namespace listas
{
    class Program
    {
        static void Main(string[] args)
        {
            //criando a lista
            List <produto> produtos = new List < produto > ();
            //criando o objeto produto
            produto objetoQ = new produto();
            //adicionando valores aos atributos colocado na classe produto
            objetoQ.codigo = 1;
            objetoQ.nome = "celular";
            objetoQ.preco = 2.50f;

            //adicionando elementos na lista "produtos"
            produtos.Add(objetoQ);

            //adicionando mais elementos na lista de produtos de outra forma
            produtos.Add( new produto(2, "Galaxy", 2500.98f) );
            produtos.Add( new produto(3, "Xiaomi", 2500.98f) );
            produtos.Add( new produto(4, "Asus", 2500.98f) );
            produtos.Add( new produto(5, "Lenovo", 2500.98f) );
            produtos.Add( new produto(6, "Asus", 2500.98f) );

             //verificação com o laço foreach
         foreach(produto p in produtos)
            {   
                //colorização
                Console.ForegroundColor = ConsoleColor.Green; 

                //$interpolação             
                Console.WriteLine($"R$ {p.preco} - {p.nome}");
                Console.ResetColor();
            }
            
            // Remove um item em específico
            //produtos.Remove(celular1);

            // Remove através de um índice
            //produtos.RemoveAt(1);

            // Removemos utilizando expressão Lambda
            //produtos.RemoveAll( p => p.Nome == "Asus" );

            // Procuramos um produto específico
            //Produto lenovo = produtos.Find(x => x.Nome == "Xiaomi");
            
            //Console.ForegroundColor = ConsoleColor.Blue;
            //Console.WriteLine( lenovo.Preco );
            //Console.ResetColor();

            //lista cartao
            List<Cartao> cartoes = new List<Cartao>();

            //objeto
            Cartao cartaog = new Cartao();

            //itens titular, numero, bandeira, vencimento e cvv;
            cartaog.titula = "ze ninguem";
            cartaog.num = 1234;
            cartaog.bandeira="master";
            cartaog.vencimento ="123";
            cartaog.cvv = 321;

            //adicionando elementos na lista "produtos"
           cartoes.Add(cartaog);

            //verificação
            foreach(Cartao c in cartaog)
            {   
                //colorização
                Console.ForegroundColor = ConsoleColor.Red; 

                //$interpolação             
                Console.WriteLine($"R$ {c.titula} - {c.num} - {c.bandeira}");
                Console.ResetColor();
            }


        }
    }
}
