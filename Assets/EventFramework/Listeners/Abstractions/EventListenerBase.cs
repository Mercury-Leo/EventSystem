using System;
using UnityEngine;

namespace EventFramework.Listeners.Abstractions {
    public abstract class EventListenerBase<TChannel, TInput> : MonoBehaviour, IEventListener<TInput>
        where TChannel : IObservable<TInput> {
        [field: SerializeField] TChannel _channel;

        IDisposable _unsubscribe;

        void OnEnable() {
            if (_channel == null)
                return;

            _unsubscribe = _channel.Subscribe(this);
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

        public abstract void OnNext(TInput value);
    }
}