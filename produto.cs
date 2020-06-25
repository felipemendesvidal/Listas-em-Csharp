using System.Collections.Generic;
namespace listas
{
    public class produto
    {   
        public int codigo { get; set; }
        public string nome { get; set; }
        public float preco { get; set; }

        public produto(){

        }

        public produto(int Acodigo, string Anome, float Apreco){
            this.codigo = Acodigo;
            this.nome = Anome;
            this.preco = Apreco;
        }
        
    }
}