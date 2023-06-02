namespace EventFramework.Events.Abstractions {
    public interface IEvent<T> : Observable.Abstractions.ISubscribable<T> {
        void Raise(T data);
    }
}