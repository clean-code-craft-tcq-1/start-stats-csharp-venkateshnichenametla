using System;
using System.Collections.Generic;
using System.Linq;

namespace Statistics
{
    public class StatsComputer
    {
        public Stats CalculateStatistics(List<float> numbers) 
        {
            //Implement statistics here
            Stats stats = new Stats();
            if(numbers.Count > 0)
            {
                stats.average = numbers.Average();
                stats.min = numbers.Min();
                stats.max = numbers.Max();
            }
            else
            {
                stats.average = float.NaN;
                stats.max = float.NaN;
                stats.min = float.NaN;
            }
            return stats;
        }
    }

    public class Stats
    {
        public double average { get; set; }

        public double min { get; set; }

        public double max { get; set; }
    }
}
