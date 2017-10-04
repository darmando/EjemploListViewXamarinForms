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
	public partial class EjemploListView2 : ContentPage
	{
        private static bool banderaClick;
        public EjemploListView2()
        {
            InitializeComponent();
            Title = "Ejemplo ListView 2";
            banderaClick = true;
        }// fin constructr

        protected override async void OnAppearing()
        {
            LlenarMenu();
            await Task.Yield();
        }

        public async void LlenarMenu()
        {
            EjemploListView2Model oEjemploListView1Model = new EjemploListView2Model();
            listViewEjemplo2.ItemsSource = null;
            listViewEjemplo2.ItemsSource = oEjemploListView1Model.ObtenerMenuEjemplo1();
            listViewEjemplo2.ItemSelected += OnClickOpcionSeleccionada;
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