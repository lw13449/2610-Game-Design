using UnityEngine;
using UnityEngine.Events;

public class BehaviourID : MonoBehaviour
{
    public NameID IDNameObj;
    public UnityEvent EnterEvent, ExitEvent;
    
    public void EnterTrigger()
    {
        EnterEvent.Invoke();
    }

    public void ExitTrigger()
    {
        ExitEvent.Invoke();
    }
    
}
