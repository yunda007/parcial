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
    public partial class PerfilPage : ContentPage
    {
        public PerfilPage()
        {
            InitializeComponent();
            btnmostrar.Clicked += Btnmostrar_Clicked;
            GetPerfil();
        }

        private void Btnmostrar_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new AmigosPage());
        }

        private async void GetPerfil()
        {
            HttpClient client = new HttpClient();
            var response = await client.GetStringAsync("http://192.168.100.6:1000/usuarios/perfil");
            var usuarios = JsonConvert.DeserializeObject<List<Perfil>>(response);
            mostrar_usuario.ItemsSource = usuarios;

        }
       
    }
}