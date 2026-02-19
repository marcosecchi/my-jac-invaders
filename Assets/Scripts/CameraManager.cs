using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public Transform target1;
    public Transform target2;
    public Transform ship;

    Transform actualTarget;

    [Range(0f, 100f)]
    public float followSpeed = 1.0f;

    void Start()
    {
        actualTarget = target1;
    }

    void Update()
    {
        // Fa schifo   transform.position = target.position;

        if(Input.GetKeyDown(KeyCode.R))
        {
            if(actualTarget == target1)
            {
                actualTarget = target2;
            }
            else
            {
                actualTarget = target1;
            }
        }
        var newPosition = Vector3.Lerp(
            transform.position, actualTarget.position, Time.deltaTime * followSpeed);
        transform.position = newPosition;

        // Decommentare se si vuole che la camera punti al target
        //transform.LookAt(ship.position);
    }
}
