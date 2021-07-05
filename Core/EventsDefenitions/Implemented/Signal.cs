using System;
using UnityEngine;

namespace ScriptableEvents.Core.EventsDefenitions.Implemented
{
    [CreateAssetMenu(fileName = "Signal", menuName = "ScriptableEvents/Signal", order = 0)]
    public class Signal : ScriptableObject
    {
        public event Action RaisedSingal;

        public void RaiseSignal()
        {
            RaisedSingal?.Invoke();
        }
    }
}