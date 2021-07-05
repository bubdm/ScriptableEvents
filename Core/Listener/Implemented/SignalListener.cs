using System;
using ScriptableEvents.Core.EventsDefenitions.Implemented;
using UnityEngine;
using UnityEngine.Events;

namespace ScriptableEvents.Core.Listener.Implemented
{
    public class SignalListener : MonoBehaviour
    {
        [SerializeField] private Signal signal;

        [SerializeField] private UnityEvent inspectorEvent;
        
        public event Action EventReceived;

        private void OnEnable()
        {
            if (signal == null)
            {
                Debug.LogError("Singal is not assigned");
                
                return;
            }

            signal.RaisedSingal += OnSignalInvoked;
        }

        private void OnDisable()
        {
            if (signal == null)
                return;

            signal.RaisedSingal -= OnSignalInvoked;
        }
        
        private void OnSignalInvoked()
        {
            EventReceived?.Invoke();
            inspectorEvent.Invoke();
        }
    }
}