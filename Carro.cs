using System.Threading;

namespace ExemploEvento1
{
    public class Carro
    {
        int qtdTanque = 0;

        public Carro(int qtdGasolina)
        {
            this.qtdTanque = qtdGasolina;
        }

        public void Ligar(){
            
            while(true){
                System.Console.WriteLine("Tanque: " + this.qtdTanque);
                Thread.Sleep(500);
                this.qtdTanque--;
                
                if (this.qtdTanque.Equals(3)){
                    this.Ligacao("4748-2759");
                }
                
                if (this.qtdTanque.Equals(0)){
                    this.TanqueVazio();
                    break;
                }    
            }
        }
        
    public delegate void EventoCarro();
    public event EventoCarro TanqueVazio;

    public delegate void Chamar(string texto);
    public event Chamar Ligacao;

    }
   
}