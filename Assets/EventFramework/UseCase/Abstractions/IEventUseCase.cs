using System;

namespace EventFramework.UseCase.Abstractions {
    public interface IEventUseCase {
        Enum Specification { get; }
    }
}