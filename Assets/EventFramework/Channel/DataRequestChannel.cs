using EventFramework.Arguments;
using EventFramework.Events.Abstractions;
using UnityEngine;

namespace EventFramework.Channel {
    [CreateAssetMenu(fileName = "Data Request", menuName = "Data Request")]
    public class DataRequestChannel : EventChannelBase<IDataRequestArguments> { }
}