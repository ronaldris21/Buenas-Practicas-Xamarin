

namespace BehaviorsUX.Behaviors
{
    using System.Text.RegularExpressions;
    using Xamarin.Forms;
    public class TextValidation : Behavior<Entry>
    {
        private void TextValidationMethod(object sender, TextChangedEventArgs e)
        {

            Regex reg = new Regex("^[A-Za-z áéíóúÁÉÍÓÚ]{5,25}$");
            bool isValid = reg.IsMatch(e.NewTextValue);

            //Casting del objeto sender para poder modificarlo directamente a él!!

            ((Entry)sender).TextColor = isValid ? Color.DarkGreen : Color.Red;
            ((Entry)sender).BackgroundColor = isValid ? Color.LightGreen : Color.LightCoral;
        }

        protected override void OnAttachedTo(Entry bindable)
        {
            bindable.TextChanged += TextValidationMethod;
            base.OnAttachedTo(bindable);
        }

        protected override void OnDetachingFrom(Entry bindable)
        {
            base.OnDetachingFrom(bindable);
            bindable.TextChanged -= TextValidationMethod;
        }
    }
}
