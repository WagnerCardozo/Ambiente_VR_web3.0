using UnityEngine;

public class HighlightInteractable : MonoBehaviour
{
    Renderer rend;

    Color originalColor;

    public Color highlightColor = Color.yellow;

    void Start()
    {
        rend = GetComponent<Renderer>();

        originalColor = rend.material.color;
    }

    public void Highlight()
    {
        rend.material.color = highlightColor;
    }

    public void UnHighlight()
    {
        rend.material.color = originalColor;
    }
}