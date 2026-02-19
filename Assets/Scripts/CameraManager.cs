using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public Transform target;

    void Start()
    {
        
    }

    void Update()
    {
        // Fa schifo   transform.position = target.position;

        var newPosition = Vector3.Lerp(transform.position, target.position, Time.deltaTime * 3);
        transform.position = newPosition;
    }
}
