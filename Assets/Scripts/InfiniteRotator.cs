using UnityEngine;

public class InfiniteRotator : MonoBehaviour
{
    public float rotationSpeed = .3f;

    void Update()
    {
        transform.Rotate(Vector3.up, rotationSpeed);
        
    }
}
