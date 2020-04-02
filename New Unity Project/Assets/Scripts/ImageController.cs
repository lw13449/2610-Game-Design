using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class ImageController : MonoBehaviour
{
    public GameAction imageAction;
    private Image imageComponent;
    public FloatData data;
    private void Start ()
    {
        imageAction.action = UpdateImageComponent();
        imageComponent = GetComponent<Image>();
    }

    private object UpdateImageComponent()
    {
        throw new System.NotImplementedException();
    }

    public void UpdateImageHandler()
    {
        imageComponent.fillAmount += data.value;
    }
	
    public void UpdateImageComponent(float amount)
    {
        imageComponent.fillAmount += amount;
    }
	
    public void UpdateImageComponent(FloatData dataObj)
    {
        imageComponent.fillAmount = dataObj.value;
    }
}