using EventFramework.Arguments;
using EventFramework.Arguments.Abstractions;
using EventFramework.Channel.Abstractions;
using EventFramework.Events;
using EventFramework.Events.Abstractions;
using EventFramework.Listeners.Abstractions;
using UnityEngine;

namespace EventFramework.Dispatch {
    [CreateAssetMenu(fileName = "new EventDispatcher", menuName = "Event Dispatcher")]
    public class Dispatcher : ScriptableObject, IListener<IDataRequestArguments> {
        [SerializeField] EventBase<IDataRequestArguments> _dataRequest;

        [SerializeField] ChannelBase<IDataEvent, IEventArguments> _outChannel;

        void OnEnable() {
            _dataRequest.Subscribe(this);
        }

        void OnDisable() {
            _dataRequest.Unsubscribe(this);
        }

        public void Raise(IDataRequestArguments data) {
            var request = new DataEvent(data.EventArguments);

            _outChannel.Raise(request);
        }
    }
}