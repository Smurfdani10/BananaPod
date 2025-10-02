using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prim2
{
    public partial class Form1 : Form
    {
        Grafo g = new Grafo(7);
        public Form1()
        {
            InitializeComponent();
        }

        private void rich_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            rich.Clear();
            g.Insertar();
            g.ImprimirMatriz(rich);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<int[]> Arbol = g.Prim();

            foreach (var arista in Arbol) 
            {
                listBox1.Items.Add($"{arista[0]}\t{arista[1]}");
            }
        }
    }
}
