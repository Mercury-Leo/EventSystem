using System;
using EventFramework.UseCase.Abstractions;
using UnityEngine;

namespace EventFramework.UseCase {
    public class EventUseCase : IEventUseCase {
        public Enum Specification { get; }
        public Type UseCaseType { get; }

        public EventUseCase(Enum specification) {
            Specification = specification;
            UseCaseType = Specification.GetType();
        }

        public EventUseCase(string specification, string type) {
            UseCaseType = Type.GetType(type);
            if (UseCaseType == null) {
                Debug.LogError($"Gave in wrong Enum type: {type}");
                return;
            }

            Specification = Enum.Parse(UseCaseType, specification) as Enum;
        }

        public bool Equals(IEventUseCase other) {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;

            return GetType() == other.GetType() && Equals(Specification, other.Specification);
        }
    }
}