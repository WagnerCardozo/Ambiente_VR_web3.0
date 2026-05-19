using UnityEngine;

public class MicrowaveButton : MonoBehaviour, IInteractable
{
    public MicrowaveController microwave;

    public bool startButton;

    public void Interact()
    {
        if (startButton)
        {
            microwave.StartMicrowave();
        }
        else
        {
            microwave.StopMicrowave();
        }
    }
}