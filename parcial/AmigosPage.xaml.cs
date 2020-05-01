using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Net.Http;
namespace parcial
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AmigosPage : ContentPage
    {
        public AmigosPage()
        {
            InitializeComponent();
            GetPerfil();
        }
        private async void GetPerfil()
        {
            HttpClient client = new HttpClient();
            var response = await client.GetStringAsync("http://192.168.100.6:1000/usuarios/amigos");
            var amigos = JsonConvert.DeserializeObject<List<Amigos>>(response);
            mostrar_usuario.ItemsSource = amigos;

        }
    }
}