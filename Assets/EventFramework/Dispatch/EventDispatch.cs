using EventFramework.Arguments.Abstractions;
using EventFramework.Channel;
using EventFramework.Listeners.Abstractions;
using UnityEngine;

namespace EventFramework.Dispatch {
    [CreateAssetMenu(fileName = "new EventDispatch", menuName = "Event Dispatch")]
    public class EventDispatch : ScriptableObject, IListener<IDataRequestArguments> {
        [Header("In")] [SerializeField] DataRequestEvent _dataRequest;

        [Header("Out")] [SerializeField] SendDataRequestsEvent _outChannel;

        void OnEnable() {
            _dataRequest.Subscribe(this);
        }

        void OnDisable() {
            _dataRequest.Unsubscribe(this);
        }

        public void Raise(IDataRequestArguments data) {
            _outChannel.Raise(data.EventArguments);
        }
    }
}