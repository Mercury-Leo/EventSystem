using EventFramework.Arguments;
using EventFramework.Arguments.Abstractions;
using EventFramework.Channel;
using UnityEngine;
using UnityEngine.Events;

namespace EventFramework.RequestSender {
	public class Sender : MonoBehaviour {
		[SerializeField] private DataRequestEvent _sender;

		public void SendDataRequest(IEventArguments eventArguments) {
			_sender.Announce(new DataRequestArguments(eventArguments, gameObject));
		}
	}
}