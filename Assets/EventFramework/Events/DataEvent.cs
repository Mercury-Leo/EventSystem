using EventFramework.Arguments.Abstractions;
using EventFramework.Events.Abstractions;

namespace EventFramework.Events {
    public class DataEvent : IDataEvent {
        public IEventArguments EventArguments { get; }

        public DataEvent(IEventArguments eventArguments) {
            EventArguments = eventArguments;
        }
    }
}