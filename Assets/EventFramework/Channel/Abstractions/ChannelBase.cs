using System;
using EventFramework.Observable.Abstractions;
using UnityEngine;

namespace EventFramework.Channel.Abstractions {
    public abstract class ChannelBase<TIn, TOut> : ObservableBase<TOut>, IChannel<TIn, TOut> {
        public void OnCompleted() {
            
        }

        public void OnError(Exception error) {
            Debug.LogException(error);
        }

        public void OnNext(TIn value) {
            Raise(value);
        }

        public abstract void Raise(TIn data);
    }
}