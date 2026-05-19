using UnityEngine;

public class MicrowaveTrigger : MonoBehaviour
{
    public Transform snapPoint;

    bool occupied;

    private void OnTriggerEnter(Collider other)
    {
        if (occupied) return;

        FoodPickup food =
            other.GetComponentInParent<FoodPickup>();

        if (food != null)
        {
            occupied = true;

            food.SnapIntoMicrowave(snapPoint);

            Debug.Log("Comida encaixada");
        }
    }
}