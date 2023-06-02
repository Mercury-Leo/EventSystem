using EventFramework.Listeners.Abstractions;
using EventFramework.Observable.Abstractions;
using UnityEngine;
using UnityEngine.Events;

namespace EventFramework.Listeners.Channel.Abstractions {
    public abstract class
        ChannelListenerBase<TInput, TResponse, TChannel, TUnityEvent> : ListenerBase<TChannel, TInput>,
            IChannelListener<TInput> where TChannel : ISubscribable<TInput>
        where TUnityEvent : UnityEvent<TResponse> {
        [SerializeField] TUnityEvent _unityEventResponse;

        public TUnityEvent UnityEventResponse => _unityEventResponse;
    }
}