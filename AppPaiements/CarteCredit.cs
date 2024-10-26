using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPaiements
{
   
    
        internal class CarteCredit : Paiement
        {

            public int NumeroCarte { get; set; }


            public CarteCredit(int numeroCarte, double montant, string description) : base(montant, description)
            {
                NumeroCarte = numeroCarte;
            }

            public override void AfficherDetails()
            {
                Console.WriteLine($"le montant est {Montant}, le numéro de la carte est {NumeroCarte} et la description est {Description}.");
            }

        }
    
}
