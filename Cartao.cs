using System.Collections.Generic;
namespace listas
{
    //não esqueça de por em nome maiusculo classe
    public class Cartao
    {
        //atributos: titular, numero, bandeira, vencimento e cvv;
        public string titula{get; set;}
        public float num {get; set;}
        public string bandeira{get; set;}
        public string vencimento{get; set;}
        public int cvv{get; set;}

        //construtor vazio
        public Cartao(){

        }
        //construtor com atributos
        public Cartao (string Atitular, float Anumero, string Abandeira, string Avencimento, int Acvv){
            this.titula = Atitular;
            this.num = Anumero;
            this.bandeira = Abandeira;
            this.vencimento = Avencimento;
            this.cvv = Acvv;
        }
    }
}