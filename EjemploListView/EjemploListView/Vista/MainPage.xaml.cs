using EjemploListView.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EjemploListView
{
	public partial class MainPage : ContentPage
	{
        private static bool banderaClick;
        public MainPage()
		{
			InitializeComponent();
            Title = "Lista Principal";
            banderaClick = true;
        } // fin constructor


        protected override async void OnAppearing()
        {
            LlenarMenu();
            await Task.Yield();
        }

        public async void LlenarMenu()
        {
            MainPageModel oMainPageModel = new MainPageModel();
            listViewPrincipal.ItemsSource = null;
            listViewPrincipal.ItemsSource = oMainPageModel.ObtenerMenu();
            listViewPrincipal.ItemSelected += OnClickOpcionSeleccionada;
        }

        private async void OnClickOpcionSeleccionada(object sender, SelectedItemChangedEventArgs e)
        {
            if (banderaClick)
            {
                var item = e.SelectedItem as MenuPrincipal;
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

    }
}
