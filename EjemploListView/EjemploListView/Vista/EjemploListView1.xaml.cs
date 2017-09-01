using EjemploListView.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EjemploListView
{
	public partial class EjemploListView1 : ContentPage
    {
        private static bool banderaClick;
        public EjemploListView1 ()
		{
			InitializeComponent ();
            Title = "Ejemplo ListView 1";
            banderaClick = true;
        }// fin constructr

        protected override async void OnAppearing()
        {
            LlenarMenu();
            await Task.Yield();
        }

        public async void LlenarMenu()
        {
            EjemploListView1Model oEjemploListView1Model = new EjemploListView1Model();
            listViewEjemplo1.ItemsSource = null;
            listViewEjemplo1.ItemsSource = oEjemploListView1Model.ObtenerMenuEjemplo1();
            listViewEjemplo1.ItemSelected += OnClickOpcionSeleccionada;
        }

        private async void OnClickOpcionSeleccionada(object sender, SelectedItemChangedEventArgs e)
        {
            if (banderaClick)
            {
                var item = e.SelectedItem as MenuEjemplo1;
                if ((item != null) && (item.Habilitado))
                {
                    var oSeleccionado = item.idOpcion;
                    banderaClick = false;
                    switch (oSeleccionado)
                    {
                        case 1:
                            Navigation.PushAsync(new EjemploListView1());
                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                    }
                    await Task.Run(async () =>
                    {
                        await Task.Delay(500);
                        banderaClick = true;
                    });

                }
            } // fin banderaCLick
        }// fin metodo OnClickOpcionSeleccionada


    } // fin clase
}