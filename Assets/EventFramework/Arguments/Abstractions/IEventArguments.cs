using EventFramework.UseCase.Abstractions;
using JetBrains.Annotations;

namespace EventFramework.Arguments.Abstractions {
    public interface IEventArguments : IUseCaseData {
        [CanBeNull] string ID { get; }
    }
}