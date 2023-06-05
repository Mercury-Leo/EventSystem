using System;
using EventFramework.UseCase.Abstractions;

namespace EventFramework.Arguments.Abstractions {
    public class EventArguments : EventArgs, IEventArguments {
        public string ID { get; }
        public IEventUseCase UseCase { get; }
        public object Data { get; }

        public EventArguments(string id, IEventUseCase useCase, object data = null) {
            ID = id;
            Data = data;
            UseCase = useCase;
        }

        public EventArguments(IEventUseCase useCase, object data) {
            ID = "-1";
            UseCase = useCase;
            Data = data;
        }
    }
}