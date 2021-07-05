using UnityEngine;

namespace ScriptableEvents.Tests.Signal
{
    [DisallowMultipleComponent]
    public class TestSignalInvoker : MonoBehaviour
    {
        [SerializeField] private Core.EventsDefenitions.Implemented.Signal signal;

        private void Awake()
        {
            Invoke(nameof(InvokeSignal), 0.1f);
        }

        private void InvokeSignal()
        {
            signal.RaiseSignal();
        }
    }
}