using System;

namespace EventFramework.Events.Abstractions {
    public interface IEvent<T> : IObservable<T> {
        void Raise(T data);
    }
}