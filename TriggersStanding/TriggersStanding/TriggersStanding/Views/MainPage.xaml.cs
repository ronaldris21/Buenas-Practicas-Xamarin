using Acr.UserDialogs;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TriggersStanding.Models;
using TriggersStanding.Views;
using Xamarin.Forms;

namespace TriggersStanding
{
    public partial class MainPage : ContentPage
    {
        public static user ActiveUser;
        public ICommand MyStanding { get { return new RelayCommand(MyStandingsPage); } }
        public MainPage()
        {
            InitializeComponent();
            ActiveUser = new user { Active = true, Img = "myAvatar.png", Name = "Ronald", Username = "Ris", Pass = "2525" };
            BindingContext = this;
            RestartColors();
        }

        private void MyStandingsPage()
        {
            Navigation.PushAsync(new MyStands(ActiveUser));
        }

        private void RestartColors()
        {
            btn1.TextColor = Color.White;
            btn3.TextColor = Color.White;
            btn5.TextColor = Color.White;
            Enviarbtn.TextColor = Color.White;
            
            btn1.BackgroundColor = Color.Blue;
            btn3.BackgroundColor = Color.Blue;
            btn5.BackgroundColor = Color.Blue;
            Enviarbtn.BackgroundColor = Color.Blue;
        }



        private async void Enviarbtn_Clicked(object sender, EventArgs e)
        {
            if (txtEditor.Text == "" || txtEditor.Text == null)
            {
                //UserDialogs.Instance.Toast(new ToastConfig("La descrición no puede quedar vacia").SetPosition(ToastPosition.Top).SetDuration(1500)
                //        .SetBackgroundColor(Color.Red)
                //        .SetMessageTextColor(Color.Black));
            }
            else
            {
                string carac = "";
                if (btn1.BackgroundColor == Color.Blue)
                {
                    carac += btn1.Text + "\n";
                }
                if (btn2.BackgroundColor == Color.Blue)
                {
                    carac += btn2.Text + "\n";
                }
                if (btn3.BackgroundColor == Color.Blue)
                {
                    carac += btn3.Text + "\n";
                }
                if (btn4.BackgroundColor == Color.Blue)
                {
                    carac += btn4.Text + "\n";
                }
                if (btn5.BackgroundColor == Color.Blue)
                {
                    carac += btn5.Text + "\n";
                }
                if (btn6.BackgroundColor == Color.Blue)
                {
                    carac += btn6.Text + "\n";
                }

                String text = "Contenido: " + txtEditor.Text + "\n" +
                    "Fecha cita " + DateFecha.Date + "\n" +
                    "Caracteristicas:\n" + carac;


                if (await DisplayAlert("Confirmación", text, "Ok", "Cancel"))
                {
                    UserDialogs.Instance.Toast(new ToastConfig("Procesando cita").SetPosition(ToastPosition.Top).SetDuration(1000)
                        .SetBackgroundColor(Color.Green)
                        .SetMessageTextColor(Color.Black));

                    ActiveUser.Lcitas.Add(text);
                    txtEditor.Text = "";


                    RestartColors();


                }
                else
                {
                    UserDialogs.Instance.Toast(new ToastConfig("Cita cancelada")
                        .SetPosition(ToastPosition.Top).SetDuration(1000)
                         .SetBackgroundColor(Color.Red)
                         .SetMessageTextColor(Color.Black));
                }
            }
        }
    }
}
