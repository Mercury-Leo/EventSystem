using EventFramework.Events.Abstractions;
using UnityEngine;

namespace EventFramework.Events {
    [CreateAssetMenu(fileName = "Event", menuName = "ChannelEvent")]
    public class Event : EventBase<IDataEvent> { }
}