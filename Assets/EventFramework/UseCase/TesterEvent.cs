using System;
using EventFramework.Arguments;
using EventFramework.Arguments.Abstractions;
using EventFramework.Channel;
using EventFramework.Dispatch;
using EventFramework.Listeners.Channel;
using EventFramework.UseCase.Abstractions;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

namespace EventFramework.UseCase {
    public class TesterEvent : MonoBehaviour {
        [SerializeField] private UseCaseListener _useCaseListener;

        [SerializeField] private UseCaseBase useCase;

        [SerializeField] private Dispatcher _dispatcher;

        void OnEnable() {
            _useCaseListener.UnityEventResponse.AddListener(Call);
        }

        void OnDisable() {
            _useCaseListener.UnityEventResponse.RemoveListener(Call);
        }

        void Call(object arg0) {
            Debug.LogError($"Got data{arg0}");
        }
        
        [ContextMenu("Send")]
        public void SendEvent() {
            _dispatcher.Raise(new DataRequestArguments(new EventArguments(useCase.UseCase, "tester")));
        }
    }
}