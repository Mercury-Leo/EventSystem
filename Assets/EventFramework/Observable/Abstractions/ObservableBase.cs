using System;
using System.Collections.Generic;
using UnityEngine;

namespace EventFramework.Observable.Abstractions {
    public abstract class ObservableBase<T> : ScriptableObject, IObservable<T> {
        protected readonly List<IObserver<T>> Listeners = new();

        public virtual IDisposable Subscribe(IObserver<T> listener) {
            if (!Listeners.Contains(listener))
                Listeners.Add(listener);

            return new Unsubscriber<T>(Listeners, listener);
        }
    }

    class Unsubscriber<T> : IDisposable {
        readonly List<IObserver<T>> _listeners;
        readonly IObserver<T> _listener;

        public Unsubscriber(List<IObserver<T>> listeners, IObserver<T> listener) {
            _listeners = listeners;
            _listener = listener;
        }

        public void Dispose() {
            if (_listener != null && _listeners.Contains(_listener))
                _listeners.Remove(_listener);
        }
    }
}