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
    public partial class DeuxGrid : Form
    {
        public DeuxGrid()
        {
            InitializeComponent();
        }

        private void DeuxGrid_Load(object sender, EventArgs e)
        {
            foreach(Client cl in LesList.clients)
            {
                dataGridView1.Rows.Add(cl.Num, cl.Nom_prenom);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dataGridView1.ContainsFocus)
            {
                dataGridView2.Rows.Clear();
                double total = 0;
                Client cl = (Client)LesList.clients[dataGridView1.CurrentRow.Index];
                foreach (Compte cp in cl.List_compte)
                {
                    if (cp is Courant)
                    {
                        dataGridView2.Rows.Add(cp.Num_compte, "Courant", cp.Date_depart.ToShortDateString(), Math.Round(cp.GetSolde(), 2));
                        total += cp.GetSolde();
                    }    
                    else
                    {
                        dataGridView2.Rows.Add(cp.Num_compte, "Epargne", cp.Date_depart.ToShortDateString(), Math.Round(cp.GetSolde(), 2));
                        total += cp.GetSolde();
                    }    
                }
                textBox1.Text = Math.Round(total,2).ToString();
            }
        }
    }
}
