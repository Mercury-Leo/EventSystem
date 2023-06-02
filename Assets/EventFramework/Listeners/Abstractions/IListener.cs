namespace EventFramework.Listeners.Abstractions {
    public interface IListener<in T> {
        void Raise(T data);
    }
}