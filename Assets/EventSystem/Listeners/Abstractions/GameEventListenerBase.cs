using EventSystem.Events.Interfaces;
using EventSystem.Listeners.Interfaces;
using UnityEngine;
using UnityEngine.Events;

namespace EventSystem.Listeners.Abstractions {
    public abstract class GameEventListenerBase<T, E, UER> : MonoBehaviour, IGameEventListener<T>
        where E : GameEventBase<T> where UER : UnityEvent<T> {
        [field: SerializeField] E gameEvent;

        [SerializeField] UER eventResponse;

        void OnEnable() {
            if (gameEvent == null)
                return;

            gameEvent.RegisterListener(this);
        }

        void OnDisable() {
            if (gameEvent == null)
                return;

            gameEvent.UnregisterListener(this);
        }

        public void OnEventRaised(T data) {
            eventResponse?.Invoke(data);
        }
    }
}