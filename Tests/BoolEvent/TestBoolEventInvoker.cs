using UnityEngine;

namespace ScriptableEvents.Tests.BoolEvent
{
    [DisallowMultipleComponent]
    public class TestBoolEventInvoker : MonoBehaviour
    {
        [SerializeField] private Core.EventsDefenitions.Implemented.BoolEvent boolEvent;

        private void Awake()
        {
            Invoke(nameof(InvokeBoolEvent), 0.1f);
        }

        private void InvokeBoolEvent()
        {
            boolEvent.RaiseSignal(true);
        }
    }
}