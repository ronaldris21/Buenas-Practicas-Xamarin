

namespace TriggersStanding.TriggersFolder
{
    using Xamarin.Forms;
    public class BtnClickedTrigger : TriggerAction<Button>
    {
        protected override void Invoke(Button sender)
        {
            sender.BackgroundColor = Color.Blue;
            sender.TextColor = Color.White;
        }
    }
}
