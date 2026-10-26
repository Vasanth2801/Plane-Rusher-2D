using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    public Renderer meshRenderer;

    public float scrollSpeed = 0.5f;

    void Update()
    {
        Vector2 offSet = meshRenderer.material.mainTextureOffset;
        offSet += new Vector2(0, scrollSpeed * Time.deltaTime);
        meshRenderer.material.mainTextureOffset = offSet;
    }
}