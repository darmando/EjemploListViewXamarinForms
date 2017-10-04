using System;
using System.Collections.Generic;
using System.Text;

namespace EjemploListView.Modelo
{
    public class Alumnos
    {
        public string Nombre { get; set; }
        public bool Habilitado { get; set; }
        public string FechaNacimiento { get; set; }
        public int AnioEscolar { get; set; }
        public double PromedioEscolar { get; set; }
        public string Notas { get; set; }
        public string Imagen { get; set; }
        public Alumnos()
        {
            // constructor

        }
    }
}
