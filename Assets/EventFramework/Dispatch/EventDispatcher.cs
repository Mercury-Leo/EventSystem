using System;
using EventFramework.Arguments;
using EventFramework.Arguments.Abstractions;
using EventFramework.Channel.Abstractions;
using EventFramework.Events;
using EventFramework.Events.Abstractions;
using EventFramework.Listeners.Abstractions;
using UnityEngine;

namespace EventFramework.Dispatch {
    [CreateAssetMenu(fileName = "new EventDispatcher", menuName = "Event Dispatcher")]
    public class EventDispatcher : ScriptableObject, IEventListener<IDataRequestArguments> {
        [SerializeField] EventChannelBase<IDataRequestArguments> _dataRequestChannel;

        [SerializeField] ChannelBase<IDataEvent, IEventArguments> _outChannel;

        IDisposable _unsubscriber;

        void OnEnable() {
            _unsubscriber = _dataRequestChannel.Subscribe(this);
        }

        void OnDisable() {
            _unsubscriber?.Dispose();
        }

        public void OnCompleted() {
            OnDisable();
        }

        public void OnError(Exception error) {
            Debug.LogException(error);
        }

        public void OnNext(IDataRequestArguments value) {
            var request = new DataEvent(value.EventArguments);

            _outChannel.OnNext(request);
        }
    }
}