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
    public partial class SupprimerClient : Form
    {
        public SupprimerClient()
        {
            InitializeComponent();
        }

        private void SupprimerClient_Load(object sender, EventArgs e)
        {
            foreach(Client cl in LesList.clients)
            {
                comboBox1.Items.Add(cl.Num);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult rep = MessageBox.Show("Voulez vous Supprimer ?", "Suppresion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rep == DialogResult.Yes)
            {
                Client cl = (Client)LesList.clients[comboBox1.SelectedIndex];
                LesList.clients.Remove(cl);
                foreach(Control c in this.Controls)
                {
                    if(c is TextBox)
                    {
                        c.Text = string.Empty;
                        comboBox1.Focus();
                    }
                }
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
