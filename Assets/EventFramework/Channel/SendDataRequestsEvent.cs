using EventFramework.Arguments.Abstractions;
using EventFramework.Channel.Abstractions;
using EventFramework.Events;
using EventFramework.Events.Abstractions;
using UnityEngine;

namespace EventFramework.Channel {
    [CreateAssetMenu(fileName = "Out Channel", menuName = "Out Channel")]
    public class SendDataRequestsEvent : ChannelBase<IEventArguments, IDataEvent> {
        public override void Announce(IEventArguments data) {
            foreach (var listener in Listeners)
                listener.Raise(new DataEvent(data));
        }
    }
}