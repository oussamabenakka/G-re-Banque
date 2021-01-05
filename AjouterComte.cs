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
    public partial class AjouterComte : Form
    {
        public AjouterComte()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                MessageBox.Show("Donner le numero de compte");
                textBox4.Focus();
            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("Donner le solde");
                textBox3.Focus();
            }
            else if (monthCalendar1.SelectionStart >= monthCalendar1.TodayDate)
            {
                MessageBox.Show("la date n'est pas valide");
                monthCalendar1.Focus();
            }
            if(!radioButton1.Checked && !radioButton2.Checked)
            {
                MessageBox.Show("selectionner le type de compte");
            }
            else
            {
                DialogResult rep = MessageBox.Show("Voulez vous enregistrer ?", "Enregistrement", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rep == DialogResult.Yes)
                {
                    //Compte courant
                    if (radioButton1.Checked)
                    {
                        Courant cu = new Courant(double.Parse(textBox3.Text), int.Parse(textBox4.Text), monthCalendar1.SelectionStart);
                        LesList.comptes.Add(cu);
                        Client cl=(Client)LesList.clients[comboBox1.SelectedIndex];
                        cl.Ajouter(cu);
                        MessageBox.Show("Compte Courant Ajoutée");
                        textBox1.Clear();textBox2.Clear();textBox3.Clear();textBox4.Clear();comboBox1.Focus();
                    }
                    //Compte Epargne
                    else if (radioButton2.Checked)
                    {
                        Epargne ep = new Epargne(double.Parse(textBox3.Text), int.Parse(textBox4.Text), monthCalendar1.SelectionStart);
                        LesList.comptes.Add(ep);
                        Client cl = (Client)LesList.clients[comboBox1.SelectedIndex];
                        cl.Ajouter(ep);
                        MessageBox.Show("Compte Epargne Ajoutée");
                        textBox1.Clear(); textBox2.Clear(); textBox3.Clear(); textBox4.Clear(); comboBox1.Focus();
                    }
                }
            }
            }

        private void AjouterComte_Load(object sender, EventArgs e)
        {
            foreach(Client cl in LesList.clients)
            {
                comboBox1.Items.Add(cl.Num);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Client cl = (Client)LesList.clients[comboBox1.SelectedIndex];
            textBox1.Text = cl.Num.ToString();
            textBox2.Text = cl.Nom_prenom;
        }
    }
}
