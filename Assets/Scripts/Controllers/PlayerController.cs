using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        IInteractable interactableObject = other.GetComponent<IInteractable>();

        if (interactableObject == null)
            return;
        
        interactableObject.Interact();
    }
}
