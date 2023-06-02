using EventFramework.Arguments;
using EventFramework.Arguments.Abstractions;
using EventFramework.Events.Abstractions;
using UnityEngine;

namespace EventFramework.Channel {
    [CreateAssetMenu(fileName = "Data Request", menuName = "Data Request")]
    public class DataRequest : EventBase<IDataRequestArguments> { }
}