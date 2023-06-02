using System;
using EventFramework.Channel.Abstractions;

namespace EventFramework.Events.Abstractions {
    [Serializable]
    public abstract class EventBase<T> : ChannelBase<T, T>, IEvent<T> {
        public override void Announce(T data) {
            foreach (var listener in Listeners)
                listener?.Raise(data);
        }
    }
}