using System;
using System.Collections.Generic;
using System.Text;

namespace Geb.Audio.FrontEnds
{
    public class DoubleData : Data<double>
    {
        public DoubleData(double[] values, int sampleRate,
                     long collectTime, long firstSampleNumber):base(values,sampleRate,collectTime,firstSampleNumber)
        {
        }
    }
}
