using System;

namespace ExemploEvento1
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro(10);
            carro.TanqueVazio += new Carro.EventoCarro(tanque_vazio);
            carro.TanqueVazio += new Carro.EventoCarro(ligar_seguro);
            carro.Ligacao += new Carro.Chamar(ligar_casa);
            carro.Ligar();

            Console.ReadKey();
        }
        static void tanque_vazio(){
            Console.WriteLine("Tanque vazio.");
        }

        static void ligar_seguro(){
            Console.WriteLine("Acionando o seguro.");            
        }

        static void ligar_casa(string telefone){
            Console.WriteLine("Ligando para o telefone: " + telefone);
        }
    }
}
