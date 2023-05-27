using System;
using EventFramework.Listeners.Abstractions;
using UnityEngine;
using UnityEngine.Events;

namespace EventFramework.Listeners.Channel.Abstractions {
    public abstract class
        ChannelListenerBase<TInput, TResponse, TChannel, TUnityEvent> : EventListenerBase<TChannel, TInput>,
            IChannelListener<TInput>
        where TChannel : IObservable<TInput> where TUnityEvent : UnityEvent<TResponse> {
        [SerializeField] protected TUnityEvent _unityEventResponse;
        public abstract void OnNext(TInput value);
    }
}