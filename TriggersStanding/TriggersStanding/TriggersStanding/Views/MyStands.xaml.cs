
using TriggersStanding.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TriggersStanding.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MyStands : ContentPage
	{
        public MyStands(user oUser)
        {
            InitializeComponent();
            BindingContext = oUser;
        }

    }
}