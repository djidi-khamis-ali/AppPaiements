using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPaiements
{
    internal class Paiement
    {
            public double Montant { get; set; }
            public string Description { get; set; }


            public Paiement(double montant, string description)
            {
                Montant = montant;
                Description = description;
            }


            public virtual void AfficherDetails()
            {
                Console.WriteLine($" Ca description est {Description} et le montant {Montant} ");

            }
        }
    }
