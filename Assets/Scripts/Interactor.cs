using UnityEngine;
using TMPro;

public class Interactor : MonoBehaviour
{
    public float interactDistance = 3f;

    public LayerMask interactLayer;

    public GameObject interactText;

    HighlightInteractable currentHighlight;

    void Update()
    {
        Ray ray = new Ray(
            transform.position,
            transform.forward
        );

        bool hitSomething = Physics.Raycast(
            ray,
            out RaycastHit hit,
            interactDistance,
            interactLayer
        );

        // RESET HIGHLIGHT
        if (currentHighlight != null)
        {
            currentHighlight.UnHighlight();
            currentHighlight = null;
        }

        interactText.SetActive(false);

        // HIT
        if (hitSomething)
        {
            HighlightInteractable highlight =
                hit.collider.GetComponentInParent<HighlightInteractable>();

            if (highlight != null)
            {
                highlight.Highlight();
                currentHighlight = highlight;
            }

            IInteractable interactable =
                hit.collider.GetComponentInParent<IInteractable>();

            if (interactable != null)
            {
                interactText.SetActive(true);

                if (Input.GetMouseButtonDown(0))
                {
                    interactable.Interact();
                }
            }
        }
    }
}