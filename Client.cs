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
    class Client
    {
        private string nom_prenom;
        private int num;
        private List<Compte> list_compte = new List<Compte>();
        public string Nom_prenom
        {
            get { return this.nom_prenom; }
            set { this.nom_prenom = value; }
        }
        public List<Compte> List_compte
        {
            get { return this.list_compte; }
            set { this.list_compte = value; }
        }
        public int Num
        {
            get { return this.num; }
            set { this.num = value; }
        }
        public Client()
        { }
        public Client(string nom_prenom, int num)
        {
            this.nom_prenom = nom_prenom;
            this.num = num;
        }
        public void Ajouter(Compte C)
        {
            this.list_compte.Add(C);
        }
        public void Supprimer(Compte C)
        {
            this.list_compte.Remove(C);
        }
    }
}
