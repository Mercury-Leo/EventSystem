using System;

namespace EventFramework.Listeners.Abstractions {
    public interface IEventListener<in T> : IObserver<T> { }
}