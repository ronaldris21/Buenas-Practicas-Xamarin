using Xamarin.Forms;

namespace BehaviorsUX.Behaviors
{
    public class PruebaBehavior : Behavior<Entry>
    {
        protected override void OnAttachedTo(Entry bindable)
        {
            bindable.TextChanged += NumberValidation;
            base.OnAttachedTo(bindable);
        }

        private void NumberValidation(object sender, TextChangedEventArgs e)
        {
            int resultado;
            bool isValid=int.TryParse(e.NewTextValue.ToString(), out resultado);
            ((Entry)sender).TextColor = isValid ? Color.Green : Color.Red;

        }

        protected override void OnDetachingFrom(Entry bindable)
        {
            base.OnDetachingFrom(bindable);
        }

    }
}
