using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public Transform target;
    public Transform ship;

    [Range(0f, 100f)]
    public float followSpeed = 1.0f;

    void Start()
    {
        
    }

    void Update()
    {
        // Fa schifo   transform.position = target.position;

        var newPosition = Vector3.Lerp(
            transform.position, target.position, Time.deltaTime * followSpeed);
        transform.position = newPosition;

        // Decommentare se si vuole che la camera punti al target
        // transform.LookAt(ship.position);
    }
}
