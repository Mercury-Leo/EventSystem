using System;
using EventFramework.Listeners.Abstractions;
using EventFramework.Observable.Abstractions;

namespace EventFramework.Channel.Abstractions {
    public interface IChannel<in TIn, out TOut> : ISubscribable<TOut>, IListener<TIn> {
        void Announce(TIn data);
    }
}