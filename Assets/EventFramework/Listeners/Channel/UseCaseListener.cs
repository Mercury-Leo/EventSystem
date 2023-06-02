using EventFramework.Arguments;
using EventFramework.Arguments.Abstractions;
using EventFramework.Events.Abstractions;
using EventFramework.Listeners.Channel.Abstractions;
using EventFramework.UseCase.Abstractions;
using UnityEngine;
using Event = EventFramework.Events.Event;

namespace EventFramework.Listeners.Channel {
    public class UseCaseListener : ChannelListenerBase<IDataRequestArguments, object, Event, UnityObjectEvent> {
        [SerializeField] UseCaseBase _useCase;

        public override void Raise(IDataRequestArguments data) {
            if (data.EventArguments.UseCase != _useCase.UseCase) return;
            UnityEventResponse?.Invoke(data);
        }
    }
}