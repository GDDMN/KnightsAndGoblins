using UnityEngine;

public class ItemController : MonoBehaviour, IInteractable
{
    [SerializeField] private ResourceType _type;
    
    public void Interact()
    {
        Destroy(gameObject);
    }
}