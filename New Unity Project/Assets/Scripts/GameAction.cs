using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class GameAction : ScriptableObject
{
    public UnityAction actionEvent;
    public object action;

    public void Raise()
    {
        actionEvent.Invoke();
    }
}