using System;
using System.Collections.Generic;
using System.Text;

namespace Geb.Audio.FrontEnds
{
    public class Signal : IData
    {
        private readonly long time;
        private Dictionary<String, Object> props;

        public long Time
        {
            get
            {
                return time;
            }
        }

        public Dictionary<String, Object> Props
        {
            get
            {
                lock (this)
                {
                    if (props == null)
                        props = new Dictionary<String, Object>();
                }

                return props;
            }
        }

        protected Signal(long time)
        {
            this.time = time;
        }
    }
}
