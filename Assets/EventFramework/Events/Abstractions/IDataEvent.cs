using EventFramework.Arguments.Abstractions;

namespace EventFramework.Events.Abstractions {
    public interface IDataEvent {
        IEventArguments EventArguments { get; }
    }
}