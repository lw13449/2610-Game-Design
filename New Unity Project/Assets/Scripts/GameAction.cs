using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class GameAction : ScriptableObject
{
    public UnityAction actionEvent;

    public void Raise()
    {
        actionEvent.Invoke();
    }
}