using System;

namespace EventFramework.UseCase.Abstractions {
    public interface IEventUseCase : IEquatable<IEventUseCase> {
        Enum Specification { get; }
    }
}