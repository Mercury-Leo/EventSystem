using EventFramework.Channel;
using EventFramework.Events.Abstractions;
using EventFramework.Listeners.Channel.Abstractions;
using EventFramework.UseCase.Abstractions;
using UnityEngine;

namespace EventFramework.Listeners.Channel {
    public class UseCaseListener : ChannelListenerBase<IDataEvent, object, SendDataRequestsEvent, UnityObjectEvent> {
        [SerializeField] UseCaseBase _useCase;
        
        public override void Raise(IDataEvent data) {
            if (!Equals(data.EventArguments.UseCase.Specification, _useCase.UseCase.Specification)) return;
            UnityEventResponse?.Invoke(data);
        }
    }
}