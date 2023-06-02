using EventFramework.Observable.Abstractions;

namespace EventFramework.Channel.Abstractions {
    public abstract class ChannelBase<TIn, TOut> : SubscribableBase<TOut>, IChannel<TIn, TOut> {
        public virtual void Raise(TIn data) {
            Announce(data);
        }

        public abstract void Announce(TIn data);
    }
}