using System;
using System.Collections.Generic;
using System.Text;

namespace Geb.Audio.FrontEnds.EndPoint
{
    public abstract class AbstractVoiceActivityDetector : BaseDataProcessor
    {
        /// <summary>
        /// Returns the state of speech detected.
        /// </summary>
        /// <returns>if last processed data object was classified as speech</returns>
        public abstract Boolean isSpeech();
    }
}
