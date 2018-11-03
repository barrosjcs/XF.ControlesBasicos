using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XF.ControlesBasicos.DML;

namespace XF.ControlBasic_A1
{
    public partial class MainPage : ContentPage
    {
        Email email;

        public MainPage()
        {
            InitializeComponent();
            if (email == null)
                email = new Email();
        }

        private void btnEnviar_Clicked(object sender, EventArgs e)
        {
            if (email.Ativar && !string.IsNullOrEmpty(email.EmailInformado))
                DisplayAlert("Mensagem", $"E-mail enviado para {email.EmailInformado}", "Ok");
            else
                DisplayAlert("Mensagem", "Envio não autorizado", "Ok");
        }

        private void btnConfig_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ConfigPage() { BindingContext = email });
        }
    }
}
