using System;
using System.Collections.Generic;
using System.Text;

namespace Geb.Audio.Props
{
    using Geb.Audio.Utils;

    public class ConfigurableAdapter
    {
        private String name;
        protected Logger logger;

        public String Name
        {
            get
            {
                return name != null ? name : this.GetType().Name;
            }
        }

        public ConfigurableAdapter()
        {
        }

        protected void InitLogger()
        {
            this.name = this.GetType().Name;
            Init(name, Logger.GetLogger(name));
        }

        private void Init(String name, Logger logger)
        {
            this.name = name;
            this.logger = logger;
        }

        public void NewProperties(PropertySheet ps)
        {
            throw new NotImplementedException();
            //init( ps.getInstanceName(), ps.getLogger());
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
