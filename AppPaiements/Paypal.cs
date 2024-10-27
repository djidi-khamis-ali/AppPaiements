using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPaiements
{
    internal class Paypal : Paiement
    {
        public string Courriel { get; set; }


        public Paypal( double montant, string description, string email) : base(montant, description)
        {
            Courriel = email;
        }

        public virtual void AfficheDetails()
        {
            Console.WriteLine($"Montant est {Montant}, sa description est {Description} et son email est {Courriel}.");

        }
    }
}