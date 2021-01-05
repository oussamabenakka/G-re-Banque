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
    public partial class SupprimerCmpte : Form
    {
        public SupprimerCmpte()
        {
            InitializeComponent();
        }

        private void SupprimerCmpte_Load(object sender, EventArgs e)
        {
            foreach (Client cl in LesList.clients)
            {
                comboBox1.Items.Add(cl.Num);
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

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult rep = MessageBox.Show("Voulez vous Supprimer ?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rep == DialogResult.Yes)
            {
                Client cl = (Client)LesList.clients[comboBox1.SelectedIndex];
                Compte cp = (Compte)cl.List_compte[comboBox2.SelectedIndex];
                cl.Supprimer(cp);
                foreach(Control c in this.Controls)
                {
                    if (c is TextBox)
                    {
                        c.Text = "";
                        comboBox1.Focus();
                    }
                }
            }
        }
    }
}
