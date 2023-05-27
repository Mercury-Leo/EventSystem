using UnityEngine;

namespace EventFramework.UseCase.Abstractions {
    public abstract class UseCaseBase : ScriptableObject {
        public abstract IEventUseCase UseCase { get; }
    }
}