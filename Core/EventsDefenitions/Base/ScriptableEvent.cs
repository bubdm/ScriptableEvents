using System;
using UnityEngine;

namespace ScriptableEvents.Core.EventsDefenitions.Base
{
    public class ScriptableEvent<T> : ScriptableObject
    {   
        [SerializeField] [TextArea] private string description;
        
        public event Action<T> RaisedEvent;
        
        public void RaiseEvent(T _argument)
        {
            RaisedEvent?.Invoke(_argument);
        }
    }
}