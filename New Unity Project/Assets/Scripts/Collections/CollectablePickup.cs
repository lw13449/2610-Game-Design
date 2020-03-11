using UnityEngine;

public class CollectablePickup : Interactable
{
    public Collectable item;
    public override void Interact()
    {
        base.Interact();
        PickUp();
    }

    public void PickUp()
    {
        
        Debug.Log("Picking Up" + item.name);
        //Add item to inventory
        Destroy(gameObject);
    }
    
}