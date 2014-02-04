using System;
using System.Collections.Generic;
using System.Text;

namespace Geb.Audio.Search
{
    using Geb.Audio.Props;
    using Geb.Audio.Results;

    /// <summary>
    ///  Defines the interface for the SearchManager. The SearchManager's primary role is 
    ///  to execute the search for a given number of frames. The SearchManager will return
    ///  interim results as the recognition proceeds and when recognition completes a final
    ///  result will be returned.
    /// </summary>
    public interface ISearchManager : IConfigurable
    {
        /// <summary>
        /// Allocates the resources necessary for this search. This should be called once 
        /// before an recognitions are performed
        /// </summary>
        void Allocate();

        /// <summary>
        /// Deallocates resources necessary for this search. This should be called once 
        /// after all recognitions are completed at the search manager is no longer needed.
        /// </summary>
        void Deallocate();

        /// <summary>
        /// Prepares the SearchManager for recognition.
        /// </summary>
        void StartRecognition();

        /// <summary>
        /// Performs post-recognition cleanup. This method should be called after 
        /// recognize returns a final result.
        /// </summary>
        void StopRecognition();

        /// <summary>
        /// Performs recognition. Processes no more than the given number of frames 
        /// before returning. This method returns a partial result after nFrames have
        /// been processed, or a final result if recognition completes while processing
        /// frames.  If a final result is returned, the actual number of frames 
        /// processed can be retrieved from the result. This method may block while
        /// waiting for frames to arrive.
        /// </summary>
        /// <param name="nFrames">the maximum number of frames to process. A final 
        /// result may be returned before all nFrames are processed.</param>
        /// <returns>the recognition result, the result may be a partial or a final 
        /// result; or return null if no frames are arrived</returns>
        ResultArgs Recognize(int nFrames);
    }
}
