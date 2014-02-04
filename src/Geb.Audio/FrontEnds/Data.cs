using System;
using System.Collections.Generic;
using System.Text;

namespace Geb.Audio.FrontEnds
{
    public class Data<T> : IData, ICloneable
    {
        private readonly T[] values;
        private readonly int sampleRate;
        private readonly long firstSampleNumber;
        private readonly long collectTime;

        /// <summary>
        /// the data values
        /// </summary>
        public T[] Values { get { return values; } }

        /// <summary>
        /// the sample rate of the data
        /// </summary>
        public int SampleRate { get { return sampleRate; } }

        /// <summary>
        /// the time at which this data is collected
        /// </summary>
        public long CollectTime { get { return collectTime; } }

        /// <summary>
        /// the position of the first sample in the original data
        /// </summary>
        public long FirstSampleNumber { get { return firstSampleNumber; } }

        public Data()
        { }

        public Data(T[] values, int sampleRate,
                     long collectTime, long firstSampleNumber)
        {
            this.values = values;
            this.sampleRate = sampleRate;
            this.collectTime = collectTime;
            this.firstSampleNumber = firstSampleNumber;
        }

        public object Clone()
        {
            throw new NotImplementedException();
        }
    }
}
