using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GereBanque
{
    public partial class AfficherClient : Form
    {
        public AfficherClient()
        {
            InitializeComponent();
        }

        private void AfficherClient_Load(object sender, EventArgs e)
        {
            foreach (Client cl in LesList.clients)
            {
                comboBox1.Items.Add(cl.Num);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            Client cl = (Client)LesList.clients[comboBox1.SelectedIndex];
            foreach (Compte cp in cl.List_compte)
            {
                if (cp is Courant)
                {
                    dataGridView1.Rows.Add(cl.Num, cl.Nom_prenom, cp.Num_compte, "Courant", cp.Date_depart.ToShortDateString(), Math.Round(cp.GetSolde(), 2));   
                }
                else if (cp is Epargne)
                {
                    dataGridView1.Rows.Add(cl.Num, cl.Nom_prenom, cp.Num_compte, "Epargne", cp.Date_depart.ToShortDateString(), Math.Round(cp.GetSolde(), 2));
                }
            }
        }
    }
}
