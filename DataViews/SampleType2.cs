using System;
using OSIsoft.Data;

namespace DataViews
{
    public class SampleType2
    {
        [SdsMember(IsKey = true)]
        public DateTime Time { get; set; }

        public double Pressure { get; set; }
        public double AmbientTemperature { get; set; }
    }
}
