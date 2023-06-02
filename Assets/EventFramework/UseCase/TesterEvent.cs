using EventFramework.Arguments;
using EventFramework.Arguments.Abstractions;
using EventFramework.Channel;
using EventFramework.Events;
using EventFramework.Listeners.Channel;
using EventFramework.RequestSender;
using EventFramework.UseCase.Abstractions;
using UnityEngine;

namespace EventFramework.UseCase {
    public class TesterEvent : MonoBehaviour {
        [SerializeField] private UseCaseListener _useCaseListener;

        [SerializeField] private Sender _sender;

        [SerializeField] private UseCaseBase _useCase;


        void OnEnable() {
            _useCaseListener.UnityEventResponse.AddListener(Call);
        }

        void OnDisable() {
            _useCaseListener.UnityEventResponse.RemoveListener(Call);
        }

        void Call(object arg0) {
            if (arg0 is not DataEvent data) {
                Debug.LogError("Wrong data");
                return;
            }

            Debug.Log($"Got data{data.EventArguments.Data}");
        }

        [ContextMenu("Send")]
        public void SendEvent() {
            _sender.SendDataRequest(new EventArguments(_useCase.UseCase, "got there"));
        }
    }
}