using System;
using EventFramework.UseCase.Abstractions;

namespace EventFramework.UseCase {
    public class EventUseCase : IEventUseCase {
        public Enum Specification { get; }

        public EventUseCase(Enum specification) {
            Specification = specification;
        }
    }
}