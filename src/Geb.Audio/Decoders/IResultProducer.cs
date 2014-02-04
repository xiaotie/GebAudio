using System;
using System.Collections.Generic;
using System.Text;

namespace Geb.Audio.Decoders
{
    using Geb.Audio.Props;
    using Geb.Audio.Results;

    public interface IResultProducer : IConfigurable
    {
        void AddResultListener(Action<ResultArgs> resultListener);
        void RemoveResultListener(Action<ResultArgs> resultListener);
    }
}
