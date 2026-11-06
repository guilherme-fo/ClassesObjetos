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
    }
}