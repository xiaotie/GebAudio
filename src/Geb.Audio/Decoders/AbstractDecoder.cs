﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Geb.Audio.Decoders
{
    using Geb.Audio.Props;
    using Geb.Audio.Search;
    using Geb.Audio.Results;
    using Geb.Audio.Utils;

    public abstract class AbstractDecoder : IResultProducer, IConfigurable
    {
        protected ISearchManager _searchManager;
        protected List<Action<ResultArgs>> _resultListeners; 

        private Boolean _fireNonFinalResults;

        private String _name;
        protected Logger _logger;

        public AbstractDecoder() { }

        public AbstractDecoder(
            ISearchManager searchManager,
            Boolean fireNonFinalResults,
            Boolean autoAllocate,
            List<Action<ResultArgs>> listeners)
        {
            String name = this.GetType().FullName;
            init(name, Logger.GetLogger(name), searchManager, fireNonFinalResults, autoAllocate, listeners);
        }

        private void init(
            String name,
            Logger logger,
            ISearchManager searchManager,
            Boolean fireNonFinalResults,
            Boolean autoAllocate,
            List<Action<ResultArgs>> listeners)
        {
            this._name = name;
            this._logger = logger;
            this._searchManager = searchManager;
            this._fireNonFinalResults = fireNonFinalResults;
            if (autoAllocate) searchManager.Allocate();
            if (_resultListeners == null) _resultListeners = new List<Action<ResultArgs>>();
            _resultListeners.AddRange(listeners);
        }

        public abstract ResultArgs decode(String referenceText);
        
        /// <summary>
        /// Allocate resources necessary for decoding
        /// </summary>
        public void Allocate()
        {
            _searchManager.Allocate();
        }

        /// <summary>
        /// Deallocate resources
        /// </summary>
        public void Deallocate()
        {
            _searchManager.Deallocate();
        }

        /// <summary>
        /// Adds a result listener to this recognizer. A result listener is called 
        /// whenever a new result is generated by the recognizer. This method can be
        /// called in any state.
        /// </summary>
        /// <param name="resultListener">the listener to add</param>
        public void AddResultListener(Action<ResultArgs> resultListener)
        {
            _resultListeners.Add(resultListener);
        }

        /// <summary>
        /// Removes a previously added result listener. This method can be called in any state.
        /// </summary>
        /// <param name="resultListener">the listener to remove</param>
        public void RemoveResultListener(Action<ResultArgs> resultListener)
        {
            _resultListeners.Remove(resultListener);
        }

        protected void FireResultListeners(ResultArgs result)
        {
            if (_fireNonFinalResults || result.IsFinal) 
            {
                foreach(Action<ResultArgs> action in _resultListeners)
                {
                    action(result);
                }
            }
            else
            {
                _logger.Finer("skipping non-final result " + result);
            }
        }

        public override string ToString()
        {
            return _name;
        }

        public void NewProperties(PropertySheet ps)
        {
            throw new NotImplementedException();
            //Init( ps.getInstanceName(), ps.getLogger(), (SearchManager) ps.getComponent(PROP_SEARCH_MANAGER), ps.getBoolean(FIRE_NON_FINAL_RESULTS), ps.getBoolean(AUTO_ALLOCATE), ps.getComponentList(PROP_RESULT_LISTENERS, ResultListener.class));
        }
    }
}
