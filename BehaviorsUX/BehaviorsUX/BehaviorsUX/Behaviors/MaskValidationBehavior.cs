

namespace BehaviorsUX.Behaviors
{
    using Xamarin.Forms;
    public class MaskValidationBehavior : Behavior<Entry>
    {
        private string _mask = null;
        public string Mask
        {
            get => _mask;
            set
            {
                _mask = value;
            }
        }

        protected override void OnAttachedTo(Entry entry)
        {
            entry.TextChanged += OnNumChanged;
            base.OnAttachedTo(entry);
        }

        private void OnNumChanged(object sender, TextChangedEventArgs args)
        {

            if (!string.IsNullOrWhiteSpace(Mask))
            {
                var entry = sender as Entry; //Asi me aseguro de seguir usando el mismo objeto!
                var text = entry.Text;
                //Agregando el tamaño maximo del texto en caso de que tenga otro distinto al patrom
                if (entry.MaxLength != _mask.Length)
                    entry.MaxLength = _mask.Length;

                //Evaluando para que solo tome cuando escribe y no cuando borra
                if ((args.OldTextValue == null) || (args.OldTextValue.Length <= args.NewTextValue.Length))
                    //Evaluando posiciones de la mascara
                    if (Mask[(text.Length - 1)] != 'X')
                    {
                        text = text.Insert((text.Length - 1), Mask[(text.Length - 1)].ToString());
                    }

                entry.Text = text;

                entry.BackgroundColor = (text.Length == Mask.Length) ? Color.LightGreen : Color.LightCoral;
            }


        }

        protected override void OnDetachingFrom(Entry entry)
        {
            entry.TextChanged -= OnNumChanged;
            base.OnDetachingFrom(entry);
        }

    }
}
