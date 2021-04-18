using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace BurguerProject
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnSalvar(object sender, EventArgs e)
        {
            Preferences.Set("username", CoSeUs.Text);
            var teste = Preferences.Get("username", "default_value");
            
            if (teste == "Marlon")
            {
                var teste2 = "asdas";
            }
        }

        private void BtnRetrieveClicked(object sender, EventArgs e)
        {
            var retorno = Preferences.Get("username", "");
            LabRet.Text = retorno;
        }
    }
}
