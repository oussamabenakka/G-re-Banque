using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace GereBanque
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjouterClient ac = new AjouterClient();
            ac.MdiParent = this;
            ac.Show();
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupprimerClient sc = new SupprimerClient();
            sc.MdiParent = this;
            sc.Show();
        }

        private void afficherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AfficherClient ac = new AfficherClient();
            ac.MdiParent = this;
            ac.Show();
        }

        private void ajouterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AjouterComte aj = new AjouterComte();
            aj.MdiParent = this;
            aj.Show();
        }

        private void supprimerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SupprimerCmpte sp = new SupprimerCmpte();
            sp.MdiParent = this;
            sp.Show();
        }

        private void deposerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Deposer_Retirer dr = new Deposer_Retirer();
            dr.MdiParent = this;
            dr.Show();
        }

        private void sauvgarderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream F = new FileStream("banc.txt", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(F, LesList.clients);
            F.Close();
            MessageBox.Show("Sauvgarder");
        }

        private void restaurerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream F = new FileStream("banc.txt", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            LesList.clients = (List<Client>)bf.Deserialize(F);
            F.Close();
            MessageBox.Show("Restaurer");
        }

        private void ewAffichageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeuxGrid dg = new DeuxGrid();
            dg.MdiParent = this;
            dg.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void horizontaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void iconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
