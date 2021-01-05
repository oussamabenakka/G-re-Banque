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
    public partial class Deposer_Retirer : Form
    {
        public Deposer_Retirer()
        {
            InitializeComponent();
        }

        private void Deposer_Retirer_Load(object sender, EventArgs e)
        {
            foreach (Client cl in LesList.clients)
            {
                comboBox1.Items.Add(cl.Num);
            }
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Client cl = (Client)LesList.clients[comboBox1.SelectedIndex];
            Compte cp = (Compte)cl.List_compte[comboBox2.SelectedIndex];
            if (cp is Courant)
            {
                textBox3.Text = "Courant";
                textBox4.Text = cp.Num_compte.ToString();
                textBox5.Text = cp.GetSolde().ToString();
            }
            else if (cp is Epargne)
            {
                textBox3.Text = "Eparne";
                textBox4.Text = cp.Num_compte.ToString();
                textBox5.Text = cp.GetSolde().ToString();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Client cl = (Client)LesList.clients[comboBox1.SelectedIndex];
            textBox1.Text = cl.Num.ToString();
            textBox2.Text = cl.Nom_prenom;
            foreach (Compte cp in cl.List_compte)
            {
                comboBox2.Items.Add(cp.Num_compte);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Client cl = (Client)LesList.clients[comboBox1.SelectedIndex];
            Compte cp = (Compte)cl.List_compte[comboBox2.SelectedIndex];
            if (cp is Courant)
            {
                cp.Deposer(double.Parse(textBox6.Text));
                textBox5.Text = cp.GetSolde().ToString();
            }
                
            else if (cp is Epargne)
            {
                cp.Deposer(double.Parse(textBox6.Text));
                textBox5.Text = cp.GetSolde().ToString();
            }
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Client cl = (Client)LesList.clients[comboBox1.SelectedIndex];
            Compte cp = (Compte)cl.List_compte[comboBox2.SelectedIndex];
            if (cp is Courant)
            {
                cp.Retierer(double.Parse(textBox6.Text));
                textBox5.Text = cp.GetSolde().ToString();
            }

            else if (cp is Epargne)
            {
                cp.Retierer(double.Parse(textBox6.Text));
                textBox5.Text = cp.GetSolde().ToString();
            }
        }
    }
}
