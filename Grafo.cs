using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prim2
{
    internal class Grafo
    {
        int[,] matriz;
        int numNodos;
        public Grafo(int numNodos)
        {
            this.numNodos = numNodos;
            matriz = new int[numNodos, numNodos];
        }

        public void Insertar() 
        {
            matriz[0, 1] = 2;
            matriz[1,2] = 4;
            matriz[0,3] = 1;
            matriz[1,3] = 3;
            matriz[1,4] = 10;
            matriz[2,5] = 5;
            matriz[3,2] = 2;
            matriz[3,5] = 8;
            matriz[3,6] = 4;
            matriz[4,3] = 2;
            matriz[4,6] = 6;
            matriz[6,5] = 1;
        }
        public void ImprimirMatriz(RichTextBox rich) 
        {
            for (int i = 0; i < numNodos; i++) 
            {
                for (int j = 0; j < numNodos; j++) 
                {
                    rich.Text += matriz[i, j] + "\t";
                }
                rich.Text += "\n";
            }
        }
        public List<int[]> Prim() 
        {
            List<int[]> ArbolExpansion = new List<int[]>();
            HashSet<int> VerticesVisitados = new HashSet<int>();

            int verticeInicial = 0;

            VerticesVisitados.Add(verticeInicial);

            while (VerticesVisitados.Count < numNodos)
            {
                int[] aristaMinima = null;
                int CostoMinimo = int.MaxValue;
                foreach (int i in VerticesVisitados)
                {
                    for (int j = 0; j < numNodos; j++) 
                    {
                        if (!VerticesVisitados.Contains(j) && matriz[i,j] != 0) 
                        { 
                            int costoArista = matriz[i, j];
                            if (costoArista < CostoMinimo) 
                            {
                                aristaMinima = new int[] {i, j};
                                CostoMinimo = costoArista;
                            }
                        }
                    }
                }
                ArbolExpansion.Add(aristaMinima);
                VerticesVisitados.Add(aristaMinima[1]);
            }

            return ArbolExpansion;
        }
    }
   
}
