using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class MathBehaviour : DoWork
{
    public FloatData dataObj;
    
    public override void Work()
    {
        dataObj.value++;
    }
}
