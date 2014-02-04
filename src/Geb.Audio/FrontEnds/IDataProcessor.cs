using System;
using System.Collections.Generic;
using System.Text;

namespace Geb.Audio.FrontEnds
{
    public interface IDataProcessor
    {
        /// <summary>
        /// Initializes this DataProcessor. This is typically called after the 
        /// DataProcessor has been configured.
        /// </summary>
        void Initialize();

        /// <summary>
        /// The processed Data output
        /// </summary>
        IData Data { get; }

        /// <summary>
        /// The predecessor DataProcessor
        /// </summary>
        IDataProcessor Predecessor { get; set; }

    }
}
