using ScriptableEvents.Core.EventsDefenitions.Base;
using UnityEngine;

namespace ScriptableEvents.Core.EventsDefenitions.Implemented
{
    [CreateAssetMenu(fileName = "IntEvent", menuName = "ScriptableEvents/IntEvent", order = 0)]
    public class IntEvent : ScriptableEvent<int> {}
}