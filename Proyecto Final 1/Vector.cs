using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_1
{
    class Vector
    {
        public int[] v;
        public int n;

        ArchSec A1;
        public Vector()
        {
            v = new int[100];
            n = 0;

            A1 = new ArchSec();
        }

        public void CargarRandom(int n1, int a, int b)
        {
            Random r = new Random();
            n = n1;
            for (int i = 1; i <= n; i++)
                v[i] = r.Next(a, b + 1);
        }

        public void Intercambiar(int a,int b)
        {
            int temp = v[a];
            v[a] = v[b];
            v[b] = temp;
        }
        public void OrdenamientoPorIntercambioAscendente()
        {
            int i, j;

            for(i = 1; i <= n; i++)
            {
                for(j = 1; j < n; j++)
                {
                    if (v[j] > v[j + 1])
                        Intercambiar(j, j + 1);
                }
            }
        }

        //public void UnirVectoresOrdenados(Vector vector1, Vector vector2)
        //{
        //    int i = 1, j = 1, k = 1;
        //    while (i <= vector1.n && j <= vector2.n)
        //    {
        //        if (vector1.v[i] < vector2.v[j])
        //            v[k++] = vector1.v[i++];
        //        else
        //            v[k++] = vector2.v[j++];
        //    }
        //    while (i <= vector1.n)
        //        v[k++] = vector1.v[i++];
        //    while (j <= vector2.n)
        //        v[k++] = vector2.v[j++];
        //    n = k - 1;
        //}
    }
}
