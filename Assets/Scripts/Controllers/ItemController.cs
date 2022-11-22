using Resources;
using UnityEngine;

public class ItemController : MonoBehaviour, IInteractable
{
    [SerializeField] private ResourceType _type;
    
    
    public void Interact(Collider other)
    {
        if (other.gameObject.tag != "Player")
            return;
        
        Debug.Log("Add res");
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        Interact(other);
    }
}
