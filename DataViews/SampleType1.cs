using System;
using OSIsoft.Data;

namespace DataViews
{
    public class SampleType1
    {
        [SdsMember(IsKey = true)]
        public DateTime Time { get; set; }

        [SdsMember(Uom = "bar")]
        public double? Pressure { get; set; }
        [SdsMember(Uom = "degree Celsius")]
        public double? Temperature { get; set; }
    }
}
