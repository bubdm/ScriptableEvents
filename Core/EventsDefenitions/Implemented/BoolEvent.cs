using ScriptableEvents.Core.EventsDefenitions.Base;
using UnityEngine;

namespace ScriptableEvents.Core.EventsDefenitions.Implemented
{
    [CreateAssetMenu(fileName = "BoolEvent", menuName = "ScriptableEvents/BoolEvent", order = 0)]
    public class BoolEvent : ScriptableEvent<bool> {}
}