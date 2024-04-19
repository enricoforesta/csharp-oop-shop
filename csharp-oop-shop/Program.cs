namespace csharp_oop_shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Prodotto mioProdotto = new Prodotto();

            mioProdotto.Name = "Scarpa";
            mioProdotto.Description = "Scarpe bellissime";
            mioProdotto.Price = 150.99;

            Console.WriteLine($"Codice: {mioProdotto.Code}");
            Console.WriteLine($"Nome: {mioProdotto.Name}");
            Console.WriteLine($"Descrizione: {mioProdotto.Description}");
            Console.WriteLine($" Il prezzo base: {mioProdotto.Price:F2} €. Il prezzo + Iva: {mioProdotto.GetPriceIva():F2} €");

            Console.WriteLine($"Il nome + codice: {mioProdotto.GetCodeName()}");
            Console.WriteLine("Fine");
        }
    }
}
