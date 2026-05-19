using UnityEngine;

public class FoodPickup : MonoBehaviour, IInteractable
{
    public Transform holdPoint;

    public bool isHeld;

    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void Interact()
    {
        if (!isHeld)
        {
            PickUp();
        }
        else
        {
            Drop();
        }
    }

    public void PickUp()
    {
        rb.isKinematic = true;

        transform.position = holdPoint.position;

        transform.SetParent(holdPoint);

        isHeld = true;
    }

    public float throwForce = 3f;

    public void Drop()
    {
        transform.SetParent(null);

        rb.isKinematic = false;

        isHeld = false;

        rb.linearVelocity = Vector3.zero;

        rb.AddForce(
            Camera.main.transform.forward * throwForce,
            ForceMode.Impulse
        );
    }

    public void SnapIntoMicrowave(Transform snapPoint)
    {
        rb.linearVelocity = Vector3.zero;

        rb.angularVelocity = Vector3.zero;

        rb.isKinematic = true;

        transform.SetParent(snapPoint);

        transform.localPosition = Vector3.zero;

        transform.localRotation = Quaternion.identity;

        isHeld = false;
    }
}