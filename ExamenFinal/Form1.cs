using ExamenFinal.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenFinal
{
    public partial class Form1 : Form
    {
        //Invoco la clase que usare
        CxPrincipal Fate;
        public Form1()
        {
            InitializeComponent();
            Fate = new CxPrincipal();
        }

        private void buttonProbar_Click(object sender, EventArgs e)
        {
            if (Fate.probarConexion())
            {
                MessageBox.Show("Si se pudo 🧐🧐");
            }
            else
            {
                MessageBox.Show("Nel Pastel 🦁🦁");
            }
        }
    }
}
