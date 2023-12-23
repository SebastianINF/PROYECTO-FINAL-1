using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Proyecto_Final_1
{
    public partial class Form1 : Form
    {
        ArchSec a1, a2, a3;
        Vector v1;
        NEnt n1;
        Cadena s1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            a1 = new ArchSec();
            a2 = new ArchSec();
            v1 = new Vector();
            a3 = new ArchSec();
            n1 = new NEnt();
            s1 = new Cadena();
        }

        private void btnDimensionar_Click(object sender, EventArgs e)
        {
            int nroFilas = Convert.ToInt32(Interaction.InputBox("Dimension: "));
            dataGridView1.RowCount = nroFilas + 1;
            int i = 0;
            while(i < nroFilas)
            {
                dataGridView1.Rows[i].Cells[0].Value = i + 1;
                i++;
            }
        }
        public void Limpiar()
        {
            a1 = new ArchSec();
            a2 = new ArchSec();
            n1 = new NEnt();
            dataGridView1.Rows.Clear();
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void leerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int c = -1;
            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
            a1.Abrir_Leer(openFileDialog1.FileName);
            dataGridView1.Rows.Clear();
            while (!a1.Verif_Fin())
            {
                c++;
                dataGridView1.Rows.Add(c + 1, "");
                dataGridView1.Rows[c].Cells[1].Value = Convert.ToString(a1.Leer());
            }
            a1.Cerrar_Leer();
        }

        private void cargarRandomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Limpiar(); 

            int a = int.Parse(Interaction.InputBox("Rango a:"));
            int b = int.Parse(Interaction.InputBox("Rango b: "));
            int nroFilas = int.Parse(Interaction.InputBox("Numero de elementos: "));
            int i = 0;
            Random r = new Random();
            dataGridView1.RowCount = nroFilas + 1;

            while (i < nroFilas)
            {
                dataGridView1.Rows[i].Cells[0].Value = i + 1;
                dataGridView1.Rows[i].Cells[1].Value = r.Next(a, b + 1);
                i++;
            }
        }

        private void grabarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int c = 0;
            if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;
            a1.Abrir_Grabar(saveFileDialog1.FileName);
            while (dataGridView1.Rows[c].Cells[1].Value != null)
            {
                a1.Grabar(Convert.ToInt32(dataGridView1.Rows[c].Cells[1].Value));
                c++;
            }
            a1.Cerrar_Grabar();
        }

        private void seleccionarDigitosIgualesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            n1 = new NEnt();
            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
            a1.Abrir_Leer(openFileDialog1.FileName);
            saveFileDialog1.FileName = "ArchivoDigitosIguales";
            if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;
            a2.Abrir_Grabar(saveFileDialog1.FileName);

            while (!a1.Verif_Fin())
            {
                int numero = a1.Leer();
                n1.Cargar(numero);
                if (n1.VerificarDigitosIguales())
                {
                    a2.Grabar(numero);
                }
            }
            a2.Cerrar_Grabar();
            a1.Cerrar_Leer();
        }

        private void seleccionarDigitosDiferentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            n1 = new NEnt();
            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
            a1.Abrir_Leer(openFileDialog1.FileName);
            saveFileDialog1.FileName = "ArchivoDigitosDiferentes";
            if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;
            a2.Abrir_Grabar(saveFileDialog1.FileName);

            while (!a1.Verif_Fin())
            {
                int numero = a1.Leer();
                n1.Cargar(numero);
                if (n1.VerificarDigitosDiferentes())
                {
                    a2.Grabar(numero);
                }
            }
            a2.Cerrar_Grabar();
            a1.Cerrar_Leer();
        }

        // 3. Unir Archivos Ordenados (arreglar) se come un elemento
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
            a1.Abrir_Leer(openFileDialog1.FileName);
            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
            a2.Abrir_Leer(openFileDialog1.FileName);
            saveFileDialog1.FileName = "ArchivoUnido";
            if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;
            a3.Abrir_Grabar(saveFileDialog1.FileName);

            int numero1 = a1.Verif_Fin() ? int.MaxValue : a1.Leer();
            int numero2 = a2.Verif_Fin() ? int.MaxValue : a2.Leer();
     
            while (!a1.Verif_Fin() || !a2.Verif_Fin())
            {
                if (numero1 < numero2)
                {
                    a3.Grabar(numero1);
                    numero1 = a1.Verif_Fin() ? int.MaxValue : a1.Leer();
                }
                else
                {
                    a3.Grabar(numero2);
                    numero2 = a2.Verif_Fin() ? int.MaxValue : a2.Leer();
                }
            }

            a3.Cerrar_Grabar();
            a2.Cerrar_Leer();
            a1.Cerrar_Leer();
        }

        private void cargarOrdenadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Limpiar();
            v1 = new Vector();

            int a = int.Parse(Interaction.InputBox("Rango a:"));
            int b = int.Parse(Interaction.InputBox("Rango b: "));
            int nroFilas = int.Parse(Interaction.InputBox("Numero de elementos: "));
            int i = 0;
            Random r = new Random();
            dataGridView1.RowCount = nroFilas + 1;

            v1.CargarRandom(nroFilas, a, b);
            v1.OrdenamientoPorIntercambioAscendente();

            while (i < nroFilas)
            {
                dataGridView1.Rows[i].Cells[0].Value = i + 1;
                dataGridView1.Rows[i].Cells[1].Value = v1.v[i + 1];
                i++;
            }
        }


        // Cadenas
        private void grabarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int c = 0;
            if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;
            a1.Abrir_Grabar(saveFileDialog1.FileName);
            while (dataGridView1.Rows[c].Cells[1].Value != null)
            {
                a1.Grabar(Convert.ToString(dataGridView1.Rows[c].Cells[1].Value));
                c++;
            }
            a1.Cerrar_Grabar();
        }

        private void leerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int c = -1;
            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
            a1.Abrir_Leer(openFileDialog1.FileName);
            dataGridView1.Rows.Clear();
            while (!a1.Verif_Fin())
            {
                c++;
                dataGridView1.Rows.Add(c + 1, "");
                dataGridView1.Rows[c].Cells[1].Value = a1.LeerString();
            }
            a1.Cerrar_Leer();
        }
        private void ordenarPorApellidoPaternoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            s1 = new Cadena();
            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
            a1.Abrir_Leer(openFileDialog1.FileName);
            saveFileDialog1.FileName = "ArchivoApellidoPaternoOrdenado";
            if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;
            a2.Abrir_Grabar(saveFileDialog1.FileName);
            while (!a1.Verif_Fin())
            {
                s1.Cargar(a1.LeerString());
                a2.Grabar(s1.OrdenarPorApellidoPaterno());
            }
            a2.Cerrar_Grabar();
            a1.Cerrar_Leer();
        }
        private void separarArchivoPorApellidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            s1 = new Cadena();

            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
            a1.Abrir_Leer(openFileDialog1.FileName);
            
            saveFileDialog1.FileName = "Archivo Apellido Paterno Mas Largo";
            if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;
            a2.Abrir_Grabar(saveFileDialog1.FileName);

            saveFileDialog1.FileName = "Archivo Apellido Materno Mas Largo";
            if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;
            a3.Abrir_Grabar(saveFileDialog1.FileName);


            while (!a1.Verif_Fin() || !a2.Verif_Fin())
            {
                s1.Cargar(a1.LeerString());
                if (s1.VerificarApellidoPaternoMasLargo())
                {
                    a2.Grabar(s1.s);
                }else
                {
                    a3.Grabar(s1.s);
                }
            }

            a2.Cerrar_Grabar();
            a3.Cerrar_Grabar();
            a1.Cerrar_Leer();
        }
    }
}
