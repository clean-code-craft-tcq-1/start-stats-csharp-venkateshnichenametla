namespace Statistics
{
    public class LEDAlert : IAlerter
    {


        public bool LedGlows { get; set; }

        public LEDAlert()
        {
            LedGlows = false;
        }

        public void RaiseAlert()
        {
            LedGlows = true;
        }
    }
}
