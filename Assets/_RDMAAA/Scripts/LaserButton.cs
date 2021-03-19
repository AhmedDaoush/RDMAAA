using UnityEngine;

public class LaserButton : InteractableObject
{

    [SerializeField]
    PeriodicEnemy script;
    [SerializeField]
    GameObject[] lasers;

    public new void Interact()
    {
        if (!canInteract) return;
        if (interactionType == InteractionType.Once)
        {
            canInteract = false;
        }
        foreach (var laser in lasers)
        {
            Destroy(laser);
        }

        if (script != null)
        {
            script.active = false;
            transform.parent.position = new Vector3(transform.position.x, 1, transform.position.z);
        }
        else
        {
            Debug.LogError("Script periodic enemy not found!!");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!canInteract) return;
        if (other.CompareTag("Player"))
        {
            Interact();
        }
    }
}
