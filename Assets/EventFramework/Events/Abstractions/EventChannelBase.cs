using System;
using EventFramework.Channel.Abstractions;

namespace EventFramework.Events.Abstractions {
    [Serializable]
    public abstract class EventChannelBase<T> : ChannelBase<T, T>, IEvent<T> {
        public override void Raise(T data) {
            foreach (var listener in Listeners)
                listener?.OnNext(data);
        }
    }
}