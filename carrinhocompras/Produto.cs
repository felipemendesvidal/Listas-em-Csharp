namespace carrinhocompras
{
    public class Produto
    {
        //atributos
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }

        //construtor sem parametros
        public Produto(){

        }

        //construtor com parametros
        public Produto(int codigo, string nome, float preco){
            this.Codigo = codigo;
            this.Nome = nome;
            this.Preco = preco;
        }
    }
}