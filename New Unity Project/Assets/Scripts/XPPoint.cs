using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class XPPoint : ScriptableObject
{
    public UnityAction<int> upgradeAction;
    
    public int value = 10;

    public void Upgrade()
    {
        upgradeAction?.Invoke(value);
    }
}