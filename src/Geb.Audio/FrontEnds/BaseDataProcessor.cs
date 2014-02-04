using System;
using System.Collections.Generic;
using System.Text;

namespace Geb.Audio.FrontEnds
{
    using Geb.Audio.Props;
    using Geb.Audio.Utils;

    public abstract class BaseDataProcessor : ConfigurableAdapter, IDataProcessor
    {
        private Timer timer;
        public IData Data { get; protected set; }
        public IDataProcessor Predecessor { get; set; }

        public BaseDataProcessor() { }

        public virtual void Initialize() {}

        public Timer getTimer() 
        {
            lock(this)
            {
                if(timer == null)
                {
                    this.timer = TimerPool.GetTimer(this, Utilities.GetReadable(Name));
                }
            }
            return timer;
        }
    }
}
