using EjemploListView.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EjemploListView.Vista
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EjemploListView3 : ContentPage
    {
        private static bool banderaClick;
        public EjemploListView3()
        {
            InitializeComponent();
            Title = "Ejemplo ListView 3";
            banderaClick = true;
        }// fin constructr

        protected override async void OnAppearing()
        {
            LlenarMenu();
            await Task.Yield();
        }

        public async void LlenarMenu()
        {
            EjemploListView3Model oEjemploListView1Model = new EjemploListView3Model();
            listViewEjemplo3.ItemsSource = null;
            listViewEjemplo3.ItemsSource = oEjemploListView1Model.ObtenerMenuEjemplo1();
            listViewEjemplo3.ItemSelected += OnClickOpcionSeleccionada;
        }

        private async void OnClickOpcionSeleccionada(object sender, SelectedItemChangedEventArgs e)
        {
            if (banderaClick)
            {
                var item = e.SelectedItem as Alumnos;
                if ((item != null) && (item.Habilitado))
                {
                    var oSeleccionado = item.Nombre;
                    banderaClick = false;

                    await Task.Run(async () =>
                    {
                        await Task.Delay(500);
                        banderaClick = true;
                    });

                }
            } // fin banderaCLick
        }// fin metodo OnClickOpcionSeleccionada

    } // fin de clase
}