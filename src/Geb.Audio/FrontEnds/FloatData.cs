using System;
using System.Collections.Generic;
using System.Text;

namespace Geb.Audio.FrontEnds
{
    public class FloatData : Data<float>
    {
        public FloatData(float[] values, int sampleRate,
                     long collectTime, long firstSampleNumber):base(values,sampleRate,collectTime,firstSampleNumber)
        {
        }
    }
}
