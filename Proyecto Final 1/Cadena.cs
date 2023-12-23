using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_1
{
    class Cadena
    {
        public string s;

        public Cadena()
        {
            s = "";
        }

        public void Cargar(string s1)
        {
            s = s1;
        }

        public string OrdenarPorApellidoPaterno()
        {
            // nombre ap.paterno ap. materno
            string[] v = s.Split(' ');
            return $"{v[1]} {v[2]} {v[0]}";
        }
        public bool VerificarApellidoPaternoMasLargo()
        {
            string[] v = s.Split(' ');
            return v[1].Length > v[2].Length;
        }
    }
}
