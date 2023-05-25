using System.Collections.Generic;
using EventSystem.Listeners.Interfaces;
using UnityEngine;

namespace EventSystem.Events.Interfaces {
    public abstract class GameEventBase<T> : ScriptableObject {
        readonly List<IGameEventListener<T>> _listeners = new();

        public void Raise(T data) {
            for (var i = _listeners.Count - 1; i >= 0; i--) {
                _listeners[i].OnEventRaised(data);
            }
        }

        public void RegisterListener(IGameEventListener<T> listener) {
            if (!_listeners.Contains(listener))
                _listeners.Add(listener);
        }

        public void UnregisterListener(IGameEventListener<T> listener) {
            if (_listeners.Contains(listener))
                _listeners.Remove(listener);
        }
    }
}