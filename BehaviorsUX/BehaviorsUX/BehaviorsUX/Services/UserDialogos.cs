using Acr.UserDialogs;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace BehaviorsUX.Services
{
    public class UserDialogos
    {

        public void ToastMensajeExito(string mensaje, int miliseconds)
        {
            UserDialogs.Instance.Toast(new ToastConfig(mensaje).SetPosition(ToastPosition.Top).SetDuration(miliseconds)
                        .SetBackgroundColor(Color.Green)
                        .SetMessageTextColor(Color.Black));
        }

        public void ToastMensajeError(string mensaje,int miliseconds)
        {
            UserDialogs.Instance.Toast(new ToastConfig(mensaje).SetPosition(ToastPosition.Top).SetDuration(miliseconds)
                        .SetBackgroundColor(Color.LightCoral)
                        .SetMessageTextColor(Color.Black));
        }
    }
}
