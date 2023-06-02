using System;
using EventFramework.Listeners.Abstractions;

namespace EventFramework.Channel.Abstractions {
    public interface IChannel<in TIn, out TOut> : Observable.Abstractions.ISubscribable<TOut>, IListener<TIn> {
        void Announce(TIn data);
    }
}