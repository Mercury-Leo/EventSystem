using EventFramework.Arguments.Abstractions;
using EventFramework.Events.Abstractions;
using EventFramework.UseCase.Abstractions;

namespace EventFramework.Events {
    public class DataEvent : IDataEvent {
        public string ID { get; }
        public object Data { get; }
        public IEventUseCase UseCase { get; }

        public DataEvent(string id, object data, IEventUseCase useCase) {
            ID = id;
            Data = data;
            UseCase = useCase;
        }

        public DataEvent(IEventArguments eventArguments) {
            ID = eventArguments.ID;
            Data = eventArguments.Data;
            UseCase = eventArguments.UseCase;
        }
    }
}