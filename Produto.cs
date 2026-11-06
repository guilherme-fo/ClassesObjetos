namespace ClassesObjetos
{
    public class Produto
    {
        int Quantidade; // => Campo: é uma forma simplificada de representar atributos
        public string? Nome {get; set;}
        public decimal Preco {get; private set;}

        public void Exibir()
        {
            Console.WriteLine($"{Nome} - {Preco:C}");
        }

        public void AlterarPreco(decimal novoPreco)
        {
            if (novoPreco > 0)
            {
                Preco = novoPreco;
            }
            else
            {
                Console.WriteLine("Valor inválido.");
            }
        }

        public Produto() // O método contrutor sempre terá o mesmo nome da classe
        {
            Nome = "Não informado";
            Preco = 0m;
        }

        public Produto(string nome, decimal valor)
        {
            Nome = nome;
            Preco = valor;
        }
    }
}