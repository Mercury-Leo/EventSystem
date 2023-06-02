using EventFramework.Listeners.Abstractions;

namespace EventFramework.Observable.Abstractions {
    public interface ISubscribable<out T> {
        void Subscribe(IListener<T> listener);
        void Unsubscribe(IListener<T> listener);
    }
}