using EventFramework.Arguments.Abstractions;
using EventFramework.Channel.Abstractions;
using EventFramework.Events.Abstractions;
using UnityEngine;

namespace EventFramework.Channel {
    [CreateAssetMenu(fileName = "Out Channel", menuName = "Out Channel")]
    public class OutDataChannel : ChannelBase<IDataEvent, IEventArguments> {
        public override void Announce(IDataEvent data) {
            foreach (var listener in Listeners)
                listener.Raise(new EventArguments(data));
        }
    }
}