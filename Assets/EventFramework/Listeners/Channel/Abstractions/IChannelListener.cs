using EventFramework.Listeners.Abstractions;

namespace EventFramework.Listeners.Channel.Abstractions {
    public interface IChannelListener<in T> : IEventListener<T> { }
}