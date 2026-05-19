using UnityEngine;

public class Interactor : MonoBehaviour
{
    public float interactDistance = 3f;

    public LayerMask interactLayer;

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

        // HIGHLIGHT
        if (hitSomething)
        {
            HighlightInteractable highlight =
                hit.collider.GetComponentInParent<HighlightInteractable>();

            if (highlight != null)
            {
                highlight.Highlight();
                currentHighlight = highlight;
            }
        }

        // INTERAÇÃO
        if (Input.GetMouseButtonDown(0))
        {
            if (hitSomething)
            {
                IInteractable interactable =
                    hit.collider.GetComponentInParent<IInteractable>();

                if (interactable != null)
                {
                    interactable.Interact();
                }
            }
        }
    }
}