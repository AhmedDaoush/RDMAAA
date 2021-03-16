using UnityEngine;


public class InteractableObject : MonoBehaviour, IInteractable
{
    [SerializeField]
    protected bool interactOnce = false;
    //protected float interactionRadius = 3f;

    public void Interact()
    {
        throw new System.NotImplementedException();
    }

}
