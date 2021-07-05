# ScriptableEvents
 Simple events system handled with scriptable objects.
 
 Using scriptable objects is a well known tip to decreace code coupling. This implementation have a minimum of boilerplate code and support C# events and UnityEvents in inspector.
 
 Quick guide:
 
 1. Register new event type.
 Project have already implemented a few base event types(empty, bool, int...).
 To register new event type - create new C# class and inherit it from ```csharp ScriptableEvent<T> ```
 
```csharp
   using ScriptableEvents.Core.EventsDefenitions.Base;
   using UnityEngine;

   // Example for bool event.
   [CreateAssetMenu(fileName = "BoolEvent", menuName = "ScriptableEvents/BoolEvent", order = 0)]
   public class BoolEvent : ScriptableEvent<bool> {}
```
 You can cast it to any data structure.
 
 2. Create event listener for your event.
 Listeners are required to receive events and raise callbacks, on it.
 Abstract class ScriptableEventListeners contains two events: C# event and UnityEvent for inspector usage.
 Default listener subscribe and unsubcribe on event on OnEnable/OnDisable.
```csharp
   [SerializeField] private UnityEvent<T1> inspectorEvent;
        
   public event Action<T1> EventReceived;
```
 To create new listener create new class and inherit it from ```csharp ScriptableEventListener<T, T1>``` where T is your event type you created before, and T1 is data structure that you use in your event.
```csharp
   // Example for bool event.
   public class BoolEventListener : ScriptableEventListener<BoolEvent, bool> {}
```

 3. Create instance of event.
 Then create an instance of event in inspector and assign it to listener.
