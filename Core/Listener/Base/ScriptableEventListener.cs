using System;
using ScriptableEvents.Core.EventsDefenitions.Base;
using UnityEngine;
using UnityEngine.Events;

namespace ScriptableEvents.Core.Listener.Base
{
    public abstract class ScriptableEventListener<T, T1> : MonoBehaviour where T : ScriptableEvent<T1>
    {
        [SerializeField] private T handledEvent;

        [SerializeField] private UnityEvent<T1> inspectorEvent;
        
        public event Action<T1> EventReceived;

        private void OnEnable()
        {
            if (handledEvent == null)
            {
                Debug.LogError("Singal is not assigned");
                
                return;
            }
        
            handledEvent.RaisedEvent += OnSignalInvoked;
        }

        private void OnDisable()
        {
            if (handledEvent == null)
                return;

            handledEvent.RaisedEvent -= OnSignalInvoked;
        }
        
        private void OnSignalInvoked(T1 _argument)
        {
            EventReceived?.Invoke(_argument);
            inspectorEvent.Invoke(_argument);
        }
    }
}