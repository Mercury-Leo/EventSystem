using System;
using UnityEngine;

namespace EventFramework.Listeners.Abstractions {
    public abstract class EventListenerBase<TChannel, TInput> : MonoBehaviour, IEventListener<TChannel>
        where TChannel : IObservable<TInput> {
        [field: SerializeField] TChannel _channel;

        IDisposable _unsubscribe;

        void OnEnable() {
            if (_channel == null)
                return;

            _unsubscribe = _channel.Subscribe((IObserver<TInput>)this);
        }

        void OnDisable() {
            if (_channel == null)
                return;

            _unsubscribe.Dispose();
        }

        public virtual void OnCompleted() {
            OnDisable();
        }

        public virtual void OnError(Exception error) {
            Debug.LogException(error);
        }

        public abstract void OnNext(TChannel data);
    }
}