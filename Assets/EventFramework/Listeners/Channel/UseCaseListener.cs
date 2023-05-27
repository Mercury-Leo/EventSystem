using EventFramework.Events;
using EventFramework.Events.Abstractions;
using EventFramework.Listeners.Channel.Abstractions;
using EventFramework.UseCase.Abstractions;
using UnityEngine;

namespace EventFramework.Listeners.Channel {
    public class UseCaseListener : ChannelListenerBase<IDataEvent, object, EventChannel, UnityObjectEvent> {
        [SerializeField] UseCaseBase _useCase;

        public override void OnNext(IDataEvent data) {
            if (data.UseCase != _useCase.UseCase)
                return;

            _unityEventResponse?.Invoke(data);
        }
    }
}