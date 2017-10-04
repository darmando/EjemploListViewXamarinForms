using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace EjemploListView.Modelo
{
    public class EjemploListView2Model
    {
        public EjemploListView2Model()
        {
            // constructor
        }

        public ObservableCollection<Alumnos> ObtenerMenuEjemplo1()
        {
            ObservableCollection<Alumnos> oMenuPrincipal = new ObservableCollection<Alumnos>();

            oMenuPrincipal.Add(new Alumnos
            {
                Nombre = "Diego Armando Lira Rodríguez",
                Habilitado = true,
                FechaNacimiento = "21/10/1992",
                AnioEscolar = 6,
                PromedioEscolar = 10,
                Notas = "Excelente alumno, muy atento a las clases.",
                Imagen = null
            });
            oMenuPrincipal.Add(new Alumnos
            {
                Nombre = "Ana Luisa López López",
                Habilitado = true,
                FechaNacimiento = "01/09/1987",
                AnioEscolar = 6,
                PromedioEscolar = 8.8,
                Notas = "Excelente alumno pero falta mucho en sus tareas.",
                Imagen = null
            });
            oMenuPrincipal.Add(new Alumnos
            {
                Nombre = "Maria del Barrio Martínez",
                Habilitado = true,
                FechaNacimiento = "08/10/1967",
                AnioEscolar = 6,
                PromedioEscolar = 9.0,
                Notas = "Muy dedicado pero le hace falta estudiar más.",
                Imagen = null
            });
            oMenuPrincipal.Add(new Alumnos
            {
                Nombre = "Julio Adrian Morelos Marian",
                Habilitado = true,
                FechaNacimiento = "21/10/1992",
                AnioEscolar = 4,
                PromedioEscolar = 6.1,
                Notas = "Falta mucho a clases y no entrega todas las tareas.",
                Imagen = null
            });
            oMenuPrincipal.Add(new Alumnos
            {
                Nombre = "Holanda Mariela Ortega Macias",
                Habilitado = true,
                FechaNacimiento = "21/10/1992",
                AnioEscolar = 1,
                PromedioEscolar = 7.5,
                Notas = "Bajas calificaciones, sin embargo ya va mejorando.",
                Imagen = null
            });


            return oMenuPrincipal;


        } // Fin del método ObtenerMenu

    } // Fin clase
}
