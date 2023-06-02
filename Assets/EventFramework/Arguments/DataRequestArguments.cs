using System;
using EventFramework.Arguments.Abstractions;
using UnityEngine;

namespace EventFramework.Arguments {
    public class DataRequestArguments : IDataRequestArguments {
        public Action CallBack { get; }
        public GameObject GameObject { get; }
        public IEventArguments EventArguments { get; }

        public DataRequestArguments(IEventArguments eventArguments, GameObject gameObject = null,
            Action callBack = null) {
            CallBack = callBack;
            GameObject = gameObject;
            EventArguments = eventArguments;
        }
    }
}