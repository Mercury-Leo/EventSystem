using EventFramework.UseCase.Abstractions;
using JetBrains.Annotations;

namespace EventFramework.Arguments.Abstractions {
    public interface IEventArguments {
        [CanBeNull] string ID { get; }

        object Data { get; }

        IEventUseCase UseCase { get; }
    }
}