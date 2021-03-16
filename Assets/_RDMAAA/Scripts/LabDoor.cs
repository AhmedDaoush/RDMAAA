using UnityEngine;

[RequireComponent(typeof(Rigidbody), typeof(SphereCollider))]
public class LabDoor : InteractableObject
{
    public new void Interact()
    {
        Debug.Log("door interacted");
        //transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(new Vector3(0, 95, 0), transform.up), Time.deltaTime * 3f);
        transform.localRotation = Quaternion.LookRotation(new Vector3(95, 0, 0));
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Interact();
        }
    }

}
