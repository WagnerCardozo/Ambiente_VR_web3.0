using UnityEngine;

public class MicrowaveController : MonoBehaviour
{
    [Header("Food")]
    public FoodItem currentFood;

    [Header("Timing")]
    public float minTargetTime = 5f;
    public float maxTargetTime = 9f;

    public float successWindow = 0.5f;

    private float targetTime;
    private float currentTime;

    [Header("State")]
    public bool isRunning;

    [Header("Visual")]
    public Light microwaveLight;

    void Update()
    {
        if (!isRunning)
            return;

        currentTime += Time.deltaTime;

        if (microwaveLight != null)
        {
            microwaveLight.enabled =
                Mathf.FloorToInt(Time.time * 8) % 2 == 0;
        }

        if (currentTime >= targetTime + successWindow)
        {
            Fail();
        }
    }

    public void StartMicrowave()
    {
        if (currentFood == null)
        {
            Debug.Log("No food inside.");
            return;
        }

        currentFood.ResetFrozen();

        currentTime = 0f;

        targetTime = Random.Range(minTargetTime, maxTargetTime);

        isRunning = true;

        Debug.Log("Target Time: " + targetTime);
    }

    public void StopMicrowave()
    {
        if (!isRunning)
            return;

        isRunning = false;

        if (microwaveLight != null)
        {
            microwaveLight.enabled = false;
        }

        float difference =
            Mathf.Abs(currentTime - targetTime);

        if (difference <= successWindow)
        {
            Success();
        }
        else if (currentTime < targetTime)
        {
            TooEarly();
        }
        else
        {
            Fail();
        }
    }

    void Success()
    {
        Debug.Log("SUCCESS");

        currentFood.Defrost();
    }

    void TooEarly()
    {
        Debug.Log("TOO EARLY");

        currentFood.ResetFrozen();
    }

    void Fail()
    {
        Debug.Log("GAME OVER");

        isRunning = false;

        if (microwaveLight != null)
        {
            microwaveLight.enabled = false;
        }
    }
}