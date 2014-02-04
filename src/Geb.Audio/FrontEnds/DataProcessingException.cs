using System;
using System.Collections.Generic;
using System.Text;

namespace Geb.Audio.FrontEnds
{
    public class DataProcessingException : Exception
    {
        public DataProcessingException(String msg)
            : base(msg)
        {
        }
    }
}
