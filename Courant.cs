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
    class Courant:Compte
    {
        public Courant()
        { }
        public Courant(double solde, int num_compte, DateTime date_depart) : base(solde, num_compte, date_depart)
        {
        }

        public override double GetSolde()
        {
            return solde;
        }
    }
}
