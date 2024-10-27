using AppPaiements;
using System.Text.Json.Serialization.Metadata;

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


   
        Paypal paypal1 = new Paypal(90000,"ajout","al@gmail.com");
        Paypal paypal2 = new Paypal(10000,"bon","dl@yahoo.fr");
        List<Paypal> paypals = new List<Paypal> { paypal1, paypal2 };
        Console.WriteLine("les comptes paypals sont :");
        foreach (var Paypal in paypals)
        {
            Paypal.AfficheDetails();
        }

        Utilisateur utilisateur1 = new Utilisateur("Khamis");
        List<Utilisateur> utilisateurs = new List<Utilisateur> { utilisateur1 };
        foreach (var utilisateur in utilisateurs)
        {
            utilisateur.AjouterPaiement(paypal1);
            utilisateur.AjouterPaiement(paypal2);
            utilisateur.AjouterPaiement(carteCredit1);
            utilisateur.AjouterPaiement(carteCredit2);
            utilisateur.AjouterPaiement(carteCredit3);

            utilisateur.Afficherinfos();

        }
    }

}



