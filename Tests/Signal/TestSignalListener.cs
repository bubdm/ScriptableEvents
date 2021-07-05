using ScriptableEvents.Core.Listener.Implemented;
using UnityEngine;

namespace ScriptableEvents.Tests.Signal
{
    [DisallowMultipleComponent]
    [RequireComponent(typeof(SignalListener))]
    public class TestSignalListener : MonoBehaviour
    {
        private SignalListener listener;

        private void Awake()
        {
            listener = GetComponent<SignalListener>();
        }

        private void OnEnable()
        {
            listener.EventReceived += EventReceiver;
        }

        private void OnDisable()
        {
            listener.EventReceived -= EventReceiver;
        }
        
        public void UIReceiver()
        {
            Debug.Log("UI event received");
        }

        private void EventReceiver()
        {
            Debug.Log("C# event received");
        }
    }
}