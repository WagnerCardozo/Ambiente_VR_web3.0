using UnityEngine;

public class ControleCamera : MonoBehaviour
{
    public float sensibilidade = 2f;

    public Transform corpoJogador;

    float rotacaoX = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensibilidade;

        float mouseY = Input.GetAxis("Mouse Y") * sensibilidade;

        // Vertical
        rotacaoX -= mouseY;

        rotacaoX = Mathf.Clamp(rotacaoX, -90f, 90f);

        transform.localRotation =
            Quaternion.Euler(rotacaoX, 0f, 0f);

        // Horizontal
        corpoJogador.Rotate(Vector3.up * mouseX);
    }
}