
namespace BehaviorsUX.Behaviors
{
    using System.Text.RegularExpressions;
    using Xamarin.Forms;
    class NumberValidation : Behavior<Entry>
    {



        protected override void OnAttachedTo(Entry bindable)
        {
            bindable.TextChanged += NumberValidationMethod;
        }

        private void NumberValidationMethod(object sender, TextChangedEventArgs e)
        {
            Regex reg = new Regex("^[0-9]{8}$");
            bool isValid = reg.IsMatch(e.NewTextValue);

            //Casting del objeto sender para poder modificarlo directamente a él!!
            ((Entry)sender).TextColor = isValid ? Color.Green : Color.Red;
            ((Entry)sender).BackgroundColor = isValid ? Color.LightGreen : Color.LightCoral;

        }

        protected override void OnDetachingFrom(Entry bindable)
        {
            bindable.TextChanged -= NumberValidationMethod;
        }
    }
}
