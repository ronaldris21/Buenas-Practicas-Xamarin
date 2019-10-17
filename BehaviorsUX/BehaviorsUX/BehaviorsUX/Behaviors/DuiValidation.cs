using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Xamarin.Forms;

namespace BehaviorsUX.Behaviors
{
    public class DuiValidation : Behavior<Entry>
    {
        protected override void OnAttachedTo(Entry bindable)
        {
            base.OnAttachedTo(bindable);
            bindable.TextChanged += ValidandoEmail;
        }

        protected override void OnDetachingFrom(Entry bindable)
        {
            base.OnDetachingFrom(bindable);
            bindable.TextChanged -= ValidandoEmail;
        }

        private void ValidandoEmail(object sender, TextChangedEventArgs e)
        {
            Regex reg = new Regex("^[A-Za-z0-9._]{2,30}@[A-Za-z._]{2,20}.[A-Za-z]{2,15}");
            var correo = e.NewTextValue;
            bool result = reg.IsMatch(correo);

            ((Entry)sender).BackgroundColor  = result ? Color.LightCoral : Color.LightGreen;

        }
    }
}
