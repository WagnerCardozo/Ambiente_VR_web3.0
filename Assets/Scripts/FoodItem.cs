using UnityEngine;

public class FoodItem : MonoBehaviour
{
    public bool isDefrosted;

    [Header("Ice Visual")]
    public GameObject iceCubeVisual;

    public void Defrost()
    {
        isDefrosted = true;

        if (iceCubeVisual != null)
        {
            iceCubeVisual.SetActive(false);
        }
    }

    public void ResetFrozen()
    {
        isDefrosted = false;

        if (iceCubeVisual != null)
        {
            iceCubeVisual.SetActive(true);
        }
    }
}
