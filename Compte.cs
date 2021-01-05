using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace GereBanque
{[Serializable]
    class Compte
    {
        protected double solde;
        protected int num_compte;
        protected DateTime date_depart;
        public double Solde
        {
            get { return this.Solde; }
        }
        public int Num_compte
        {
            get { return this.num_compte; }
            set { this.num_compte = value; }
        }
        public DateTime Date_depart
        {
            get { return this.date_depart; }
            set { this.date_depart = value; }
        }
        public Compte()
        { }
        public Compte(double solde, int num_compte, DateTime date_depart)
        {
            this.solde = solde;
            this.num_compte = num_compte;
            this.date_depart = date_depart;
        }
        public void Deposer(double somme)
        {
            this.solde += somme;
        }
        public void Retierer(double somme)
        {
            this.solde -= somme;
        }
        public virtual double GetSolde()
        {
            return Solde;
        }
    }
}
