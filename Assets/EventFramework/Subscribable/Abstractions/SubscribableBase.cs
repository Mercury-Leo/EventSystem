using System.Collections.Generic;
using EventFramework.Listeners.Abstractions;
using UnityEngine;

namespace EventFramework.Observable.Abstractions {
    public abstract class SubscribableBase<T> : ScriptableObject, ISubscribable<T> {
        protected readonly List<IListener<T>> Listeners = new();

        public void Subscribe(IListener<T> listener) {
            if (!Listeners.Contains(listener))
                Listeners.Add(listener);
        }

        public void Unsubscribe(IListener<T> listener) {
            if (!Listeners.Contains(listener))
                Listeners.Remove(listener);
        }
    }
}