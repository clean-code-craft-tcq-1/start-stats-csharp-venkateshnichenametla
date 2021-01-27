namespace Statistics
{
    public class EmailAlert : IAlerter
    {
        public bool EmailSent { get; set; }

        public EmailAlert()
        {
            EmailSent = false;
        }

        public void RaiseAlert()
        {
            EmailSent = true;
        }
    }
}
