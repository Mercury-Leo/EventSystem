using System;
using EventFramework.UseCase.Abstractions;
using UnityEngine;

namespace EventFramework.UseCase {
    [CreateAssetMenu(fileName = "Test", menuName = "Test usecase")]
    public class Test : UseCaseBase {
        [SerializeField] public Tester _type;

        public override IEventUseCase UseCase => new EventUseCase(_type);
    }

    public enum Tester {
        Hey,
    }
}