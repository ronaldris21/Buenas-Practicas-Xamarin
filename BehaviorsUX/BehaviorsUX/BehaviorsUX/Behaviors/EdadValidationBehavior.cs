

namespace BehaviorsUX.Behaviors
{
    using System;
    using Xamarin.Forms;
    public class EdadValidationBehavior : Behavior<Entry>
    {



        protected override void OnAttachedTo(Entry bindable)
        {
            bindable.TextChanged += EdadValidationMethod;
            base.OnAttachedTo(bindable);
        }

        private void EdadValidationMethod(object sender, TextChangedEventArgs e)
        {
            try
            {
                int edad = Int32.Parse(e.NewTextValue);
                bool isValid = (edad >=13 && edad <=110);

                //Casting del objeto sender para poder modificarlo directamente a él!!
                ((Entry)sender).TextColor = isValid ? Color.Green : Color.Red;
                ((Entry)sender).BackgroundColor = isValid ? Color.LightGreen : Color.LightCoral;
            }
            catch (Exception)
            {
                ((Entry)sender).TextColor = Color.Red;
                ((Entry)sender).BackgroundColor = Color.LightCoral;
            }
        }

        protected override void OnDetachingFrom(Entry bindable)
        {
            base.OnDetachingFrom(bindable);
        }
    }
}
