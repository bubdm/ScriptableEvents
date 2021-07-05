using ScriptableEvents.Core.Listener.Implemented;
using UnityEngine;

namespace ScriptableEvents.Tests.BoolEvent
{
    [DisallowMultipleComponent]
    [RequireComponent(typeof(BoolEventListener))]
    public class TestBoolEventListener : MonoBehaviour
    {
        private BoolEventListener listener;

        private void Awake()
        {
            listener = GetComponent<BoolEventListener>();
        }

        private void OnEnable()
        {
            listener.EventReceived += EventReceivedReceiver;
        }

        private void OnDisable()
        {
            listener.EventReceived -= EventReceivedReceiver;
        }
        
        public void UIReceiver(bool _value)
        {
            Debug.Log("UI event received " + _value);
        }

        private void EventReceivedReceiver(bool _value)
        {
            Debug.Log("C# event received " + _value);
        }
    }
}