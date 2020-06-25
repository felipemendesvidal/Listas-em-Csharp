namespace carrinhocompras
{
    public class Carrinho
    {
        //atributo 
        public float ValorTotal { get; set; }

        //lista da classe produto
        List<Produto> carrinho = new List<Produto>();

        //metodo que usa a class produto como um atributo
        public void Adicionar(Produto _produto)
        {
            carrinho.Add(_produto);
        }
        //metodo que usa a class produto como um atributo
        public void Remover(Produto _produto)
        {
            carrinho.Remove(_produto);
        }

        public void Ler()
        {
            foreach(Produto item in carrinho)
            {
                Console.WriteLine($"{item.Nome} - R$ {item.Preco} ");
            }
        }

        public void Alterar(int _codigo, Produto _produtoAlterado)
        {
            carrinho.Find(z => z.Codigo == _codigo).Nome  = _produtoAlterado.Nome;
            carrinho.Find(z => z.Codigo == _codigo).Preco = _produtoAlterado.Preco;
        }

        public void MostrarTotal()
        {
            foreach(Produto item in carrinho)
            {
                ValorTotal += item.Preco;
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Total dos itens: R$ {ValorTotal} ");
            Console.ResetColor();
    }
}