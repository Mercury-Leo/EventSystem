namespace EventFramework.Listeners.Abstractions {
    public interface IEventListener<in T> : IListener<T> { }
}