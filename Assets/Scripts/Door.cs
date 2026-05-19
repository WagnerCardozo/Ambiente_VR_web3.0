using UnityEngine;

public class MicrowaveDoor : MonoBehaviour, IInteractable
{
    public Transform door;

    public bool isOpen;

    public float openAngle = 90f;

    public float speed = 4f;

    Quaternion closedRotation;

    Quaternion openRotation;

    void Start()
    {
        closedRotation = door.localRotation;

        openRotation = Quaternion.Euler(
            door.localEulerAngles +
            new Vector3(0, openAngle, 0)
        );
    }

    void Update()
    {
        Quaternion target =
            isOpen ? openRotation : closedRotation;

        door.localRotation = Quaternion.Lerp(
            door.localRotation,
            target,
            Time.deltaTime * speed
        );
    }

    public void Interact()
    {
        isOpen = !isOpen;

        Debug.Log("Interagiu com a porta");
    }
}