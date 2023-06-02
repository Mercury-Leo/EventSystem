using EventFramework.Observable.Abstractions;
using UnityEngine;
using UnityEngine.Events;

namespace EventFramework.Listeners.Abstractions {
    public class EventListenerBase<T, TChannel, TUER> : ListenerBase<TChannel, T>, IEventListener<T>
        where TChannel : ISubscribable<T> where TUER : UnityEvent<T> {
        [field: SerializeField] public TUER EventResponse { get; set; }

        public override void Raise(T data) {
            EventResponse?.Invoke(data);
        }
    }
}