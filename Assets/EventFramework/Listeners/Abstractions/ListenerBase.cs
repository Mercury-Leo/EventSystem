using UnityEngine;

namespace EventFramework.Listeners.Abstractions {
    public abstract class ListenerBase<TChannel, TInput> : MonoBehaviour, IListener<TInput>
        where TChannel : Observable.Abstractions.ISubscribable<TInput> {
        [field: SerializeField] TChannel _channel;

        protected virtual void OnEnable() {
            SubscribeToChannel();
        }

        protected virtual void OnDisable() {
            UnsubscribeFromChannel();
        }

        public abstract void Raise(TInput data);

        protected virtual void SubscribeToChannel() {
            if (_channel == null) return;
            _channel.Subscribe(this);
        }

        protected virtual void UnsubscribeFromChannel() {
            if (_channel == null) return;
            _channel.Unsubscribe(this);
        }
    }
}