using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace EjemploListView.Modelo
{
    public class MainPageModel
    {
        public MainPageModel()
        {
            // constructor
        }


        public ObservableCollection<MenuPrincipal> ObtenerMenu()
        {
            ObservableCollection<MenuPrincipal> oMenuPrincipal = new ObservableCollection<MenuPrincipal>();
            
            oMenuPrincipal.Add(new MenuPrincipal
            {
                Opcion = "ListView Ejemplo 1",
                Habilitado = true,
                idOpcion = 1
            });
            oMenuPrincipal.Add(new MenuPrincipal
            {
                Opcion = "ListView Ejemplo 2",
                Habilitado = true,
                idOpcion = 2
            });
            oMenuPrincipal.Add(new MenuPrincipal
            {
                Opcion = "ListView Ejemplo 3",
                Habilitado = true,
                idOpcion = 3
            });
            oMenuPrincipal.Add(new MenuPrincipal
            {
                Opcion = "ListView Ejemplo 4",
                Habilitado = true,
                idOpcion = 4
            });


            return oMenuPrincipal;


        } // Fin del método ObtenerMenu

    }// fin clase
}
