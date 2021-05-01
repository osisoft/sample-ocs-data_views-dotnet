using System;
using OSIsoft.Data;

namespace DataViews
{
    public class SampleType1
    {
        #region step2
        [SdsMember(IsKey = true)]
        public DateTime Time { get; set; }

        public double Pressure { get; set; }
        public double Temperature { get; set; }
        #endregion // step2
    }
}
