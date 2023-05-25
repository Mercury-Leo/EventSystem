namespace EventSystem.Listeners.Interfaces {
    public interface IGameEventListener<T> {
        void OnEventRaised(T data);
    }
}