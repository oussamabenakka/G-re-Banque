using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
namespace GereBanque
{
    [Serializable]
    class Epargne:Compte
    {
        private double taux = 6;
        public double Taux
        {
            get { return this.taux; }
        }
        public Epargne() : base()
        { }
        public Epargne(double solde, int num_compte, DateTime date_depart) : base(solde, num_compte, date_depart)
        {

        }

        public override double GetSolde()
        {
            int nbj = DateTime.Now.Subtract(this.date_depart).Days;
            solde += ((nbj * taux * solde) / 100) / 365;
            return solde;
        }
    }
}
