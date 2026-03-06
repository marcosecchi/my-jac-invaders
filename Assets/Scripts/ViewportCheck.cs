using UnityEngine;

public class ViewportCheck : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(IsInViewport());
    }

    bool IsInViewport()
    {
        Vector3 viewportPoint = Camera.main.WorldToViewportPoint(transform.position);
         return viewportPoint.x >= 0.1f && viewportPoint.x <= 0.9f &&
                            viewportPoint.y >= 0.1f && viewportPoint.y <= 0.9f &&
                            viewportPoint.z > 0;
    }
}
