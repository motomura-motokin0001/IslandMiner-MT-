using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class AlphaButton : MonoBehaviour
{
    [Range(0, 1)] public float alphaThreshold = 0.1f;

    void Start()
    {
        Image img = GetComponent<Image>();
        img.alphaHitTestMinimumThreshold = alphaThreshold;
    }
}
