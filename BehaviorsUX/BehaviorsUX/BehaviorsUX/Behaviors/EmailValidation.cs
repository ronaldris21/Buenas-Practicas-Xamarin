

namespace BehaviorsUX.Behaviors
{
    using System.Text.RegularExpressions;
    using Xamarin.Forms;
    public class EmailValidation : Behavior<Entry>
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

        bool IsValidEmail(string email)
        {
            try
            {
                var mail = new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void ValidandoEmail(object sender, TextChangedEventArgs e)
        {
            Regex reg = new Regex(@"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.(com|org|sv|edu|es)(\.(com|org|sv|edu|es))?$");
            var correo = e.NewTextValue;
            bool IsValid = reg.IsMatch(correo);

            ((Entry)sender).BackgroundColor = IsValid ? Color.LightGreen : Color.LightCoral;

        }
    }
}
