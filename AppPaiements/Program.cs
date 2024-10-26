using AppPaiements;

internal class Program
{
    private static void Main(string[] args)
    {
        CarteCredit carteCredit1 = new CarteCredit(27596597, 10000000, "Tchad");
        CarteCredit carteCredit2 = new CarteCredit(30216560, 1628173, "boss");
        CarteCredit carteCredit3 = new CarteCredit(182413, 127500, "juge");
        List<CarteCredit> CarteCredits = new List<CarteCredit> { carteCredit1, carteCredit2, carteCredit3 };
        Console.WriteLine("les cartes de credits sont :");
        foreach (var CarteCredit in CarteCredits)
        {
            CarteCredit.AfficherDetails();
        }

    }
}
