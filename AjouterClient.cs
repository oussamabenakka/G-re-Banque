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
    public partial class AjouterClient : Form
    {
        public AjouterClient()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!char.IsNumber(c) && !char.IsControl(c))
                e.Handled = true;
        }

        private void nbr_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!char.IsNumber(c) && !char.IsControl(c))
                e.Handled = true;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!char.IsNumber(c) && !char.IsControl(c))
                e.Handled = true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!char.IsNumber(c) && !char.IsControl(c))
                e.Handled = true;
        }
        private void AjouterClient_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                foreach (Control c in groupBox2.Controls)
                {
                    if (c is TextBox)
                        c.Enabled = false;
                }
            }
            else
            {
                foreach (Control c in groupBox2.Controls)
                {
                    if (c is TextBox)
                        c.Enabled = true;
                }
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Donner le numero de client");
                textBox1.Focus();
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Donner le nom et le prenom de client");
                textBox2.Focus();
            }
            else if (nbr.Text == "")
            {
                MessageBox.Show("Donner le nombre des comptes");
                nbr.Focus();
            }
            else
            {
                Client cl = new Client(textBox2.Text, int.Parse(textBox1.Text));
                LesList.clients.Add(cl);
                listBox1.Items.Add(cl.Num + " " + cl.Nom_prenom);
            }
        }
        int i = 0;
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!radioButton1.Checked && !radioButton2.Checked)
            {
                MessageBox.Show("Donner le type de compte");
                groupBox1.Focus();
            }
            else if (textBox4.Text == "")
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
            else if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Selectionner un Client");
                listBox1.Focus();
            }
            else
            {
                DialogResult rep = MessageBox.Show("Voulez vous enregistrer ?", "Enregistrement", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rep == DialogResult.Yes)
                {
                    //Compte Courant
                    if (radioButton1.Checked)
                    {
                        i++;
                        Client cl = (Client)LesList.clients[listBox1.SelectedIndex];
                        Courant cu = new Courant(double.Parse(textBox3.Text), int.Parse(textBox4.Text), monthCalendar1.SelectionStart);
                        cl.Ajouter(cu);
                        MessageBox.Show("Compte Courant Ajouter");
                        textBox4.Clear(); textBox3.Clear();
                        if (int.Parse(nbr.Text) <= i)
                        {
                            MessageBox.Show("impossible de ajouter un autre compte");
                            textBox4.Clear(); textBox3.Clear(); textBox1.Clear(); textBox2.Clear(); textBox3.Clear();
                            i = 0;
                        }
                    }
                    //Compte Epargne
                    else if (radioButton2.Checked)
                    {
                        i++;
                        Client cl = (Client)LesList.clients[listBox1.SelectedIndex];
                        Epargne ep = new Epargne(double.Parse(textBox3.Text), int.Parse(textBox4.Text), monthCalendar1.SelectionStart);
                        cl.Ajouter(ep);
                        MessageBox.Show("Compte Epargne Ajouter");
                        textBox4.Clear(); textBox3.Clear();
                        if (int.Parse(nbr.Text) <= i)
                        {
                            MessageBox.Show("impossible de ajouter un autre compte");
                            textBox4.Clear(); textBox3.Clear(); textBox1.Clear(); textBox2.Clear(); textBox3.Clear();
                            i = 0;
                        }
                    }
                }
            }
        }
    }
}
