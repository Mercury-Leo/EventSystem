using System;
using EventFramework.Listeners.Abstractions;

namespace EventFramework.Channel.Abstractions {
    public interface IChannel<in TIn, out TOut> : IObservable<TOut>, IEventListener<TIn> {
        void Raise(TIn data);
    }
}