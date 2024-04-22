namespace csharp_oop_shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Esercizio
            {
                Console.WriteLine("Prodotto Base");
                // Prodotto Prodotto = new Prodotto("SCARPE", "BELLE","15");  ESEMPIO SE HO IL COSTRUTTORE CHE ACCETTA PARAMETRI (IVA E DEFAULT MA PUO ASSUMERE ALTRO VALORE)

                Prodotto mioProdotto = new Prodotto();

                mioProdotto.Name = "Scarpa";
                mioProdotto.Description = "Scarpe bellissime";
                mioProdotto.Price = 150.99;

                Console.WriteLine($"Codice: {mioProdotto.Code}");
                Console.WriteLine($"Nome: {mioProdotto.Name}");
                Console.WriteLine($"Descrizione: {mioProdotto.Description}");
                Console.WriteLine($"Il prezzo: {mioProdotto.GetPrice:F2} Euro. Il prezzo + Iva: {mioProdotto.GetPriceIva():F2} Euro");

                Console.WriteLine($"Il nome + codice: {mioProdotto.GetCodeName()}");
                Console.WriteLine($"Il codice Pad : {mioProdotto.GetCodePad()}");
                Console.WriteLine("Fine");
                Console.WriteLine("");
            }

            // Bonus
            {
                Console.WriteLine("Prodotto Bonus");
                Prodotto[] scarpe = 
                {
                    new Prodotto()
                    {
                        Name = "Scarpe da ginnastica",
                        Description = "Scarpe comode per attività sportive",
                        Price = 49.99
                    },
                    new Prodotto()
                    {
                        Name = "Scarpe eleganti",
                        Description = "Scarpe formali per occasioni speciali",
                        Price = 89.99
                    },
                    new Prodotto()
                    {
                        Name = "Scarpe da corsa",
                        Description = "Scarpe leggere per correre",
                        Price = 79.99
                    },
                    new Prodotto()
                    {
                        Name = "Stivali invernali",
                        Description = "Stivali caldi per l'inverno",
                        Price = 129.99
                    },
                    new Prodotto()
                    {
                        Name = "Sandali estivi",
                        Description = "Sandali per l'estate",
                        Price = 39.99
                    }
                };

                // Stampa delle informazioni su ogni prodotto di scarpe
                for (int i = 0; i < scarpe.Length; i++)
                {
                    Console.WriteLine($"Prodotto {i + 1}:");
                    Console.WriteLine($"Codice {scarpe[i].Code}");
                    Console.WriteLine($"Nome: {scarpe[i].Name}");
                    Console.WriteLine($"Descrizione: {scarpe[i].Description}");
                    Console.WriteLine($"Prezzo: {scarpe[i].Price:F2} Euro. Il prezzo + Iva: {scarpe[i].GetPriceIva():F2} Euro");
                    Console.WriteLine($"Il nome + codice: {scarpe[i].GetCodeName()}");
                    Console.WriteLine($"Il codice Pad : {scarpe[i].GetCodePad()}");
                    Console.WriteLine("");
                }
            }

        }
    }
}
