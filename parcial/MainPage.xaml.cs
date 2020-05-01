using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace parcial
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            btnver.Clicked += Btnver_Clicked;
        }
        private void Btnver_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new PerfilPage());
        }
    }
}
