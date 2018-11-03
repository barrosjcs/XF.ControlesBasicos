using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace XF.ControlesBasicos.DML
{
    public class Email : INotifyPropertyChanged
    {
        private bool ativar;
        public bool Ativar
        {
            get
            {
                return ativar;
            }
            set
            {
                ativar = value;

                if (!ativar)
                    EmailInformado = string.Empty;
            }
        }
        private string emailInformado;
        public string EmailInformado
        {
            get
            {
                return emailInformado;
            }
            set
            {
                emailInformado = value;
                EventPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void EventPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
