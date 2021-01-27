using System.Collections.Generic;
using System.Linq;

namespace Statistics
{
    public class StatsAlerter
    {
        public double MaxThreshhold { get; set; }

        public IAlerter[] Alerters { get; set; }

        public StatsAlerter(double maxThreshhold, IAlerter[] alerters)
        {
            MaxThreshhold = maxThreshhold;
            Alerters = alerters;

        }

        public void checkAndAlert(List<float> lstSensorValues)
        {
            double maxValue =  lstSensorValues.Max();
            if(maxValue > MaxThreshhold)
            {
                foreach (IAlerter item in Alerters)
                {
                    item.RaiseAlert();
                }
            }
        }
    }
}
