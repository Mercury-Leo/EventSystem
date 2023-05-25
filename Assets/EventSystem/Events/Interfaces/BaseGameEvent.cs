using System.Collections.Generic;
using UnityEngine;

namespace EventSystem.Events.Interfaces {
    public abstract class classBaseGameEvent<T> : ScriptableObject {
        readonly List<GameEventListener<T>> _listeners = new();
    }
}